using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Articlesss;
using BabyKat.Core.Models.Post;
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
    
        public async Task AddArticle(ArticleModel model)
        {
            var entity = new Article()
            {
                Title = model.Title,
                Description = model.Description,
                
              
            };
            
            await repo.AddAsync<Article>(entity);

            await repo.SaveChangesAsync();
        }

        public Task DeleteArticle(ArticleModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ArticleModel>> GetAllArticle()
        {
            return await repo.AllReadonly<Article>()
            .Select(p => new ArticleModel()
            {
               Id = p.Id,
               Title = p.Title,
               Description= p.Description,
              
            }).ToListAsync();

        }
    }
}
