using BabyKat.Core.Contracts;
using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Models.Userr;
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
  public class UserService: IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddProductToFavouriteAsync(int productId,string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);
            if (user == null)
            {
                throw new ArgumentException("Not a valid User ID");
            }

            var product = await repo.GetByIdAsync<Product>(productId);
            if (product == null)
            {
                throw new ArgumentException("Not a valid Product");
            }

            if (!user.Products.Any(g => g.Id == productId))
            {
                user.Products.Add(product);
                await repo.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("The product is already added!");
            }
        }

        public async Task<IEnumerable<AllUsers>> GetAllUsers()
        {
            return await repo.All<User>()
                 .Select(p => new AllUsers()
                 {
                     Id = p.Id,
                     UserName = p.UserName,
                     FirstName = p.FirstName,
                     LastName = p.LastName,
                     Email = p.Email,
                 }).ToListAsync();
        }

        public async Task<User> GetUserById(string userId)
        {
            return  await repo.GetByIdAsync<User>(userId);
            
        }

        public async Task<IEnumerable<ProductModel>> GetUserFavouriteProducts(string userId)
        {
            var user = await repo.All<User>().Where(p => p.Id == userId)
               .Include(p => p.Products).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("User dont exist!");
            }

            return user.Products.Select(u => new ProductModel()
            {
                Id = u.Id,
                Name = u.Name,
                Price = u.Price,
                Description = u.Description,
                ImageUrl = u.ImageUrl,
                CategoryId = u.CategoryId,

            });
        }

        public async Task RemoveProductFromFavouriteAsync(int productId, string userId)
        {
            var user = await repo.All<User>().Where(p => p.Id == userId)
               .Include(p => p.Products).FirstOrDefaultAsync();

            var product = await repo.All<Product>().Where(p => p.Id == productId)
              .Include(p => p.Posts).FirstOrDefaultAsync();

            user.Products.Remove(product);
            await repo.SaveChangesAsync();
            

        }
    }
}
