using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.DataTransferObjects.Responses;
using eshop.Domain;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        List<ProductDisplayResponse> GetProductDisplayResponses(int? categoryId=null);
        ProductDisplayResponse GetProductDisplayResponse(int id);
        Task<int> CreateNewProduct(CreateNewProductRequest request);

        Task<Product> UpdateProduct(UpdateExistingProductRequest request);
        Task DeleteProduct(int id);

        UpdateExistingProductRequest GetExistingProductForUpdate(int id);
        List<ProductDisplayResponse> SearchByName(string name);

        bool IsProductExist(int id);
    }
}