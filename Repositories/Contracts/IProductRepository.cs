﻿using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoriesBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        IQueryable<Product> GetAllProductsWitihDetails(ProductRequestParameters p);
        IQueryable<Product> GetShowcaseProducts(bool trackChanges);

        Product? GetOneProduct(int id, bool trackChanges);
        void CreateOneProduct(Product product);

        void DeleteOneProduct(Product product);
        void UpdateOneProduct(Product entitiy);
    }
}
