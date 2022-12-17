using BabyKat.Core.Contracts;
using BabyKat.Core.Models._Product;
using BabyKat.Infrastructure.Data;
using BabyKat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Data;

namespace BabyKat.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles = "User,Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IMemoryCache memoryCache;
        public ProductController(IProductService _productService, IMemoryCache _memoryCache)
        {
            productService = _productService;
            memoryCache = _memoryCache;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
         //   var products = this.memoryCache.Get<IEnumerable<ProductRatingModel>>("ProductCacheKey");
         //   products = await productService.GetAllAsync();
          var model = await productService.GetAllAsync();
         //   var cacheOptions = new MemoryCacheEntryOptions()
           //     .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
           //this.cache.Remove("ProductCacheKey);



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
