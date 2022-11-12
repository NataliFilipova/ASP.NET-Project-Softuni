using BabyKat.Core.Models.Postt;
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

        Task DeletePost(PostModel model);

        Task<IEnumerable<PostModel>> GetAllPosts();



    }
}
