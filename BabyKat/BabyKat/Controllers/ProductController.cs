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
           
          
                await productService.AddProductAsync(model);

                return RedirectToAction(nameof(All));
           
        }

        public async Task<IActionResult> RemoveProduct(int productId)
        {
            await productService.RemoveProductFromCategory(productId);
            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int productId)
        {
            var product = await productService.GetProduct(productId);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int productId, ProductModel model)
        {
            await productService.EditProduct(productId,model);
            return RedirectToAction(nameof(All));
        }
    }
}
