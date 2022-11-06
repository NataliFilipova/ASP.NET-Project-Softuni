using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.CommentConstants;

namespace BabyKat.Infrastructure.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(AuthorMaxLength)] 
        public string Author { get; set; } = null!;
    }
}
