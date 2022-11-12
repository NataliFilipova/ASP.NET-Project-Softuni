using BabyKat.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.PostConstants;

namespace BabyKat.Core.Models.Postt
{
    public class PostModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        [Required]
        public User User { get; set; } = null!;

        [Required]
        [Precision(18, 2)]

        public decimal Rating { get; set; }

        public int ProductId { get; set; }


        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public Product Product { get; set; } = null!;
    }
}
