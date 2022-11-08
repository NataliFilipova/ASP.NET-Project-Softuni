using BabyKat.Core.Models.Categoryy;
using BabyKat.Core.Models.Productt;
using BabyKat.Infrastructure.Data;

namespace BabyKat.Core.Contracts
{
    public interface IProductService
    {
         Task<IEnumerable<ProductModel>> GetAllAsync();
         Task< IEnumerable<ProductHomeModel>> LastThreeProducts();

       Task<IEnumerable<Category>> GetCategoriesAsync();
       Task AddProductAsync(ProductModel model);
        Task<IEnumerable<ProductModel>> GetProductsForCategoryAsync(int categoryId);
        Task RemoveProductFromCategory(int productId);

        Task<ProductModel> GetProduct(int productId);

        Task EditProduct(int productId, ProductModel model);
    }
}
