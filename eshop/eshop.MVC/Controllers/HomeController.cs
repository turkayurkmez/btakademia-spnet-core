using eshop.Application.Services;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index(int pageNo=1, int? categoryId=null)
        {
            /*
             * Burada değişiklik yapmak için karşılaşabileceğiniz çok sebep var
             *  1. Yeni bir ürün özelliği
             *  2. Ürünlerin nereden geleceği (db, api, excel)
             *  3. Ürünlerin nasıl geleceği (EF, ADO, HttpClient vs)
             *  
             */
            //var productService = new  ProductService();

            var products = _productService.GetProductCardResponses(categoryId) ;
            var total = products.Count;
            var pageSize = 8;
            var totalPage = (int)Math.Ceiling( (decimal)total/ pageSize);
            ViewBag.TotalPage = totalPage;

            /*    ((pageNo-1)pageSize)   (pageSize * pageNo) 
             *1:  0..8
             *2:  8..16
             */

            var startIndex = ((pageNo - 1) * pageSize);
            var endIndex = startIndex + pageSize;
            var paginatedProducts = products.Take(startIndex..endIndex);

            return View(paginatedProducts);
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
