using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class AppUserVM
    {
        [Required(ErrorMessage = "TCKN giriniz")]
        public string Tckn { get; set; }
        [Required(ErrorMessage = "İsim giriniz!")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Soyad giriniz!")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Telefon numarası giriniz!")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Email giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Sifreler ayni degil!")]
        public string ConfirmPassword { get; set; }

    }
}