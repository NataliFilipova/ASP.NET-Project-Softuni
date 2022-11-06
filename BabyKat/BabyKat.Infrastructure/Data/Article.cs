using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.ArticleConstants;

namespace BabyKat.Infrastructure.Data
{
    public class Article
    {
        Article()
        {
           Comments = new List<Comment>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
