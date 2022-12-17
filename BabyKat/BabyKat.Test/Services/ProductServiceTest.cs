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

        public async Task Add_Product_Async(){

            //Arrange
            ProductRatingModel productModel = new ProductRatingModel
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

        public async Task Remove_Product_From_Category()
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
        public async Task Get_Categories_Async()
        {
            var action = productService.GetCategoriesAsync().Result;

            var result = dbContext.Categories.Count();

            Assert.AreEqual(action.Count(), result);
        }

        [Test]
        public async Task Get_Products_For_Category_Async()
        {
            var categoryTest = dbContext.Categories.Where(p => p.Id == category.Id).FirstOrDefault();

            var action = productService.GetProductsForCategoryAsync(categoryTest.Id).Result;

            var result = dbContext.Products.Where(p => p.CategoryId == categoryTest.Id);

            Assert.AreEqual(action.Count(), result.Count());

        }


        [Test]
        public async Task Get_Product()
        {
            var productTest = this.dbContext.Products.Where(p => p.Id == product.Id).FirstOrDefault();

            var result = productService.GetProduct(productTest.Id).Result;

            Assert.AreEqual(productTest.Name, result.Name);
        }

        [Test]

        public async Task Last_Three_Products()
        {
            var productCollection = await productService.LastThreeProducts();

            Assert.AreEqual(3, productCollection.Count());
        }
        [Test]

        public async Task Find_Product_By_Name()
        {
            //Arrange 
            var product = this.dbContext.Products.Where(p => p.Id == this.product.Id).FirstOrDefault();

            //Act 

            var result = this.productService.FindProduct(product.Name).Result;

            //Assert
            Assert.AreEqual(product.Price, result.Price);
        }
    }
}
