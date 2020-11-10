using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Models
{
 
        public class User : IdentityUser
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string StoreName { get; set; }

            public string Address { get; set; }
        }

}
