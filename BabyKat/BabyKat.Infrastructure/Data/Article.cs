using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.ArticleConstants;

namespace BabyKat.Infrastructure.Data
{
    public class Article
    {
        public Article()
        {
           Comments = new List<Comment>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;


        public string ImgUrl { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        

        //public int? ProductId { get; set; }
        //[ForeignKey(nameof(ProductId))]
        //public Product Product { get; set; } 

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
