using BabyKat.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BabyKat.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await categoryService.GetCategoriesAsync();
            return View(model);
        }

      

    }
}
