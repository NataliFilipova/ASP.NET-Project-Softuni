using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Services
{
    public class ArticleService : IArticleService
    {
        public Task AddArticle(PostModel model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArticle(PostModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostModel>> GetAllArticle()
        {
            throw new NotImplementedException();
        }
    }
}
