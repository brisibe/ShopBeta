using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Interfaces;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
  public  class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        

          public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }


        public async Task<IEnumerable<Order>> GetOrdersAsync(bool includeItems, bool trackChanges) 
        {
            if (includeItems)
            {
                return await FindAll(trackChanges).Include(c => c.Items).ThenInclude(c => c.Product).ToListAsync();

            }
              
            else
            {
                return await FindAll(trackChanges).ToListAsync();
            }
        
        }

        public async Task<IEnumerable<Order>> GetOrderByUserNameAsync(string userName, bool includeItems, bool trackChanges)
        {
            if (includeItems)
            {
                return await FindByCondition(a => a.User.UserName.Equals(userName), trackChanges)
                .Include(a => a.Items)
                .ThenInclude(a => a.Product)
                .ToListAsync();
            }
            else
            {
                return await FindByCondition(c => c.User.UserName.Equals(userName), trackChanges).ToListAsync();
            }
        }

        public async Task<Order> GetOrdersByOrderNumberAsync(int orderNumber, bool trackChanges) =>
            await FindByCondition(a => a.OrderNumber.Equals(orderNumber), trackChanges)
            .Include(a => a.Items)
            .ThenInclude(a => a.Product.Name)
            .FirstOrDefaultAsync();

        public void CreateOrder(Order order) =>
            Create(order);

        public void DeleteOrder(Order order) =>
            Delete(order);
        
    }
}
