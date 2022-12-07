using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Commentt;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Services;
using BabyKat.Infrastructure.Data;
using BabyKat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BabyKat.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles = "User,Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add(int articleId)
        {
            var model = new CommentModel()
            {
                ArticleId = articleId,
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CommentModel model)
        {
            try
            {
                await commentService.AddComment(model);

                return RedirectToAction("Read", "UserArticle", new {model.ArticleId });
            }
            catch (Exception e)
            {
                var errorMessage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", errorMessage);
            }
        }

        public async Task<IActionResult> Remove(int commentId)
        {
            int articleId = await commentService.DeleteComment(commentId);
            return RedirectToAction("Read", "UserArticle", new { articleId });
        }
    }
}
