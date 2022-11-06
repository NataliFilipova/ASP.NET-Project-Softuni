using Microsoft.AspNetCore.Mvc;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Contracts;
using BabyKat.Core.Services;

namespace BabyKat.Controllers
{
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductModel()
            {
                Categories = await productService.GetCategoriesAsync()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await productService.AddProductAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong with creating a book.");

                return View(model);
            }
        }

        public async Task<IActionResult> RemoveProduct(int productId)
        {
            await productService.RemoveProductFromCategory(productId);
            return RedirectToAction(nameof(All));
        }
    }
}
