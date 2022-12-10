using BabyKat.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Test.Mocks
{
    public class DatabaseMock
    {
        public static ApplicationDbContext Instance

        {
            get
            {
                DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder =
                            new DbContextOptionsBuilder<ApplicationDbContext>();

                optionsBuilder.UseInMemoryDatabase($"BabyKat-TestDb-{DateTime.Now.Ticks}");

                return new ApplicationDbContext(optionsBuilder.Options, false);
            }
        }

    }
}
