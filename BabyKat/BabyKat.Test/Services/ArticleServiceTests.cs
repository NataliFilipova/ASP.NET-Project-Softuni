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
    public class ArticleServiceTests : UnitTestBase
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
            ArticleModel articleModel = new ArticleModel()
            {
                Title = "Bananas in a tree.",
                Description = "It's healthy to eat bananas every day.",
                ImageUrl = "kartinksdwaopdwadopwajdpwa",
                UserId = user.Id

            };

            //Act

            articleService.AddArticle(articleModel, this.user.Id);

            var count = this.dbContext.Articles.Count();

            // Assert

            Assert.AreEqual(3, count);



        }

        [Test]
        public async Task DeleteArticle()
        {

            //Arrange
            var articleTest = this.dbContext.Articles.Where(u => u.Id == this.article.Id).FirstOrDefault();

            //Act
            articleService.DeleteArticle(articleTest.Id);

            //Assert
            Assert.AreEqual(2, this.dbContext.Articles.Count());


        }


        [Test]
        public async Task EditArticle()
        {
            var articleTest = this.dbContext.Articles.Where(u => u.Id == this.article.Id).FirstOrDefault();

            ArticleWithCommentsModel articleWithCommentsModel = new ArticleWithCommentsModel
            {
                
            }
        }
    }
}
