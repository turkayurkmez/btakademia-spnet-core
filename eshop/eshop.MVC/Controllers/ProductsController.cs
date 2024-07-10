using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = productService.GetProductDisplayResponses();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = getCategoriesForSelect();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequest createNewProduct)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateNewProduct(createNewProduct);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = getCategoriesForSelect();
            return View();

        }

        IEnumerable<SelectListItem> getCategoriesForSelect()
        {
            return categoryService.GetCategories().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
        }

    }
}
