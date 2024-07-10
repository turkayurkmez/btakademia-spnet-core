using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    //Repository sadece entity'ler ile çalışır.
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);


    }
}
