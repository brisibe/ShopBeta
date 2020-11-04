using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBeta.Core.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        public string Name { get; set; }

        public string Comment { get; set; }
        public DateTime date { get; set; } 

        public Products Product { get; set; }
        public int ProductId { get; set; }
    }
}
