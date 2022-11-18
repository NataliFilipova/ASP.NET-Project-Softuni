using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BabyKat.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService _articleService)
        {
            articleService = _articleService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Read(int articleId)
        {
            var model = await articleService.GetArticle(articleId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ArticleModel();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleModel model)
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await articleService.AddArticle(model, userId);
            return RedirectToAction("All", "Post");



        }

        public async Task<IActionResult> RemoveArticle(int articleId)
        {
            await articleService.DeleteArticle(articleId);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await articleService.GetAllArticle();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int articleId)
        {
            var article = await articleService.GetArticle(articleId);
            return View(article);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int articleId, ArticleWithCommentsModel model)
        {
            await articleService.EditArticle(articleId, model);
            return RedirectToAction(nameof(All));
        }
    }
}
