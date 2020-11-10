using Microsoft.EntityFrameworkCore;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBeta.Infrastructure.Repository
{
    public class OrderItemRepository : RepositoryBase<OrderItem>
    {
        public OrderItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }


        public async Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync(int orderId, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(orderId), trackChanges)
            .ToListAsync();

        public void CreateOrderItem(OrderItem orderItem) =>
            Create(orderItem);

        public void DeleteOrderItem(OrderItem orderItem) =>
            Delete(orderItem);
           
    }
}
