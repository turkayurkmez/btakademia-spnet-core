

using eshop.Application.DataTransferObjects.Responses;
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
        public List<ProductCardResponse> GetProductCardResponses()
        {
            var products = _productRepository.GetAll();
            return products.Select(p => new ProductCardResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description ?? "Açıklama yok",
                ImageUrl = p.ImageUrl ?? "https://picsum.photos/200",
                Price = p.Price
            }).ToList();
        }
    }
}
