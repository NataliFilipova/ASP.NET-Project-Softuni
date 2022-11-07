using BabyKat.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Contracts
{
    public interface IArticleService
    {
        Task AddArticle(PostModel model, string userId);

        Task DeleteArticle(PostModel model);

        Task<IEnumerable<PostModel>> GetAllArticle();
    }
}
