using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCA.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "نام‌کاربری")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare(otherProperty: nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}