﻿using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Services.Contracts;


public class ProductManager : IProductService
{
    private readonly IRepositoryManager _manager;
    private readonly IMapper _mapper;

    public ProductManager(IRepositoryManager manager, IMapper mapper )
    {
        _manager = manager;
        _mapper = mapper;
    }



    public void CreateOneProduct(ProductDtoForInsertion productDto)
    {
       Product product = _mapper.Map<Product>( productDto );
        _manager.Product.Create(product);
        _manager.Save();
    }

    public void DeleteOneProduct(int id)
    {
        Product product = GetOneProduct(id, false);
        if (product is not null)
        {
            _manager.Product.DeleteOneProduct(product);
            _manager.Save();
        }


    }

    public IEnumerable<Product> GetAllProcucts(bool trackChanges)
    {
        return _manager.Product.GetAllProducts(trackChanges);
    }

    public IEnumerable<Product> GetAllProductsWitihDetails(ProductRequestParameters p)
    {
        return _manager.Product.GetAllProductsWitihDetails(p);
    }

    public IEnumerable<Product> GetLastestProcucts(int n, bool trackChanges)
    {
        return _manager
            .Product
            .FindAll(trackChanges)
            .OrderByDescending(prd => prd.ProductId)
            .Take(n);
    }

    public Product? GetOneProduct(int id, bool trackChanges)
    {
        var product = _manager.Product.GetOneProduct(id, trackChanges);
        if (product is null)
        {
            throw new Exception("Product not found!");
        }


        return product;

    }

    public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
    {
        var product = GetOneProduct(id, trackChanges);
        var productDto=_mapper.Map<ProductDtoForUpdate>(product);
        return productDto;
    }

    public IEnumerable<Product> GetShowcaseProducts(bool trackChanges)
    {
        var products = _manager.Product.GetShowcaseProducts(trackChanges);
        return products;
    }

    public void UpdateOneProduct(ProductDtoForUpdate productDto)
    {
        //var entitiy = _manager.Product.GetOneProduct(productDto.ProductId, true);
        //entitiy.ProductName = productDto.ProductName;
        //entitiy.Price = productDto.Price;
        //entitiy.CategoryId = productDto.CategoryId;

       var entitiy  = _mapper.Map<Product>(productDto);
        
        _manager.Product.UpdateOneProduct(entitiy);
        _manager.Save();
    }

 


}

