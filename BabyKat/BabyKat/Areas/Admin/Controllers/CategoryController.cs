using BabyKat.Core.Contracts;
using BabyKat.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;



namespace BabyKat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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


        public async Task<IActionResult> RemoveCategory(int categoryId)
        {
            await categoryService.RemoveCategory(categoryId);
            return RedirectToAction(nameof(All));
        }

    }
}
