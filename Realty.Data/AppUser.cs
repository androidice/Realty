using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Realty.Data
{
    public class AppUser : IdentityUser
    {
        public string PreferedLanguage { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
