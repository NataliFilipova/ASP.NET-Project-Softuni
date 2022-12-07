using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BabyKat.Infrastructure.GlobalConstants.UserConstants;

namespace BabyKat.Infrastructure.Data
{
    public class User : IdentityUser
    {
        public User()
        {
            Posts = new List<Post>();
            Articles = new List<Article>();
          
        }
       
        [Required]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(CountryMaxLength)]
        public string Country { get; set; } = null!;


        public DateTime LastModifiedOn { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public List<Article> Articles { get; set; }
        public List<Post> Posts { get; set; } 

   
    }
}
