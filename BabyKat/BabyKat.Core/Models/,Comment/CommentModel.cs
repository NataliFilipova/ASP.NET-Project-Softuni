using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.CommentConstants;

namespace BabyKat.Core.Models.Commentt
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ArticleId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Author { get; set; } = null!;
    }
}
