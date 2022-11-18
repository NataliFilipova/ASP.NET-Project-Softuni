using BabyKat.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;
using static BabyKat.Infrastructure.GlobalConstants.ProductConstants;

namespace BabyKat.Core.Models.Productt
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Description { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        //[Required]
        //[Range(typeof(decimal), "0.0", "15000.0", ConvertValueInInvariantCulture = true)] //Put the constants instead. 

        [Required]
        [Display(Name = "Price per month")]
        [Range(0.00, PriceMax, ErrorMessage = "Price per month must be a positive number and less than {2} leva")]
        public decimal Price { get; set; }

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

    }
}
