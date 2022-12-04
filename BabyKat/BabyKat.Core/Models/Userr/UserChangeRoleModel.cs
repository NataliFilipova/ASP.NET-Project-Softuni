using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Core.Models.Userr
{
    public class UserChangeRoleModel
    {
        public string Id { get; init; }

        public string UserName { get; init; }
        public string[] roles { get; set; } 
    }
}
