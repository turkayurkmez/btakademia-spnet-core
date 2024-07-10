using eshop.Domain;
using eshop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EshopDbContext dbContext;

        public CategoryRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Category> GetAll()
        {
            return dbContext.Categories.AsEnumerable();
        }

        public Category GetById(int id)
        {
            return dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
