using ShopBeta.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Core.DTO.Requests
{
    public class OrderCreationDto
    {
        public OrderCreationDto()
        {

            OrderNumber = GenerateNumbers.generate();
            OrderDate = DateTime.UtcNow;


        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }

        public ICollection<OrderItemCreationDto> Items { get; set; }
    }
}
