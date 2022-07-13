using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class HolidayMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<HolidayPackage>
    {
        public HolidayMap()
        {
            ToTable("dbo.HolidayPackages");
            Property(x => x.HolidayPackageId).IsRequired();
            //Property(x => x.RoomTypeId).IsRequired();
            Property(x => x.Fiyat).IsRequired();
            


        }
    }
}
