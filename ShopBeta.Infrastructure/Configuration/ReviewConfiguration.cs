using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Infrastructure.Configuration
{
    class ReviewConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure ( EntityTypeBuilder<Reviews> builder)
        {
            builder.HasData(

                new Reviews
                {
                    ReviewId = 1,
                    Name = "Bode Thomas",
                    Comment = "A wonderful product, swift delivery",

                    date = DateTime.UtcNow,
                    ProductId = 1

                },
                 new Reviews
                 {
                     ReviewId = 2,
                     Name = "Tunde Brisibe",
                     Comment = "Great product but expensive",

                     date = DateTime.UtcNow,
                     ProductId = 1

                 }, new Reviews
                 {
                     ReviewId = 3,
                     Name = "Jesse Brisibe",
                     Comment = "wonderful laptop",

                     date = DateTime.UtcNow,
                     ProductId = 4

                 }

                );
        }

    }
}
