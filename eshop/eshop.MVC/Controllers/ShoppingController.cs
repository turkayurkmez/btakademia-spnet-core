using eshop.Application.Services;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            var shopping = getCollectionFromSession();
            return View(shopping);
        }

        public IActionResult AddToCard(int id)
        {
            var productResponse =  productService.GetProductDisplayResponse(id);

         
            ShoppingCardCollection shoppingCardCollection = getCollectionFromSession();

            ShoppingCardItem cardItem = new ShoppingCardItem() { Product=productResponse, Quantity =1};
            shoppingCardCollection.Add(cardItem);

            saveToSession(shoppingCardCollection);



            return Json(new { message = $"{id} değeri sunucuya ulaştı"  });

        }

       

        private ShoppingCardCollection getCollectionFromSession()
        {
            //eğer session içinde varsa; sepette ürün vardır
            //................... yoksa; ilk kez sepet oluşuyordur.
            var serializedBasket = HttpContext.Session.GetString("sepet");
            if (serializedBasket != null)
            {
                return JsonConvert.DeserializeObject<ShoppingCardCollection>(serializedBasket);
            }
            return new ShoppingCardCollection();


        }

        private void saveToSession(ShoppingCardCollection shoppingCardCollection)
        {
            var serializedBasket = JsonConvert.SerializeObject(shoppingCardCollection);
            HttpContext.Session.SetString("sepet",serializedBasket);
        }
    }
}
