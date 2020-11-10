using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.DTO.Response
{
    public class ProductsDto
    {
        public int ProductsId { get; set; }      
        public string Name { get; set; }

        public string Brand { get; set; }

    
        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public string OldPrice { get; set; }




    }
}
