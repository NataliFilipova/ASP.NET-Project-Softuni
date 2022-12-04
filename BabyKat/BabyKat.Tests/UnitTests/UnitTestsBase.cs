//using BabyKat.Infrastructure.Data;
//using BabyKat.Infrastructure.Data.Repositories;
//using BabyKat.Tests.Mocks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BabyKat.Tests.UnitTests
//{
//   public class UnitTestsBase
//    {
//        protected Repository repo;

//        [OneTimeSetUp]

//        public void SetUpBase()
//        {
//            this.repo = DatabaseMock.Instance;
//            this.SeedDatabase();
//        }

//        public User User { get; private set; }
//        public Product Product { get; private set; }

//        private void SeedDatabase()
//        {
//            this.User = new User()
//            {

//                Id = "userId",
//                FirstName = "Ivan",
//                UserName = "ivancho",
//                NormalizedUserName = "ivancho",
//                LastName = "Petrov",
//                Country = "Bulgaria",
//                Email = "user@mail.com",
//                NormalizedEmail = "user@mail.com"
//            };
//            this.data.Users.Add(this.User);

//            this.Product = new Product()
//            {
//                Id = 20,
//                Name = "testProuct",
//                Price = 26.99m,
//                Description =
//                    "Pros: Rubber base, hold handle, suitable for multiple ages. " +
//                    "Cons: Shallow seat, low splash guard" +
//                    "Simple, sturdy, and easy to clean, this toddler toilet that has exactly what you need and no more.",
//                CategoryId = 6,
//                ImageUrl = "https://m.media-amazon.com/images/I/71XDXNt9n5L._SL1500_.jpg",
//                Rating = 0.00m
//            };
//            this.data.Products.Add(this.Product);
//            this.data.SaveChanges();
//        }

//        public void TearDownBase()
//            => this.data.Dispose();
//    }
//}
