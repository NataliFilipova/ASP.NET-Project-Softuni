using BabyKat.Core.Contracts;
using BabyKat.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace BabyKat.Areas.Users.Controllers
{
    [Area("Users")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
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

        public async Task<IActionResult> ShowProduct(int productId)
        {
            var model = await productService.GetProduct(productId);

            return View(model);
        }
    }
}
