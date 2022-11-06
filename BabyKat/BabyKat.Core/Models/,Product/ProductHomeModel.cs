using BabyKat.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Models.Productt
{
    public class ProductHomeModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public Category Category { get; set; } = null;
    }
}
