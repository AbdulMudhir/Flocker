using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flocker.Models
{
    public class CustomUserIdentity:IdentityUser
    {
        public string Avatar { get; set; }

    }
}
