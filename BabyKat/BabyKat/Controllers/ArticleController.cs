using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BabyKat.Controllers
{
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
        public async Task<IActionResult> Add()
        {
            var model = new ArticleModel();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleModel model)
        {

          
                await articleService.AddArticle(model);
                return RedirectToAction("All", "Post");

            
            
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await articleService.GetAllArticle();
            return View(model);
        }


    }
}
