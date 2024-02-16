using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Order> Ordes => _context.Orderes
            .Include(o => o.Lines)
            .ThenInclude(cl => cl.Product)
            .OrderBy(o => o.Shipped)
            .ThenBy(o => o.OrderId);

        public int NumberOfInProcess =>
            _context.Orderes.Count(o => o.Shipped.Equals(false));

        public void Complate(int id)
        {
            var order = FindByCondition(o => o.OrderId.Equals(id), true);
            if (order is null)
                 throw new Exception("Order could not found!");
            order.Shipped = true;
           


        }

        public Order? GetOneOrder(int id)
        {
            return FindByCondition(o=>o.OrderId.Equals(id), false);

        }

        public void SaveOrder(Order order)
        {
         _context.AttachRange(order.Lines.Select(l=>l.Product));
            if (order.OrderId==0)
                _context.Orderes.Add(order);
            _context.SaveChanges();
        }
    }
}
