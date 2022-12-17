using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BabyKat.Infrastructure.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateUserRole());
        }

        private List<IdentityRole> CreateUserRole()
        {
            var roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                    
                },
                new IdentityRole()
                {
                    Id = "2",
                    Name = "User",
                    NormalizedName = "USER"
                   
                },
            };
            return roles;
        }
    }
}
