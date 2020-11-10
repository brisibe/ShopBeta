using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
  public  class OrderRepository : RepositoryBase<Order>
    {
        

          public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }


        public async Task<IEnumerable<Order>> GetAllOrdersAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .ToListAsync();

        public async Task<Order> GetAllOrdersByUserId(string userId, bool trackChanges) =>
            await FindByCondition(a => a.User.Id.Equals(userId), trackChanges)
            .Include(a => a.Items)
            .FirstOrDefaultAsync();

        public void CreateOrder(Order order) =>
            Create(order);

        public void DeleteOrder(Order order) =>
            Delete(order);
        
    }
}
