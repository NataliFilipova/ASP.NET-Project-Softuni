using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Post;
using BabyKat.Infrastructure.Data;
using BabyKat.Infrastructure.Data.Repositories;
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
                UserId = userId,


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

        public Task<IEnumerable<PostModel>> GetAllPosts()
        {
            throw new NotImplementedException();
        }
    }
}
