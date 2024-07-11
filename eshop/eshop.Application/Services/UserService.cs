using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>()
        {
            new User{ Id=1, Name="Test", UserName="test", Password="123", Email="test@test.com", Role="Admin"},
            new User{ Id=2, Name="Test2", UserName="test2", Password="123", Email="tes2t@test.com", Role="Client"},
            new User{ Id=3, Name="Test3", UserName="test3", Password="123", Email="test3@test.com", Role="Tracker"},

        };
        public User Validate(string userName, string password)
        {
            return users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
        }
    }
}
