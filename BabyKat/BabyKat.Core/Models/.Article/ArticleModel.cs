using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.ArticleConstants;

namespace BabyKat.Core.Models.Articlesss
{
    public class ArticleModel
    {
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
