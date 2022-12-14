using BabyKat.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BabyKat.Areas.Users.Controllers
{ 

     [Area("Users")]
     [Authorize(Roles = "User")]
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
        public async Task<IActionResult> All()
        {
            var model = await articleService.GetAllArticle();
            return View(model);
        }
    }
}
