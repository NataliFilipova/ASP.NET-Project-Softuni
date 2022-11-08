using BabyKat.Core.Models.Comment;
using BabyKat.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Contracts
{
    public interface ICommentService
    {
        Task AddComment(CommentModel model);

        Task DeletePost(PostModel model);

        Task<IEnumerable<PostModel>> GetAllPosts();
    }
}
