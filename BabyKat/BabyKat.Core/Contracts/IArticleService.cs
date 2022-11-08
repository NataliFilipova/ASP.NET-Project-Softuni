using BabyKat.Core.Models.Articlesss;
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
        Task AddArticle(ArticleModel model);

        Task DeleteArticle(ArticleModel model);

        Task<IEnumerable<ArticleModel>> GetAllArticle();
    }
}
