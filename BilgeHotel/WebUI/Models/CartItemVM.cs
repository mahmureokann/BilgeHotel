using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CartItemVM
    {
        public CartItemVM()
        {
            OdaSayisi = 1;
        }

        //bir alisveris sepetinin ....si olur
        public int ID { get; set; }
        public string RoomType { get; set; }
        public decimal? RoomTypePrice { get; set; }
        public string HolidayPackage { get; set; }
        public int HolidayPackageId { get; set; }
        public decimal? HolidayPackagePrice { get; set; }
        public int? OdaSayisi { get; set; }
        
        public decimal? Price { get; set; } //veritabanindan gelen price bos gecilebilir oldugundan dolayi buradaki price ve subtotal alanlarini da bos gecilebilir yapmamiz gerekti.

        //subtotal kendi adet ve fiyat bilgileriyle calisacaktir. Dısaridan bir ayarlamaya yapilmayacak. Readonly olacak. Bu nedenle set'i siliyoruz.
        public decimal? SubTotal
        {
            get
            {
                return OdaSayisi*(HolidayPackagePrice + RoomTypePrice);
            }
        }
    }
}