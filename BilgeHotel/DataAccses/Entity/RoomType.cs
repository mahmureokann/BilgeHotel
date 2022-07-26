using DataAccses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class RoomType:BaseEntity
    {
        public int RoomTypeId { get; set; }

        public string OdaTipi { get; set; }
        public string OdaTuru { get; set; }
        public decimal Fiyat { get; set; }

        public OdaDurumu OdaDurumu { get; set; }

        //Bir oda tipinin kaç adet rezervasyonu olur? Birden fazla
        public List<ReservationInfo> reservationInfos { get; set; }
       

        //internal OdaDurumu OdaTuru { get; set; }
        
    }
}
