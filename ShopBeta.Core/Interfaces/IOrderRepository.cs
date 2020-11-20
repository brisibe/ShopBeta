using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Core.Interfaces
{
   public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrdersAsync(bool includeItems, bool trackChanges);
        Task<Order> GetOrdersByOrderNumberAsync(int orderNumber, bool trackChanges);

        Task<IEnumerable<Order>> GetOrderByUserNameAsync(string username,bool includeItems, bool trackChanges);

        void CreateOrder(Order order);
        void DeleteOrder(Order order);


    }
}
