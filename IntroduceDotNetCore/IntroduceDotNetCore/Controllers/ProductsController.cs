using Microsoft.AspNetCore.Mvc;

namespace IntroduceDotNetCore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
