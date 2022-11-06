using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.CategoryConstants;
namespace BabyKat.Infrastructure.Data
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>();
            Articles = new List<Article>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<Product> Products { get; set; } 

        public ICollection<Article> Articles { get; set; } 
    }
}
