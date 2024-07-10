using eshop.Application.Services;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class ShoppingController : Controller
    {

        private readonly IProductService productService;

        public ShoppingController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCard(int id)
        {
            var productResponse =  productService.GetProductCardResponse(id);

            //eğer session içinde varsa; sepette ürün vardır
            //................... yoksa; ilk kez sepet oluşuyordur.
            ShoppingCardCollection shoppingCardCollection = getCollectionFromSession();

            ShoppingCardItem cardItem = new ShoppingCardItem() { Product=productResponse, Quantity =1};
            shoppingCardCollection.Add(cardItem);



            return Json(new { message = $"{id} değeri sunucuya ulaştı"  });

        }

        private ShoppingCardCollection getCollectionFromSession()
        {
            return null;
        }
    }
}
