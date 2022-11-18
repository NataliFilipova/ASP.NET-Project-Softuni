using BabyKat.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.ProductConstants;
namespace BabyKat.Core.Models._Product
{
    public class ProductRatingModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
       
        public decimal Price { get; set; }
      
        public string Description { get; set; } = null!;
       
        public int CategoryId { get; set; }
      
        public string ImageUrl { get; set; } = null!;

        public ICollection<Post> Posts = new List<Post>();
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public string CategoryName { get; set; } = null!;

        public decimal Rating { get; set; }
    }
}
