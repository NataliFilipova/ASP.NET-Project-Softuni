using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Postt;
using BabyKat.Core.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class PostServiceTest :UnitTestBase
    {
        private IPostService postService;

        [SetUp]

        public void SetUp()
        {
            this.postService = new PostService(this.repo);
        }

        [Test]
        public async Task Add_Post()
        {
           //Arrange
          var posts = this.dbContext.Posts.Count(); 

            var postModel = new PostModel
            {
                Title = "Bad news from me!",
                Rating = 5.00m,
                Description = "Hello from me, I'm not into this.",
                ProductId = product.Id,
                UserId = user.Id,
                Product = product,
                User = user
            };

            //Act
            await postService.AddPost(postModel, user.Id);
           
            var result = this.dbContext.Posts.Count();

            //Assert
            Assert.AreEqual(result, posts+1);

        }

        [Test]
        public async Task Get_All_Posts()
        {
            //Arrange
            var posts = dbContext.Posts;

            //Act
            var action = postService.GetAllPosts().Result;

            //Assert
            Assert.AreEqual(posts.Count(), action.Count());
        }

        [Test]

        public async Task Get_Posts_For_Product()
        {
            //Arrange
            var postTest = dbContext.Posts.Where(p => p.ProductId == product.Id).FirstOrDefault();

            //Act
            var posts = postService.GetPostsForProduct(postTest.ProductId).Result;

            //Assert
            Assert.AreEqual(product.Posts.Count, posts.Count());
        }

        [Test]
        public async Task Get_Posts_For_User()
        {
            //Arrange
            var postTest = dbContext.Posts.Where(p => p.UserId == user.Id).FirstOrDefault();
            //Act
            var posts = postService.GetPostsForUser(postTest.UserId).Result;

            //Assert
            Assert.AreEqual(user.Posts.Count, posts.Count());
        }

        [Test]
        public async Task Remove_Post()
        {
            //Arrange
            var posts = dbContext.Posts.Count();
            var postTest = dbContext.Posts.Where(p => p.Id == post.Id).FirstOrDefault();
            //Act
            postService.RemovePost(postTest.Id);
            var action = dbContext.Posts.Count();

            //Assert
            Assert.AreEqual(posts - 1, action);
        }
    }
}
