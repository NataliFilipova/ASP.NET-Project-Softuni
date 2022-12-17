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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUserRoles());

        }

        private IdentityUserRole<string> CreateUserRoles()
        {
            var user = new IdentityUserRole<string>()
            {
                RoleId = "1",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            return user;
        }
    }
}
