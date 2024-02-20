using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Config
{
    public class ProdcutConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
            new Product() { ProductId = 1, CategoryId = 2,ImageUrl="/images/1.jpg", ProductName = "Computer", Price = 17000 ,ShowCase=false},
            new Product() { ProductId = 2, CategoryId = 2,ImageUrl="/images/2.jpg", ProductName = "Keyboard", Price = 1000 ,ShowCase=false},
            new Product() { ProductId = 3, CategoryId = 2,ImageUrl="/images/3.jpg", ProductName = "Mause", Price = 500 ,ShowCase=false},
            new Product() { ProductId = 4, CategoryId = 2,ImageUrl="/images/4.jpg", ProductName = "Monitor", Price = 7000 ,ShowCase=false},
            new Product() { ProductId = 5, CategoryId = 2,ImageUrl="/images/5.jpg", ProductName = "Deck", Price = 1500 ,ShowCase=false},
            new Product() { ProductId = 6, CategoryId = 1,ImageUrl="/images/6.jpg", ProductName = "History", Price = 25 ,ShowCase=false},
            new Product() { ProductId = 7, CategoryId = 1,ImageUrl="/images/7.jpg", ProductName = "Hamlet", Price = 45 ,ShowCase=false},
            new Product() { ProductId = 8, CategoryId = 1,ImageUrl="/images/8.jpg", ProductName = "Xp-pen", Price = 1120 ,ShowCase=true},
            new Product() { ProductId = 9, CategoryId = 2,ImageUrl="/images/9.jpg", ProductName = "Galaxy 10", Price = 4440 ,ShowCase=true},
            new Product() { ProductId = 10, CategoryId = 2,ImageUrl="/images/10.jpg", ProductName = "Hp Mause", Price = 600 ,ShowCase=true}
            );
        }
    }
}
