using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.Entities.Requests
{
    public class ReviewsDto
    {
        public string Name { get; set; }

        public string Comment { get; set; }
        public DateTime date { get; set; } = DateTime.Now;

     
    }
}
