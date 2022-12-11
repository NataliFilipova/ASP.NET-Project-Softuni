using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Commentt;
using BabyKat.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class CommentServiceTest :UnitTestBase
    {
        private ICommentService commentService;

        [SetUp]

        public void SetUp()
        {
            this.commentService = new CommentService(this.repo);
        }

        [Test]
        public async Task Add_Comment()
        {
            //Arrange
            var articleTest = this.dbContext.Articles.Where(u => u.Id == this.article.Id).FirstOrDefault();

            CommentModel commentModel = new CommentModel()
            {
                Article = articleTest,
                Description = "Idiaodwaoihdwaoidhoihwadoihawiodhawoihdawoidhawiohdaodwa",
                Author = "Ivanka",
                ArticleId = articleTest.Id
            };

            //Act
            commentService.AddComment(commentModel);

            var result = dbContext.Comments.Where(p => p.ArticleId == articleTest.Id).Count();

            //Assert
            Assert.AreEqual(3, result);

        }

        [Test]
        public async Task DeleteComment()
        {

            var articleCommentCount = article.Comments.Count(); 

            var action = commentService.DeleteComment(comment.Id);

            var result = article.Comments.Count();

            Assert.AreEqual(articleCommentCount - 1, result);
        }

    }

    
}
