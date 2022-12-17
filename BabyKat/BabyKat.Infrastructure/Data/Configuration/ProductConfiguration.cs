using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                    ImageUrl = "https://m.media-amazon.com/images/I/71XDXNt9n5L._SL1500_.jpg",
                    Rating = 0.00m
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
                    ImageUrl = "https://m.media-amazon.com/images/I/61+uuyDhAcL._SL1500_.jpg",
                    Rating = 0.00m
                },
               new Product
                {
                    Id = 3,
                    Name = "BabyBjörn Toilet Trainer",
                    Price = 34.99m,
                    Description = "Adjustable, easy storage, one piece. Toilet needed, assistance needed. Space saving and portable potty seat great for small bathrooms and travel.",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/716ccNgQUSL._SX466_.jpg",
                    Rating = 0.00m
                },
                 new Product
                {
                    Id = 4,
                    Name = "Dreambaby Soft Touch Potty Seat",
                    Price = 24.98m,
                    Description = "Secure sitting area, soft on bottom, easy to store.Not for every toilet, noticeable wear over time.Cushy on-toilet trainer contoured to fit little bums.",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/716ccNgQUSL._SX466_.jpg",
                    Rating = 0.00m
                },
                new Product
                {
                    Id = 5,
                    Name = "Rumparooz Pocket",
                    Price = 25.95m,
                    Description = "Pocket style,Soft,Better cloth price,Requires stuffing,Synthetic fiber,Less impressive absorbency",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/51JiAyr7MjL._SX300_SY300_QL70_FMwebp_.jpg",
                    Rating = 0.00m
                },
                 new Product
                {
                    Id = 6,
                    Name = "Pampers Swaddlers Overnights",
                    Price = 0.48m,
                    Description = "Great absorbency, Good leak protection,Elemental chlorine-free,  Fragrance, Daytime & overnights are similar",
                    CategoryId = 6,
                    ImageUrl = "https://m.media-amazon.com/images/I/71fm7WgBFRL._AC_SX679_.jpg",
                    Rating = 0.00m
                },
                   new Product
                {
                    Id = 7,
                    Name = "Clek Oobr",
                    Price = 369.99m,
                    Description = "Great crash test results, high quality, rigid LATCH, Heavy, hard to move, harder to use. Impressive crash test results and quality materials make this a great choice ",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/47/516270_16078_S.jpg",
                    Rating = 0.00m
                },

                     new Product
                {
                    Id =8,
                    Name = "Diono Monterey XT",
                    Price = 139.99m,
                    Description = "Better crash test results, price, lighter. Less padding, quality. Less padding, quality ",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/47/516270_16078_S.jpg",
                    Rating = 0.00m
                },

                     new Product
                {
                    Id =9,
                    Name = "UPPAbaby Alta",
                    Price = 179.99m,
                    Description = "Reasonable price, better crash test analysis, super comfy, high-quality, Heavier, can't go backless, This high-quality booster is super comfortable, with better crash test analysis and a reasonable price.",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/66/528168_30157_S.jpg",
                    Rating = 0.00m
                },
                     new Product
                {
                    Id =10,
                    Name = "Chicco KidFit",
                    Price = 109.99m,
                    Description = "Easiest to use, better crash test results, price,Average quality, widest seat bottom,Nicely priced, easy to use option with better crash test results",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/66/528168_30157_S.jpg",
                    Rating = 0.00m
                },
                      new Product
                {
                    Id =11,
                    Name = "Peg Perego Viaggio Flex 120",
                    Price = 319.99m,
                    Description = "Easier to use, narrow width, comfortable,Higher price, higher HIC crash test result, Expensive, quality seat that is narrow and easy to use. ",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/48/516311_9127_XXXL.jpg",
                    Rating = 0.00m
                },
                               new Product
                {
                    Id =12,
                    Name = "Zoe Twin+",
                    Price = 299.00m,
                    Description = "Easy to use, giant canopies, quick fold, includes accessories. Brakes require extra attention to set, hard to push and turn off-road ",
                    CategoryId = 1,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/66/528137_7625_XXXL.jpg",
                    Rating = 0.00m
                },
                new Product
                {
                    Id =13,
                    Name = "Mountain Buggy Nano Duo",
                    Price = 549.95m,
                    Description = "Very small, well-made, adjustable leg rests.Expensive, harder to fold, no peek-a-boo windows ",
                    CategoryId = 1,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/74/518934_30632_XXXL.jpg",
                    Rating = 0.00m
                },
                 new Product
                {
                    Id =14,
                    Name = "Britax Boulevard ClickTight ARB",
                    Price = 399.99m,
                    Description = "Easy to install and use, cozy comfort, nice quality.Average crash test results.",
                    CategoryId = 2,
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/25/514035_20386_XL.jpg",
                    Rating = 0.00m
                },
                  
            };
            return products;
        }
    }
}
