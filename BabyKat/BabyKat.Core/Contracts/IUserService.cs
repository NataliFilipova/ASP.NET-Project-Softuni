using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Productt;
using BabyKat.Core.Models.Userr;
using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<AllUsers> > GetAllUsers () ;
        Task<User> GetUserById(string userId);

        Task<int> AddProductToFavouriteAsync(int productId, string userId);

        Task <IEnumerable<ProductModel>> GetUserFavouriteProducts(string userId);

        Task RemoveProductFromFavouriteAsync(int productId, string userId);
        
    }
}
