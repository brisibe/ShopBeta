using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Infrastructure.Configuration
{
     class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(
                new Products
                {
                    ProductsId = 1,
                    Name = "Iphone 12",
                    Brand = "Apple",
                    Category = "Phones",
                     Description = "500Gb rom, 12mp rear camera, blah blah blah",
                     Price = "800,000",
                     OldPrice = "850,000",
                   
               
                },

                  new Products
                  {
                      ProductsId = 2,
                      Name = "Samsung Galaxy s11",
                      Brand = "Samsung",
                      Category = "Phones",
                      Description = "500Gb rom, 12mp rear camera, blah blah blah",
                      Price = "500,000",
                      OldPrice = "650,000",

                  },
                    new Products
                    {
                        ProductsId = 3,
                        Name = "Playstation 5",
                        Brand = "Sony",
                        Category = "Gaming",
                        Description = "500Gb hdd,  dual controller, lah blah blah",
                        Price = "200,000",
                        OldPrice = "250,000",

                    },
                      new Products
                      {
                          ProductsId = 4,
                          Name = "Acer Aspire E5",
                          Brand = "Acer",
                          Category = "Computer",
                          Description = "500Gb ROM, 8Gb RAM, Nvidia gtx 1020, core i7",
                          Price = "400,000",
                          OldPrice = "420,000",

                      }

                );
        }
    }
}
