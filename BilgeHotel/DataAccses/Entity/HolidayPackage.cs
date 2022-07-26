using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class HolidayPackage:BaseEntity
    {
        public int HolidayPackageId { get; set; }
        public string PaketAdi { get; set; }
        //public int RoomTypeId { get; set; }
        public decimal Fiyat { get; set; }

        //Bir tatil paketinin kaç adet oda tipi olur? Bir tane olur
        
        //public RoomType RoomType { get; set; }

        //Bir tatil paketinin kaç adet rezervasyonu olur?Birden fazla
  
        public List<ReservationInfo> reservationInfos { get; set; }

    }
}
