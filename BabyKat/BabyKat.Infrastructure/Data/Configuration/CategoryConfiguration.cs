using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }
        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Strollers",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/25/514019_1219_XL.jpg"
                },
                new Category
                {
                     Id = 2,
                    Name = "Car Seats",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/58/517361_9155_XXXL.jpg"
                },
                new Category
                {
                     Id = 3,
                    Name = "Nursery",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/12/522701_27072_XXXL.jpg"
                },
                new Category
                {
                     Id = 4,
                    Name = "Health",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/44/525884_21115_XXXL.jpg"
                },
                new Category
                {
                     Id = 5,
                    Name = "Feeding",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/92/520712_12268_XXXL.jpg"
                },
                new Category
                {
                     Id = 6,
                    Name = "Diaper",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/33/524835_31524_XXXL.jpg"
                },
                 new Category
                {
                     Id = 7,
                    Name = "Soothe",
                    ImageUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/24/523962_24845_XXXL.jpg"
                },
                 new Category
                {
                     Id = 8,
                    Name = "Toys",
                    ImageUrl = "https://s13emagst.akamaized.net/products/1863/1862082/images/res_1b722249fcaa154fb1533cbcd08f8480.jpg"
                }
            };
            return categories;
        }
    }
}
