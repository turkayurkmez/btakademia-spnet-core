

using eshop.Application.DataTransferObjects.Responses;

namespace eshop.Application.Services
{
    public class ProductService
    {

        private List<ProductCardResponse> _products;
        public ProductService()
        {
            _products = new List<ProductCardResponse>()
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
        }
        public List<ProductCardResponse> GetProductCardResponses()
        {
            return _products;
        }
    }
}
