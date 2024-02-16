using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IOrderService
    {
        IQueryable<Order> Ordes { get; }
        Order? GetOneOrder(int id);
        void Complate(int id);
        void SaveOrder(Order order);
        int NumberOfInProcess { get; }
    }
}
