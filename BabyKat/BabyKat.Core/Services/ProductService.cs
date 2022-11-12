using BabyKat.Core.Contracts;
using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Categoryy;
using BabyKat.Core.Models.Productt;
using BabyKat.Infrastructure.Data;
using BabyKat.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;
        public ProductService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
           return await repo.AllReadonly<Category>().ToListAsync();
              

                
        }
        public async Task<IEnumerable<ProductRatingModel>> GetProductsForCategoryAsync(int categoryId)
        {
            var category = await repo.GetByIdAsync<Category>(categoryId);

            return await repo.AllReadonly<Product>()
                .OrderByDescending(p => p.Id)
                .Where(p => p.CategoryId == category.Id)
                .Select(p => new ProductRatingModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Posts = p.Posts,
                    Rating = p.Posts.Count == 0 ? 0.00m : p.Posts.Average(p => p.Rating)

                })
                 
                .ToListAsync();

        }

        public async Task AddProductAsync(ProductModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                
                CategoryId = model.CategoryId
            };

            await repo.AddAsync(entity);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductHomeModel>> LastThreeProducts()
        {
            return await repo.AllReadonly<Product>()
                .OrderByDescending(p => p.Id)
                .Select(p => new ProductHomeModel() 
                { 
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name
                })
                 .Take(2)
                .ToListAsync();
        }

          public async Task<IEnumerable<ProductRatingModel>> GetAllAsync()
            { 
            
           return  await repo.AllReadonly<Product>()



             .Select(p => new ProductRatingModel()
             {
                 Id = p.Id,
                 Name = p.Name,
                 Description = p.Description,
                 ImageUrl= p.ImageUrl, 
                 Price = p.Price,
                 CategoryId = p.CategoryId,
                 Posts = p.Posts, 
                 Rating = p.Posts.Count == 0 ? 0.00m : p.Posts.Average(p => p.Rating)
             }).ToListAsync();

            

        }

        public async Task RemoveProductFromCategory(int productId)
        {
            await repo.DeleteAsync<Product>(productId);
            await repo.SaveChangesAsync();
        }

        public async Task<ProductRatingModel> GetProduct(int productId)
        {
            var product = await repo.GetByIdAsync<Product>(productId);
            var category = await repo.GetByIdAsync<Category>(product.CategoryId);

            var entity = new ProductRatingModel()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId,
                Categories = await repo.AllReadonly<Category>().ToListAsync(),
                CategoryName = category.Name,
                Rating = product.Posts.Average(p => p.Rating)
                

             };
            return entity; 
        }

        

        public async Task EditProduct(int productId, ProductModel model)
        {
            var product = await repo.GetByIdAsync<Product>(productId);

            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.ImageUrl = model.ImageUrl;
            product.CategoryId = model.CategoryId;

            repo.Update(product);
            await repo.SaveChangesAsync();

        }

       
    }
}
