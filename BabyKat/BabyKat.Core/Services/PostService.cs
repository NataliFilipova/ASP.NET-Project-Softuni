using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Postt;
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
    public class PostService : IPostService
    {

        private readonly IRepository repo;
        
        public PostService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task AddPost(PostModel model, string userId)
        {
            var product = await repo.GetByIdAsync<Product>(model.ProductId);
            var user = await repo.GetByIdAsync<User>(userId);
            var entity = new Post()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                ProductId = model.ProductId,
                UserId = model.UserId,
                Product = product,
                User = user

            };
            user.Posts.Add(entity);
            product.Posts.Add(entity);
            await repo.AddAsync<Post>(entity);
            
            await repo.SaveChangesAsync();  
        }
        public Task DeletePost(PostModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PostModel>> GetAllPosts()
        {
            return await repo.AllReadonly<Post>()
             .Select(p => new PostModel()
             {
                 Id = p.Id,
                 Title = p.Title,
                 Description = p.Description,
                 Product = p.Product,
                 Rating = p.Rating,
                 User = p.User
             }).ToListAsync();


        }
    }
}
