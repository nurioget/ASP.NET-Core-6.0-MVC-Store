using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> Ordes { get; }
        Order? GetOneOrder(int id);
        void Complate(int id);
        void SaveOrder(Order order);
        int NumberOfInProcess {  get; }
    }
}
