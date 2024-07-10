using eshop.Application.DataTransferObjects.Responses;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        List<ProductCardResponse> GetProductCardResponses(int? categoryId=null);
        ProductCardResponse GetProductCardResponse(int id);
        
    }
}