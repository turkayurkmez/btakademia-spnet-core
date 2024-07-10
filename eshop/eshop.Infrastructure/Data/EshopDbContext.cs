using eshop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Data
{
    public class EshopDbContext : DbContext
    {
        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=btaEshopDb;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(300);

            //Fluent API
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1, Name ="Bilgisayar ve Tablet" },
                new Category { Id = 2, Name = "Ses Sistemleri" },
                new Category { Id = 3, Name = "Monitör" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1, Name="Dell XPS 15", CategoryId=1, CreatedDate=DateTime.Now, Description="Açıklama", Price=96000},
                  new Product { Id = 10, Name = "MacBook Pro M2", CategoryId = 1, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 96000 },
                  new Product { Id = 2, Name = "Lenovo", CategoryId = 1, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 86000 },
                  new Product { Id = 3, Name = "Asus", CategoryId = 1, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 50000 },
                   new Product { Id = 4, Name = "Ses -A", CategoryId = 2, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 96000 },
                  new Product { Id = 5, Name = "Ses-B", CategoryId = 2, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 86000 },
                  new Product { Id = 6, Name = "Ses-C", CategoryId = 2, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 50000 },

                    new Product { Id = 7, Name = "M -A", CategoryId = 3, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 96000 },
                  new Product { Id = 8, Name = "M-B", CategoryId = 3, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 86000 },
                  new Product { Id = 9, Name = "M-C", CategoryId = 3, CreatedDate = DateTime.Now, Description = "Açıklama", Price = 50000 }


                );


        }
    }
}
