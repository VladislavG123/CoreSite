using CoreSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSite.DataAccess
{
    public class ShopContext :DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Cost = 2300, Name = "Наушники", Descripion = "Супер пупер наушники. Топ звук" },
                new Product { Cost = 200, Name = "Овсянка", Descripion = "Лучшая овсянка" },
                new Product { Cost = 300000, Name = "IPhone12", Descripion = "Почти оригинал" });
        }
    }
}
