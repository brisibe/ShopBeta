﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBeta.Core.Models
{
    public class Reviews
    {
        public int ReviewId { get; set; }
        public string Name { get; set; }

        public string Comment { get; set; }
        public DateTime date { get; set; } 

        public Products Product { get; set; }
        public int ProductId { get; set; }
    }
}
