using ShopBeta.Core.Helpers;
using ShopBeta.Core.Models;
using ShopBeta.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Models
{
  public  class Order
    {

      

        public int Id { get; set; } 
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public string ShippingAddress { get; set; }
        public string phone { get; set; }

        public User User { get; set; }
        public ICollection<OrderItem> Items { get; set; } 

        
    }

}
