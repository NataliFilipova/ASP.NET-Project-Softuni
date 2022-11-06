using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.PostConstants;

namespace BabyKat.Infrastructure.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        
        public User User { get; set; } = null!;

        [Required]
        [Precision(18, 2)]

        public decimal Rating { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]

        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        
        public Product Product { get; set; } = null!;
    }
}
