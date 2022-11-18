using BabyKat.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BabyKat.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserProductController : Controller
    {
        private readonly IProductService productService;

        public UserProductController(IProductService _productService)
        {
            productService = _productService;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await productService.GetAllAsync();
            return View(model);
        }


        public async Task<IActionResult> ShowCategory(int categoryId)
        {
            var model = await productService.GetProductsForCategoryAsync(categoryId);

            return View(model);
        }

    }
}
