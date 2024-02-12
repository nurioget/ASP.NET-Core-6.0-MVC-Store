﻿using Entities.Models;
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
            new Product() { ProductId = 1, CategoryId = 2, ProductName = "Computer", Price = 17000 },
            new Product() { ProductId = 2, CategoryId = 2, ProductName = "Keyboard", Price = 1000 },
            new Product() { ProductId = 3, CategoryId = 2, ProductName = "Mause", Price = 500 },
            new Product() { ProductId = 4, CategoryId = 2, ProductName = "Monitor", Price = 7000 },
            new Product() { ProductId = 5, CategoryId = 2, ProductName = "Deck", Price = 1500 },
            new Product() { ProductId = 6, CategoryId = 1, ProductName = "History", Price = 25 },
            new Product() { ProductId = 7, CategoryId = 1, ProductName = "Hamlet", Price = 45 }
            );
        }
    }
}