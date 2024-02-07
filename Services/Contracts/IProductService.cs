using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProcucts(bool trackChanges);

        Product? GetOneProduct(int id, bool trackChanges);

    }
}
