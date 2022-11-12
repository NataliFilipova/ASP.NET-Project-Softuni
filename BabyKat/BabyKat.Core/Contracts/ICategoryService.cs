using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabyKat.Core.Models.Categoryy;
using BabyKat.Core.Models.Productt;

namespace BabyKat.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryAllModel>> GetCategoriesAsync();

   
    }
}
