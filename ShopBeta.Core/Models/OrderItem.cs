﻿using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopBeta.Core.Models
{
   public  class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        
        public string Price { get; set;  }
        public string OldPrice { get; set; }
        public Order Order { get; set; }
        public Products Product { get; set; }

       
    }
}
