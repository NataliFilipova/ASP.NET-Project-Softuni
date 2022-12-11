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
       
          var posts = this.dbContext.Posts.Count(); // 0

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
            await postService.AddPost(postModel, user.Id);
           
            var result = this.dbContext.Posts.Count();
            Assert.AreEqual(result, posts+1);

        }

    }
}
