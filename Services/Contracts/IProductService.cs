using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProcucts(bool trackChanges);

        Product? GetOneProduct(int id, bool trackChanges);

        void CreateOneProduct(Product product);
        void UpdateOneProduct(Product product);

        void DeleteOneProduct(int id);

    }
}
