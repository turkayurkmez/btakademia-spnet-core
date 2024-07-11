using eshop.Domain;

namespace eshop.Application.Services
{
    public interface IUserService
    {
        User Validate(string userName, string password);
    }
}