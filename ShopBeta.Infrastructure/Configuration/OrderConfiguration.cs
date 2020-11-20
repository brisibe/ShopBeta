using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Infrastructure.Configuration
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                 new Order
                 {
                     Id = 1,
                     OrderDate = DateTime.Now,
                     OrderNumber = 12345,
                     phone = "+23450505050505",
                     ShippingAddress = "no 2, fadeyi bustop imeke",
                     Items = new List<OrderItem>()
                     { 
                      new OrderItem()
                      {
                         OldPrice = "30",
                         Price = "300",
                         OrderId = 1,
                         ProductId = 3,
                         Quantity = 5
                         
                      }
                     
                     }
                 },

                  new Order
                  {
                      Id = 2,
                      OrderDate = DateTime.Now,
                      OrderNumber = 12345,
                      phone = "+23450505050505",
                      ShippingAddress = "no 2, fadeyi bustop imeke",
                      Items = new List<OrderItem>()
                     {
                         new OrderItem
                         {
                             ProductId = 2,
                             OldPrice = "200,000",
                             Price = "190,000",
                             Quantity = 3,
                             OrderId = 2,
                         },
                           new OrderItem
                         {
                             ProductId = 3,
                             OldPrice = "500,000",
                             Price = "50,000",
                             Quantity = 1,
                             OrderId = 2,
                         }
                     }

                  }

                );
        }

    }
}
