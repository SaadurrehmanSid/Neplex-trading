using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neplex_trading.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        [Remote(controller:"Account",action:"UniqueEmail")]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "User Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Phone Number")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="characters are not allowed")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Paswword mismatch!")]
        public string ConfirmPassword { get; set; }
    }
}
