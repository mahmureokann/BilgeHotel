using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class ReservationInfo:BaseEntity
    {

        public int ReservationInfoId { get; set; }

        public DateTime RezBaslangic { get; set; }

        public DateTime RezBitis { get; set; }

        private int _gunSayisi;
        public int GunSayisi
        {
            get
            {
                _gunSayisi = RezBitis.Day - RezBaslangic.Day;
                return _gunSayisi;
            }


            set
            {
                _gunSayisi = value;
            } 
        
        }
        private DateTime _rezTarihi;
        public DateTime RezervasyonTarihi
        {
            get
            {
                _rezTarihi = DateTime.Now;
                return _rezTarihi;

            }

            set
            {

                 _rezTarihi = value;
            }
        }//rezervasyonun olusturuldugu gün olan tarih

        
       
        

        public int CustomerId { get; set; }

        private decimal _toplamFiyat;

        public decimal ToplamFiyat //OOP prensiplerinden Encapsulation kullanıldı. Sebebi ise toplam fiyatı getirmek
        {
            get
            {
                _toplamFiyat = (RoomType.Fiyat +HolidayPackage.Fiyat) * GunSayisi;

                return _toplamFiyat;

            }

            set { _toplamFiyat = value; }




        }
        //Bir rezin kaç adet tatil paketi olur?  Bir tane olur
        public int HolidayPackageId { get; set; }
        public HolidayPackage HolidayPackage { get; set; }

        //Bir rezin kaç adet oda tipi olur? Bir
        
        public RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }

        //REzervasyon bilgisin müşterisi olur? Bir tane olur

        public Customer Customer { get; set; }




    }
}
