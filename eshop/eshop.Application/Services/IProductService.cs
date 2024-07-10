using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.DataTransferObjects.Responses;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        List<ProductDisplayResponse> GetProductDisplayResponses(int? categoryId=null);
        ProductDisplayResponse GetProductDisplayResponse(int id);
        Task<int> CreateNewProduct(CreateNewProductRequest request);
    }
}