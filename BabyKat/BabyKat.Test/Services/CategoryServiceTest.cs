using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Categoryy;
using BabyKat.Core.Services;
using BabyKat.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    [TestFixture]
    public class CategoryServiceTest :UnitTestBase
    {
        private ICategoryService categoryService;
        [SetUp]
        public void SetUp()
        {
            this.categoryService = new CategoryService(this.repo);
        }

        [Test]

        public async Task GetCategoriesAsync()
        {
            var categories = dbContext.Categories.Count();

            var result = categoryService.GetCategoriesAsync().Result;

            Assert.AreEqual(categories, result.Count());
        }

        //[Test]
        //public async Task RemoveCategory()
        //{
        //    var count = dbContext.Categories.Count();
        //    var categoryTest = dbContext.Categories.Where(p => p.Id == category.Id).FirstOrDefault();


        //    categoryService.RemoveCategory(categoryTest.Id);
        //    var result = dbContext.Categories.Count();

        //    Assert.AreEqual(count - 1, result);
        //}
    }
}
