using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class ReservationMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ReservationInfo>
    {
        public ReservationMap()
        {
            ToTable("dbo.ReservationInfos");
            Property(x => x.ReservationInfoId).IsRequired();
            Property(x => x.RezervasyonTarihi).IsRequired();
            Property(x => x.RezBaslangic).IsRequired();
            Property(x => x.RezBitis).IsRequired();
            Property(x => x.GunSayisi).IsOptional();
            Property(x => x.ToplamFiyat).IsRequired();




        }
    }
}
