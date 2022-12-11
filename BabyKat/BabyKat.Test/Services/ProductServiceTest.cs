using BabyKat.Core.Contracts;
using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class ProductServiceTest :UnitTestBase
    {
        private IProductService productService;
        [SetUp]
        public void SetUp()
        {
            this.productService = new ProductService(this.repo);
        }

        [Test]

        public async Task AddProductAsync(){

            //Arrange
            ProductModel productModel = new ProductModel
            {
                Price = 10.00m,
                Description = "ON-THE-GO TRAVEL COT: As a parent, we know that life takes you many different places. So, we designed the Go With Me Bungalow to fit into a portable carry bag. Simply unpack it from the bag, expand the cot, lock it into place, and attach the canopy.\r\nMAXIMUM SAFETY & STYLE: Our strong and stable metal frame locks into place and keeps the cot secure wherever it goes. You shouldn’t have to sacrifice style for safety. That is why we created this neutral-colored Bungalow Deluxe to fit in any home’s décor.",
                Name = "Baby bed 2023",
                ImageUrl = "Idsasoajspojdapodjawpodj",
                CategoryId = 2

            };
            //Act
            productService.AddProductAsync(productModel);
            var count = this.dbContext.Products.Count();

            //Assert
            Assert.AreEqual(3, count);
        }

        [Test]

        public async Task RemoveProductFromCategory()
        {
            //Arrange
            var productTest = this.dbContext.Products.Where(p => p.Id == product.Id).FirstOrDefault();

            await productService.RemoveProductFromCategory(productTest.Id);

            //Act
            var result = this.dbContext.Products.Count();
            //Assert
            Assert.AreEqual(2, result);
        }
        [Test]
        public async Task GetCategoriesAsync()
        {
            var action = productService.GetCategoriesAsync().Result;

            var result = dbContext.Categories.Count();

            Assert.AreEqual(action.Count(), result);
        }

        [Test]
        public async Task GetProductsForCategoryAsync()
        {
            var categoryTest = dbContext.Categories.Where(p => p.Id == category.Id).FirstOrDefault();

            var action = productService.GetProductsForCategoryAsync(categoryTest.Id).Result;

            var result = dbContext.Products.Where(p => p.CategoryId == categoryTest.Id);

            Assert.AreEqual(action.Count(), result.Count());

        }


        [Test]
        public async Task GetProduct()
        {
            var productTest = this.dbContext.Products.Where(p => p.Id == product.Id).FirstOrDefault();

            var result = productService.GetProduct(productTest.Id).Result;

            Assert.AreEqual(productTest.Name, result.Name);
        }

        [Test]

        public async Task LastThreeProducts()
        {
            var productCollection = await productService.LastThreeProducts();

            Assert.AreEqual(2, productCollection.Count());
        }

    }
}
