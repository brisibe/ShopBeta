using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopBeta.Core.Entities.Requests
{
   public class ProductCreationDto
    {
        [Required(ErrorMessage = "product name is required.")]
        [MaxLength(60, ErrorMessage = "Maximum length is 60")]
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
    }
}
