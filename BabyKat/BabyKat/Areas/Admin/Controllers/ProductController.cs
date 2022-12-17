using Microsoft.AspNetCore.Mvc;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Contracts;
using BabyKat.Core.Services;
using BabyKat.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using BabyKat.Core.Models._Product;

namespace BabyKat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
            var model = new ProductRatingModel()
            {
                Categories = await productService.GetCategoriesAsync(),

            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductRatingModel model)
        {


            try
            {
                await productService.AddProductAsync(model);

                return RedirectToAction(nameof(All));
            }
            catch (Exception e)
            {
                var errorMessage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", errorMessage);
            }
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
        public async Task<IActionResult> Edit(int productId, ProductRatingModel model)
        {
            try
            {
                await productService.EditProduct(productId, model);
                return RedirectToAction(nameof(All));
            }
            catch (Exception e)
            {
                var errorMessage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", errorMessage);
            }
        }
 
        public async Task<IActionResult> FindProductByName(string id)
        {
            try
            {
                var product = await productService.FindProduct(id);
                
               return View(product);
            }
            catch (Exception e)
            {
                var erroMassage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", erroMassage);
            }
        }
    }
}
