using eshop.Domain;

namespace eshop.Application.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
    }
}