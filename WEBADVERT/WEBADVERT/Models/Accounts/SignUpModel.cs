using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBADVERT.Models.Accounts
{
    public class SignUpModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string emailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(6, ErrorMessage ="Password must contains atleast 6 characters")]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Doesnt matched with password")]
        public string confirmPassword { get; set; }
    }
}
