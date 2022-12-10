using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Models.Userr;
using BabyKat.Core.Services;
using BabyKat.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class UserServiceTest : UnitTestBase
    {
        private IUserService userService;

        [SetUp]
        public void SetUp()
        {
            this.userService = new UserService(this.repo);
        }

        [Test]

        public async Task Get_User_By_Id()
        {
            //Arrange 
            var userTest = this.dbContext.Users.Where(u => u.Id == this.user.Id).FirstOrDefault();

            //Act

            var result = this.userService.GetUserById(this.user.Id).Result;

            // Assert

            Assert.AreEqual(userTest.Country, result.Country);

        }

        [Test]
        public async Task Get_All_Users()
        {
            //Arrange
            var users = this.dbContext.Users.Count();

            //Act
            var result = this.userService.GetAllUsers().Result;

            //Assert

            Assert.AreEqual(users, result.Count());
        }

        [Test]
        public async Task Add_Product_To_Favourite_Async()
        {
            //Arrange
              var userTest = this.dbContext.Users.Where(u => u.Id == this.user.Id).FirstOrDefault();

            var productTest = this.dbContext.Products.Where(u => u.Id == this.product.Id).FirstOrDefault();

            //Act
            userService.AddProductToFavouriteAsync(this.product.Id, this.user.Id);
            var result = this.user.Products.Count;

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public async Task GetUserFavouriteProducts()
        {
            userService.AddProductToFavouriteAsync(this.product.Id, this.user.Id);

            var result = userService.GetUserFavouriteProducts(this.user.Id).Result;

            Assert.AreEqual(this.user.Products.Count, result.Count());
        }

    }

}
