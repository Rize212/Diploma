using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _222.Models
{
    public class User : IdentityUser
    {
        public DateTime Year{ get; set; }
        

    }
}
