using eshop.Application.Services;
using eshop.Infrastructure.Data;
using eshop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.CommonExtensions
{
    public static class IoCExtensions
    {
        /// <summary>
        /// Bu extension method, web uygulamasının veya API'nin ayağa kalkması için gereken tüm nesneleri IoC içerisine kaydeder. Buna DbContext nesnesi de dahil.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString">DbContext'in erişeceği db bağlantı cümlesi....</param>
        /// <returns></returns>
        public static IServiceCollection AddNecessaryInstances(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserService,UserService>();
            services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }
    }
}
