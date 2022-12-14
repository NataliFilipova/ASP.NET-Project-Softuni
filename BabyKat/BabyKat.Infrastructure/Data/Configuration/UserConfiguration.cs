using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BabyKat.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                FirstName= "Ivan",
                UserName = "ivancho",
                NormalizedUserName = "ivancho",
                LastName = "Petrov",
                Country = "Bulgaria",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };
            var user2 = new User()
            {
                Id = "dea12856-c198-4129-b3f3-b893d22295082",
                FirstName = "Natali",
                UserName = "gepeto",
                NormalizedUserName = "gepeto",
                LastName = "Petrov",
                Country = "Bulgaria",
                Email = "agent@mail.com",
                NormalizedEmail = "agen22t@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "agent123");
            user.PasswordHash =
                 hasher.HashPassword(user2, "agent123");

            users.Add(user);
            users.Add(user2);


            return users;
        }

    }
}
