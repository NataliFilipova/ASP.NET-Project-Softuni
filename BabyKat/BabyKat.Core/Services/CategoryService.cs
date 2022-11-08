using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Categoryy;
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
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repo;
        public CategoryService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<CategoryAllModel>> GetCategoriesAsync()
        {
            return await repo.AllReadonly<Category>()
                 .Select(p => new CategoryAllModel()
                 {
                     Id = p.Id,
                     Name = p.Name,
                    
                     Products = p.Products
                     
                 })
                  
                 .ToListAsync();
        }

       
    }
}
