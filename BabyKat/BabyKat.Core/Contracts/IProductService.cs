using BabyKat.Core.Models._Product;
using BabyKat.Core.Models.Categoryy;
using BabyKat.Core.Models.Productt;
using BabyKat.Infrastructure.Data;

namespace BabyKat.Core.Contracts
{
    public interface IProductService
    {
         Task<IEnumerable<ProductRatingModel>> GetAllAsync();
         Task< IEnumerable<ProductHomeModel>> LastThreeProducts();

       Task<IEnumerable<Category>> GetCategoriesAsync();
       Task AddProductAsync(ProductModel model);
        Task<IEnumerable<ProductRatingModel>> GetProductsForCategoryAsync(int categoryId);
        Task RemoveProductFromCategory(int productId);

        Task<ProductRatingModel> GetProduct(int productId);

        Task EditProduct(int productId, ProductModel model);
    }
}
