using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.DTO.Response
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public string Price { get; set; }
        public string OldPrice { get; set; }
    }
}
