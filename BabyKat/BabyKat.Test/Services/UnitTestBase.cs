using BabyKat.Infrastructure.Data;
using BabyKat.Infrastructure.Data.Repositories;
using BabyKat.Test.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Services
{
    public class UnitTestBase
    {
        protected ApplicationDbContext dbContext;
        protected IRepository repo;

        [OneTimeSetUp]
        public void Setup()
        {
            this.dbContext = DatabaseMock.Instance;
            this.repo = new Repository(this.dbContext);
        }
    }
}
