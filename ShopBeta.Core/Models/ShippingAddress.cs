using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBeta.Core.Models
{
    public class ShippingAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage ="phone number is required.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="address is requied")]
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }

    }
}
