using BabyKat.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BabyKat.Infrastructure.GlobalConstants.ArticleConstants;

namespace BabyKat.Core.Models.Articlesss
{
    public class ArticleModel
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]

        public string Description { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        [Required]
        public User User { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
      
        public string ImageUrl { get; set; } = null!;

      //  public Product Product { get; set; } 

       
    }
}
