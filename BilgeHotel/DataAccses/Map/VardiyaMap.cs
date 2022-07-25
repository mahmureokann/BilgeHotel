using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class VardiyaMap: System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vardiya>
    {
        public VardiyaMap()
        {
            ToTable("dbo.Vardiyalar");
            Property(x => x.VardiyaId).IsRequired();
            Property(x => x.VardiyaBaslangic).IsRequired();
            Property(x => x.VardiyaBitis).IsRequired();
            




        }
    }
}
