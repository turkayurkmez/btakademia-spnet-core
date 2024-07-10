using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products;
        public FakeProductRepository()
        {
            _products = new List<Product>()
            {
                new(){ Id=1, Name="POCO", Description="8GB Ram", Price=10000,CategoryId=1},
                new(){ Id=2, Name="Samsung ", Description="16GB Ram", Price=17000,CategoryId=1},
                new(){ Id=3, Name="IPad ", Description="8GB Ram", Price=25000,CategoryId=1},
                new(){ Id=4, Name="Homend ", Description="8GB Ram", Price=5000,CategoryId=1},
                new(){ Id=5, Name="A", Description="8GB Ram", Price=10000,CategoryId=2},
                new(){ Id=6, Name="B ", Description="16GB Ram", Price=17000,CategoryId=2},
                new(){ Id=7, Name="C ", Description="8GB Ram", Price=25000,CategoryId=2},
                new(){ Id=8, Name="D ", Description="8GB Ram", Price=5000,CategoryId=2},
                  new(){ Id=1, Name="K", Description="8GB Ram", Price=10000,CategoryId=3},
                new(){ Id=2, Name="X ", Description="16GB Ram", Price=17000,CategoryId=3},
                new(){ Id=3, Name="Y ", Description="8GB Ram", Price=25000,CategoryId=3},
                new(){ Id=4, Name="Z ", Description="8GB Ram", Price=5000,CategoryId=1},
                new(){ Id=5, Name="Q", Description="8GB Ram", Price=10000,CategoryId=2},
                new(){ Id=6, Name="T ", Description="16GB Ram", Price=17000,CategoryId=3},
                new(){ Id=7, Name="W ", Description="8GB Ram", Price=25000,CategoryId=1},
                new(){ Id=8, Name="P ", Description="8GB Ram", Price=5000,CategoryId=2}
            };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
           return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public IEnumerable<Product> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
