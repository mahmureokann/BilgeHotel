using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class Customer:BaseEntity
    {
        public int CustomerId { get; set; }
        public string Tckn { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       

        //Bir müşterinin kaç rezervasyon bilgisi olur? Bir fazla olur
        public List<ReservationInfo> reservationInfos { get; set; }


    }
}
