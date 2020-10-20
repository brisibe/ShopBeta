using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public int Quantity { get; set; }
      
    }
}
