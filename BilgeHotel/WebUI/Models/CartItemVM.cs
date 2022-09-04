using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CartItemVM : IDisposable
    {
        public CartItemVM() // proje açıldığı anda oda sayısı otomatik bir gelir.
        {
            OdaSayisi = 1;

            GunSayisi = RezBitis.Day - RezBaslangic.Day;
        }

        //bir alisveris sepetinin ....si olur
        public int ID { get; set; }
        public string RoomType { get; set; }
        public decimal? RoomTypePrice { get; set; }
        public string OdaTuru { get; set; }
        public string HolidayPackage { get; set; }
        public int HolidayPackageId { get; set; }
        public decimal? HolidayPackagePrice { get; set; }
        public int? OdaSayisi { get; set; } 
        public DateTime RezBaslangic { get; set; }
        public DateTime RezBitis { get; set; }
        public int GunSayisi { get; set; }

        public decimal? Price { get; set; } //veritabanindan gelen price bos gecilebilir oldugundan dolayi buradaki price ve subtotal alanlarini da bos gecilebilir yapmamiz gerekti.

        //subtotal kendi adet ve fiyat bilgileriyle calisacaktir. Dısaridan bir ayarlamaya yapilmayacak. Readonly olacak. Bu nedenle set'i siliyoruz.
        public decimal? SubTotal
        {
            get
            {
                return OdaSayisi*(HolidayPackagePrice + RoomTypePrice);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
            //https://docs.microsoft.com/tr-tr/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/shopping-cart bu linke bak
        }
    }
}