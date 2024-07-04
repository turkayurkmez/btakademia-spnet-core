using IntroduceDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduceDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ad = "Türkay";
            ViewBag.Saat = DateTime.Now.Hour;
            ViewBag.Ulkeler = new List<string> { "Türkiye", "Avusturya", "Hollanda" };

            var people = new List<Person> {
                new Person { Id = 1, Name = "Türkay", LastName = "Ürkmez", Description = "Yazılımcı / Eğitimci" },
                new Person { Id = 2, Name = "Ali Rıza", LastName = "Yılmaz", Description = "Yazılımcı / Katılımcı" },
                new Person { Id = 3, Name = "Sümeyra", LastName = "İçen", Description = "Yazılımcı / Katılımcı" },


            };

            ViewBag.People = people;



            return View(people);
        }

        public IActionResult InviteResponse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InviteResponse(UserResponse userResponse)
        {
            //UserResponse userResponse = new UserResponse();
            //userResponse.Name = formCollection["Name"];
            if (ModelState.IsValid)
            {
                return View("Thanks", userResponse);
            }
            return View();
        }


    }
}
