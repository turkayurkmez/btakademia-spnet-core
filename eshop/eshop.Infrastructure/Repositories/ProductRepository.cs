using eshop.Domain;
using eshop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly EshopDbContext dbContext;

        public ProductRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products.AsEnumerable();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
           return dbContext.Products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public IEnumerable<Product> SearchProductsByName(string productName) => dbContext.Products.Where(p=>p.Name.Contains(productName)).ToList();
        
    }
}
