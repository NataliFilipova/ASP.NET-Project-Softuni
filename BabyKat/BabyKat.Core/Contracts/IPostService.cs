using BabyKat.Core.Models.Postt;
using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Contracts
{
   public interface IPostService
    {
        Task AddPost(PostModel model, string userId);

        Task<IEnumerable<PostModel>> GetAllPosts();

        Task<IEnumerable<PostModel>> GetPostsForProduct(int productId);
        Task<IEnumerable<PostModel>> GetPostsForUser(string userId);
        Task RemovePost(int postId);

    }
}
