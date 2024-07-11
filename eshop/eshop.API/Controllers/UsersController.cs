using eshop.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Validate(userLoginModel.UserName, userLoginModel.Password);
                if (user != null)
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bu-ifade-onay-icin-kullanilacak-dikkat"));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Role, user.Role),

                    };

                    var token = new JwtSecurityToken(
                        issuer:"server.bta",
                        audience:"client.bta",
                        claims: claims,
                        notBefore:DateTime.Now,
                        expires: DateTime.Now.AddDays(2),
                        signingCredentials: credential);

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                }
                ModelState.AddModelError("login", "Hatalı Giriş ");
            }
            return BadRequest(ModelState);
        }
    }
}
