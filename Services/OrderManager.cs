using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderManager : IOrderService
    {
        private readonly IRepositoryManager _manager;

        public OrderManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<Order> Ordes => _manager.Order.Ordes;

        public int NumberOfInProcess => _manager.Order.NumberOfInProcess;

        public void Complate(int id)
        {
            _manager.Order.Complate(id);
            _manager.Save();
        }

        public Order? GetOneOrder(int id)
        {
           return _manager.Order.GetOneOrder(id);
        }

        public void SaveOrder(Order order)
        {
           _manager.Order.SaveOrder(order);
        }
    }
}
