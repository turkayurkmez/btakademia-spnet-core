using Azure.Core;
using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProducts() => Ok(productService.GetProductDisplayResponses());

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProductById(int id)
        {
            var isExists = productService.IsProductExist(id);
            if (isExists)
            {
                var product = productService.GetProductDisplayResponse(id);
                return Ok(product);
            }
            return NotFound(new { errorMessage = $"{id} id'li ürün bulunamadı" });
        }
        [HttpGet("[action]/{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult SearchByName(string name)
        {
            var products = productService.SearchByName(name);

            string message = products.Count > 0 ? $"{products.Count} adet ürün bulundu" : "Bu isimde ürün bulunamadı";
            return Ok(new
            {
                count = products.Count,
                message = $"{message}",
                products = products
            });
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var id = await productService.CreateNewProduct(request);
                return CreatedAtAction(nameof(GetProductById), routeValues: new { id = id }, null);
            }
            return BadRequest();

        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Edit(int id, UpdateExistingProductRequest request)
        {
            if (productService.IsProductExist(id))
            {
                if (ModelState.IsValid)
                {
                    await productService.UpdateProduct(request);
                    return Ok(request);
                }
            }
            ModelState.AddModelError("info", $"{id} id'li ürün bulunmuyor!");
            return BadRequest(ModelState);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> Delete(int id)
        {
            if (productService.IsProductExist(id))
            {


                await productService.DeleteProduct(id);
                return Ok();

            }
            return BadRequest();
        }


    }
}
