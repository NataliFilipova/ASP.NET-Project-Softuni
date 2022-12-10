using BabyKat.Infrastructure.Data;
using BabyKat.Infrastructure.Data.Repositories;
using BabyKat.Test.Mocks;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    public class UnitTestBase
    {
        protected ApplicationDbContext dbContext;
        protected IRepository repo;

        [OneTimeSetUp]
        public void Setup()
        {
            this.dbContext = DatabaseMock.Instance;
            this.repo = new Repository(this.dbContext);
            this.SeedDatabase();

        }

        public User user { get; set; }
        public User user1 { get; set; }

        public Article article { get; set; }
        public Article article1 { get; set; }


        public Product product { get; set; }
        public Product product1 { get; set; }

        private void SeedDatabase()
        {
            var hasher = new PasswordHasher<User>();
           this.user = new User()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                FirstName = "Ivan",
                UserName = "ivancho",
                NormalizedUserName = "ivancho",
                LastName = "Petrov",
                Country = "Bulgaria",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            this.user.PasswordHash =
                 hasher.HashPassword(this.user, "agent123");

           
            this.user1 = new User()
            {
                Id = "2432423",
                FirstName = "Nikolai",
                UserName = "Petrov",
                NormalizedUserName = "ivancho",
                LastName = "Petrov",
                Country = "Bulgaria",
                Email = "agen2t@mail.com",
                NormalizedEmail = "agen2t@mail.com"
            };

            this.user1.PasswordHash =
                 hasher.HashPassword(this.user1, "agent123");

            this.dbContext.AddRange(this.user,this.user1);


            this.product = new Product()
            {


                Name = "OXO Tot Potty Chair",
                Price = 25.99m,
                Description =
                    "Pros: Rubber base, hold handle, suitable for multiple ages. " +
                    "Cons: Shallow seat, low splash guard" +
                    "Simple, sturdy, and easy to clean, this toddler toilet that has exactly what you need and no more.",
                CategoryId = 6,
                ImageUrl = "https://m.media-amazon.com/images/I/71XDXNt9n5L._SL1500_.jpg",
                Rating = 0.00m

            };
            this.product1 = new Product()
            {
                Name = "BabyBjörn Smart Potty",
                Price = 22.99m,
                Description =
                    "Pros: Deep bowl, convenient size, breeze to clean" +
                    "Cons: Limited age range, backless" +
                    "Small and functional potty that is perfect for budget minded parents",
                CategoryId = 6,
                ImageUrl = "https://m.media-amazon.com/images/I/61+uuyDhAcL._SL1500_.jpg",
                Rating = 0.00m
            };

            this.dbContext.AddRange(this.product, this.product1);

            this.article = new Article()
            {
                Title = "Best Baby Gifts of 2022",
                ImgUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/40/74/528883_883_XXXL.jpg",
                Description = "Finding a gift for new parents and their newborn is a thoughtful gesture. Many people struggle with picking a gift that is unique versus something more practical. But, our baby experts assure you that practicality is the way to go. Adjusting to life with a newborn can be overwhelming, and your friends will appreciate practical gifts that make their lives with a new baby simpler.\r\n\r\nThat's where we come in.\r\n\r\nNo one tests baby products as extensively or comprehensively as we do here at BabyGearLab. And our experts have put together a list of great gift ideas, all of which were quality vetted through our extensive review testing process. We constantly update this list, so it is always fresh, as new and interesting products come on the market and undergo our detailed review and testing.",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            this.article1 = new Article()
            {
                Title = "Best Baby Gear of 2022",
                ImgUrl = "https://bgl-i48k9hqubvkf8lnt.stackpathdns.com/photos/39/58/517361_9155_XXXL.jpg",
                Description = "While babies might be small, their needs are bigger and grow as they do. In the first few days coming home, you might be able to get by with a handful of items, but as the days progress, you'll need the top baby gear to take care of your little one with ease.\r\n\r\nThat's where BabyGearLab steps in.\r\n\r\nWe've comprehensively tested more baby products than anyone. Our baby experts have created a list of all the baby gear you need to make it through the first year of babyhood. We've included quality vetted baby gear through our extensive testing process in our in-house lab and in the real world. We regularly update this gear list to include the latest and greatest once they've passed our tests for award-winning status.\r\n\r\nHere is our baby gear list, including all the favorites we'd recommend to a friend getting ready to launch into the wonderful world of parenthood.",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            this.dbContext.AddRange(this.article, this.article1);
        }
    }
}
