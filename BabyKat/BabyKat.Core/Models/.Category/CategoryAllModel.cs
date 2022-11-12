using BabyKat.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;
using static BabyKat.Infrastructure.GlobalConstants.CategoryConstants;
namespace BabyKat.Core.Models.Categoryy
{
    public class CategoryAllModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public string ImageUrl { get; set; } = null!;
    }
}
