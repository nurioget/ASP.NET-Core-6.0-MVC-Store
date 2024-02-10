using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;


public class ProductManager : IProductService
{
    private readonly IRepositoryManager _manager;

    public ProductManager(IRepositoryManager manager)
    {
        _manager = manager;
    }



    public void CreateOneProduct(Product product)
    {
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

    public Product? GetOneProduct(int id, bool trackChanges)
    {
        var product = _manager.Product.GetOneProduct(id, trackChanges);
        if (product == null)
        {
            throw new Exception("Product not found!");
        }
        return product;

    }



    public void UpdateOneProduct(Product product)
    {
        var entitiy = _manager.Product.GetOneProduct(product.ProductId, true);
        entitiy.ProductName = product.ProductName;
        entitiy.Price = product.Price;
        _manager.Save();
    }

 


}

