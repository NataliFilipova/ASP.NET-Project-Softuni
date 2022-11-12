using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
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
    public class ArticleService : IArticleService
    { 
         private readonly IRepository repo;

        public ArticleService(IRepository _repo)
        {
            repo = _repo;
        }
    
        public async Task AddArticle(ArticleModel model, string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);
            var entity = new Article()
            {
                Title = model.Title,
                Description = model.Description,
                ImgUrl = model.ImageUrl,
                User = user,
                UserId = userId
                
            };
            
            await repo.AddAsync<Article>(entity);

            await repo.SaveChangesAsync();
        }

        public async Task DeleteArticle(int articleId)
        {
            await repo.DeleteAsync<Article>(articleId);
            await repo.SaveChangesAsync();
        }

        public async Task EditArticle(int articleId, ArticleWithCommentsModel model)
        {
            var article = await repo.GetByIdAsync<Article>(articleId);

            article.Title = model.Title;
            article.Description = model.Description;
            article.ImgUrl = model.ImageUrl;
          
            repo.Update(article);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ArticleModel>> GetAllArticle()
        {
            return await repo.AllReadonly<Article>()
            .Select(p => new ArticleModel()
            {
               Id = p.Id,
               Title = p.Title,
               Description= p.Description,
               ImageUrl = p.ImgUrl
              
            }).ToListAsync();

        }

        public async Task<ArticleWithCommentsModel> GetArticle(int articleId)
        {
            var article = await repo.GetByIdAsync<Article>(articleId);
            var comments = repo.AllReadonly<Comment>().Where(p => p.ArticleId == articleId).ToList();

            var entity = new ArticleWithCommentsModel()
            {
                Description = article.Description,
                Title = article.Title,
                Comments = comments,
                Id = articleId,
                UserId = article.UserId,
                User = article.User,
                ImageUrl =article.ImgUrl
            };
            return entity;
        }
    }
}
