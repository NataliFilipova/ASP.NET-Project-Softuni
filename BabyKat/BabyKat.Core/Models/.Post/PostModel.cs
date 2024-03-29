﻿using BabyKat.Infrastructure.Data;
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
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "{0} lenght must be between {2} and {1} characters long!")]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Rating")]
        [Range(0.00, RatingMax, ErrorMessage = "Price per month must be a positive number and less than {2} leva")]

        public decimal Rating { get; set; }

        [Required]
        public string UserId { get; set; } = null!;


        [ForeignKey(nameof(UserId))]
        [Required]
        public User User { get; set; } = null!;


        public int ProductId { get; set; }


        [Required]
        public Product Product { get; set; } = null!;
    }
}
