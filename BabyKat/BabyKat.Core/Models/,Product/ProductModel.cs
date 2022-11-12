using BabyKat.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;


namespace BabyKat.Core.Models.Productt
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "15000.0", ConvertValueInInvariantCulture = true)] //Put the constants instead. 
        public decimal Price { get; set; }

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

    }
}
