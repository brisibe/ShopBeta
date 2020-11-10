using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopBeta.Infrastructure.Authentication
{
   public class UserAuthenticationDto
    {
        [Required(ErrorMessage ="user is required")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage ="password is required")]
        public string Password { get; set; }
    }
}
