using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PavolsProductShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext>options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<Category>().HasData(
              new Category {CategoryID=1,Name="Chocolates" },
              new Category {CategoryID=2,Name="Fruit Candy" },
              new Category {CategoryID=3,Name="GummyCandy" }
              );

            modelBuilder.Entity<Product>().HasData(
            new Product {
                ProductID= 1,
                CategoryID=1,
                Code="Chocolate_Assorted",
                Name = "Chocolate Assorted",
                Price=(decimal)4.99

            },
            new Product
            {
                ProductID = 2,
                CategoryID = 1,
                Code = "Chocolate_Mixed",
                Name = "Chocolate Mixed",
                Price = (decimal)5.99
             }
            );

        }


    }
}
