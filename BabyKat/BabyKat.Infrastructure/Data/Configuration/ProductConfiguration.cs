using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(CreateProducts());
        }

        private List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "OXO Tot Potty Chair",
                    Price = 25.99m,
                    Description = 
                    "Pros: Rubber base, hold handle, suitable for multiple ages. " +
                    "Cons: Shallow seat, low splash guard" +
                    "Simple, sturdy, and easy to clean, this toddler toilet that has exactly what you need and no more.",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/71XDXNt9n5L._SL1500_.jpg"
                },
               new Product
                {
                    Id = 2,
                    Name = "BabyBjörn Smart Potty",
                    Price = 22.99m,
                    Description =
                    "Pros: Deep bowl, convenient size, breeze to clean" +
                    "Cons: Limited age range, backless" +
                    "Small and functional potty that is perfect for budget minded parents",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/61+uuyDhAcL._SL1500_.jpg"
                },
            };
            return products;
        }
    }
}
