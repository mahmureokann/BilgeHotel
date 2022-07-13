using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class RoomTypeMap: System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RoomType>
    {
        public RoomTypeMap()
        {
            ToTable("dbo.RoomTypes");
            Property(x => x.RoomTypeId).IsRequired();
            Property(x => x.OdaTipi).IsRequired();
            Property(x => x.OdaTuru).IsRequired();
           


        }
    }
}
