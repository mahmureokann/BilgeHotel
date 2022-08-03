using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class AppUserVM
    {
        [Required(ErrorMessage = "Geçerli bir E-Mail giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Sifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Sifreler ayni degil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email giriniz!")]
        public string Email { get; set; }
    }
}