using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly IProductRepository _productRepository;

        private readonly ICategoryRepositıry _categoryRepositıry;

      

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context,ICategoryRepositıry categoryRepositıry)
        {
            _productRepository = productRepository;
            _context = context;
            _categoryRepositıry = categoryRepositıry;
        }


      



        public IProductRepository Product =>_productRepository;

        public ICategoryRepositıry Category => _categoryRepositıry;

        public void Save()
        {
           _context.SaveChanges();
        }
    }
}
