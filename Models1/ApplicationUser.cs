using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name" )]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
