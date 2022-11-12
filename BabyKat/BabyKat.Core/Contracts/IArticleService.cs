using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Postt;
using BabyKat.Core.Models.Productt;
using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Contracts
{
    public interface IArticleService
    {
        Task AddArticle(ArticleModel model, string userId);
        Task EditArticle(int articleId, ArticleWithCommentsModel model);
        Task DeleteArticle(int articleId);

        Task<IEnumerable<ArticleModel>> GetAllArticle();
        Task<ArticleWithCommentsModel> GetArticle(int articleId);
    }
}
