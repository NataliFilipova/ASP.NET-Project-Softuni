using BabyKat.Core.Models.Commentt;
using BabyKat.Core.Models.Postt;
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

        Task<int> DeleteComment(int commentId);

        Task<IEnumerable<PostModel>> GetAllPosts();
    }
}
