using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Services;
using BabyKat.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class ArticleServiceTests :UnitTestBase
    {
        private IArticleService articleService;

        [SetUp]
        public void SetUp()
        {
            this.articleService = new ArticleService(this.repo);


        }

        [Test]

        public async Task Add_Article()
        {
            //Arrange 
            var hasher = new PasswordHasher<User>();
            var user = new User()
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

            user.PasswordHash =
                 hasher.HashPassword(user, "agent123");


            this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();

            ArticleModel articleModel = new ArticleModel()
            {
                Title = "Bananas in a tree.",
                Description = "It's healthy to eat bananas every day.",
                ImageUrl = "kartinksdwaopdwadopwajdpwa",
                UserId = user.Id

            };

            //Act

            articleService.AddArticle(articleModel, user.Id);

            var count = this.dbContext.Articles.Count();

            // Assert

            Assert.AreEqual(1, count);

            

        }
        [Test]
        public async Task DeleteArticle()
        {

        }
    }
}
