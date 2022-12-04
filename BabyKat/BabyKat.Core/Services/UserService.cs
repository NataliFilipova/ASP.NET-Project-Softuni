using BabyKat.Core.Contracts;
using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Userr;
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
  public class UserService: IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<AllUsers>> GetAllUsers()
        {
            return await repo.All<User>()
                 .Select(p => new AllUsers()
                 {
                     Id = p.Id,
                     UserName = p.UserName,
                     FirstName = p.FirstName,
                     LastName = p.LastName,
                     Email = p.Email,
                 }).ToListAsync();
        }

        public async Task<User> GetUserById(string userId)
        {
            return  await repo.GetByIdAsync<User>(userId);
            
        }
    }
}
