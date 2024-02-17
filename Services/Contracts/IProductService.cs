using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProcucts(bool trackChanges);

        IEnumerable<Product> GetShowcaseProducts(bool trackChanges);

        Product? GetOneProduct(int id, bool trackChanges);

        void CreateOneProduct(ProductDtoForInsertion productDto);
        void UpdateOneProduct(ProductDtoForUpdate productDto);

        void DeleteOneProduct(int id);
       ProductDtoForUpdate  GetOneProductForUpdate(int id, bool trackChanges);
    }
}
