using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBeta.Core.Models
{
    public class Products
    {
        [Column("ProductId")]
        [Key]
        public int productId { get; set; }

        [Required(ErrorMessage ="product name is required.")]
        [MaxLength(60, ErrorMessage ="Maximum length is 60")]
        public string Name { get; set; }

        [Required(ErrorMessage = "product brand is required.")]
        [MaxLength(50)]
        public string Brand { get; set; }

        [Required(ErrorMessage = "product category is required.")]
        [MaxLength(50)]
        public string Category { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "product price is required.")]
        public string Price { get; set; }
        public string OldPrice { get; set; }

        public ICollection<Reviews> reviews { get; set; }



    }
}
