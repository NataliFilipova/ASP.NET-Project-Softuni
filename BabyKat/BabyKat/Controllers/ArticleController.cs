using Microsoft.AspNetCore.Mvc;

namespace BabyKat.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
