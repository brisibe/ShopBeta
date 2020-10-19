using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Entities.Requests
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        
        public string Brand { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }
        public string OldPrice { get; set; }
    }
}

