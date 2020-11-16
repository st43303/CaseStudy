using CaseStudy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var products = new List<Product>();
            var random = new Random();
            var range = 100000;

            for (var i = 0; i < 50; i++)
            {
                var productNumber = GetProductNumber(i + 1);
                products.Add(new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Produkt " + productNumber,
                    Created = DateTime.Now,
                    Description = "Popis k produktu č. " + productNumber,
                    ImgUri = "https://cdn.alza.cz/Foto/" + productNumber,
                    Price = (decimal)Math.Round(random.NextDouble() * range, 2)
                });
            }
            modelBuilder.Entity<Product>().HasData(products);
        }

        private string GetProductNumber(int number)
        {
            if(number < 10)
            {
                return "0" + number;
            }
            return number.ToString();
        }
    }
}
