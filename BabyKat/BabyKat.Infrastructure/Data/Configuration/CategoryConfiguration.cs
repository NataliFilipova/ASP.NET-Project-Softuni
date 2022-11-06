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
                    Name = "Strollers"
                },
                new Category
                {
                     Id = 2,
                    Name = "Car Seats"
                },
                new Category
                {
                     Id = 3,
                    Name = "Nursery"
                },
                new Category
                {
                     Id = 4,
                    Name = "Health"
                },
                new Category
                {
                     Id = 5,
                    Name = "Feeding"
                },
                new Category
                {
                     Id = 6,
                    Name = "Diaper"
                },
                 new Category
                {
                     Id = 7,
                    Name = "Soothe"
                }
            };
            return categories;
        }
    }
}
