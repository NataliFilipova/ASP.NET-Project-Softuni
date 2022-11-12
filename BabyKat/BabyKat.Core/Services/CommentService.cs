using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Commentt;
using BabyKat.Core.Models.Postt;
using BabyKat.Infrastructure.Data;
using BabyKat.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository repo;
        public CommentService(IRepository _repository)
        {
            repo = _repository; 
        }
        public async Task AddComment(CommentModel model)
        {
            var article = await repo.GetByIdAsync<Article>(model.ArticleId);
            var entity = new Comment()
            {
                Author = model.Author,
                ArticleId = model.ArticleId,
                Description = model.Description,
                Id = model.Id,
                Article = article
            };
            article.Comments.Add(entity);
            await repo.AddAsync<Comment>(entity);
            await repo.SaveChangesAsync();
        }

        public async Task<int> DeleteComment(int commentId)
        {
            var entity = await repo.GetByIdAsync<Comment>(commentId);
            int articleId = entity.ArticleId;
            await repo.DeleteAsync<Comment>(commentId);
            await repo.SaveChangesAsync();
            return articleId;


        }

      

        public Task<IEnumerable<PostModel>> GetAllPosts()
        {
            throw new NotImplementedException();
        }
    }
}
