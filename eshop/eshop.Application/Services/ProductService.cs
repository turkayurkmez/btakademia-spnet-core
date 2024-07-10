

using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.DataTransferObjects.Responses;
using eshop.Domain;
using eshop.Infrastructure.Repositories;

namespace eshop.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductDisplayResponse GetProductDisplayResponse(int id)
        {
            var product = _productRepository.GetById(id);
            return new ProductDisplayResponse
            {
                Description = product.Description,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price,
            };
        }

        //public ProductService()
        //{
        //    //Bu işlem repository'nin soumluluğunda.
        //    //_products = new List<ProductCardResponse>()
        //    //{
        //    //    new(){ Id=1, Name="POCO", Description="8GB Ram", Price=10000},
        //    //    new(){ Id=2, Name="Samsung ", Description="16GB Ram", Price=17000},
        //    //    new(){ Id=3, Name="IPad ", Description="8GB Ram", Price=25000},
        //    //    new(){ Id=4, Name="Homend ", Description="8GB Ram", Price=5000},
        //    //    new(){ Id=5, Name="A", Description="8GB Ram", Price=10000},
        //    //    new(){ Id=6, Name="B ", Description="16GB Ram", Price=17000},
        //    //    new(){ Id=7, Name="C ", Description="8GB Ram", Price=25000},
        //    //    new(){ Id=8, Name="D ", Description="8GB Ram", Price=5000}

        //    //};
        //}
        public List<ProductDisplayResponse> GetProductDisplayResponses(int? categoryId = null)
        {
            var products = categoryId is null ? _productRepository.GetAll() : _productRepository.GetProductsByCategoryId(categoryId.Value);

            return products.Select(p => new ProductDisplayResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description ?? "Açıklama yok",
                ImageUrl = p.ImageUrl ?? "https://picsum.photos/200",
                Price = p.Price
            }).ToList();
        }

        public async Task<int> CreateNewProduct(CreateNewProductRequest request)
        {
            var product = new Product
            {
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.UtcNow,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Price = request.Price,
                Status = request.Status,
                Stock = request.Stock
            };
           await _productRepository.Create(product); 
            return product.Id;
        }
    }
}
