using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class RezervasyonVM
    {
        [Required(ErrorMessage = "Rezervasyon giriş tarihi giriniz")]
        public string RezBaslangic { get; set; }
        [Required(ErrorMessage = "Rezervasyon bitiş tarihi giriniz")]
        public string RezBitis { get; set; }

        
    }
}