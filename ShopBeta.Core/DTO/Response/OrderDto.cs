using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.DTO.Response
{
   public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public string ShippingAddress { get; set; }
        public string phone { get; set; }

        public ICollection<OrderItemDto> Items { get; set; }
    }
}
