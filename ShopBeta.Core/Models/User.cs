using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Models
{
   public class User
    {
        public Guid UserId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Products> products { get; set; }
        

    }

}
