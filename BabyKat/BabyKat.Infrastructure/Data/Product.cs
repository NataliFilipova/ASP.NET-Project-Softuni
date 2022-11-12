using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.ProductConstants;

namespace BabyKat.Infrastructure.Data
{
    public class Product
    {
        public Product()
        {
            Posts = new List<Post>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [Required]
        public Category Category { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        public ICollection<Post> Posts;

        [Required]
        [Precision(18, 2)]
        public decimal Rating { get; set; }
    }
}
