//using eshop.Domain;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eshop.Infrastructure.Repositories
//{
//    public class FakeCategoryRepository : ICategoryRepository
//    {
//        private List<Category> _categories;

//        public FakeCategoryRepository()
//        {
//            _categories = new List<Category>
//             {
//                 new Category { Id = 1, Name="Bilgisayar"},
//                 new Category { Id = 2, Name="Kırtasiye"},
//                 new Category { Id = 3, Name="Mobilya"}
//             };
//        }
//        public IEnumerable<Category> GetAll()
//        {
//            return _categories;
//        }

//        public Category GetById(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
