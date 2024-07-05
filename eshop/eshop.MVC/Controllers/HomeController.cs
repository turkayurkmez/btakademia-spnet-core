using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductCardResponse>()
            {
                new(){ Id=1, Name="POCO", Description="8GB Ram", Price=10000},
                new(){ Id=2, Name="Samsung ", Description="16GB Ram", Price=17000},
                new(){ Id=3, Name="IPad ", Description="8GB Ram", Price=25000},
                new(){ Id=4, Name="Homend ", Description="8GB Ram", Price=5000},
                new(){ Id=1, Name="A", Description="8GB Ram", Price=10000},
                new(){ Id=2, Name="B ", Description="16GB Ram", Price=17000},
                new(){ Id=3, Name="C ", Description="8GB Ram", Price=25000},
                new(){ Id=4, Name="D ", Description="8GB Ram", Price=5000}

            };
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
