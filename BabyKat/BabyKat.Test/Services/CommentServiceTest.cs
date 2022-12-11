using BabyKat.Core.Contracts;
using BabyKat.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    public class CommentServiceTest :UnitTestBase
    {
        private ICommentService commentService;

        [SetUp]

        public void SetUp()
        {
            this.commentService = new CommentService(this.repo);
        }

    }

    
}
