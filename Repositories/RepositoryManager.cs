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

        private readonly IOrderRepository _orderRepository;

      

        public RepositoryManager(IProductRepository productRepository,
                                RepositoryContext context,
                                ICategoryRepositıry categoryRepositıry,
                                IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _context = context;
            _categoryRepositıry = categoryRepositıry;
            _orderRepository = orderRepository;

        }


      



        public IProductRepository Product =>_productRepository;

        public ICategoryRepositıry Category => _categoryRepositıry;

        public IOrderRepository Order => _orderRepository;

        public void Save()
        {
           _context.SaveChanges();
        }
    }
}
