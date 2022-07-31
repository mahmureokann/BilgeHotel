using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class EmployeeMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("dbo.Employees");
            Property(x => x.EmployeeId).IsRequired();
            Property(x => x.Firstname).HasMaxLength(50).IsRequired();
            Property(x => x.Lastname).HasMaxLength(50).IsRequired();
            //Property(x => x.Title).IsRequired();
            Property(x => x.Pozisyon).HasMaxLength(50).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Password).IsRequired().HasMaxLength(20);
            Property(x => x.VardiyaSuresi).IsOptional();
            Property(x => x.KullaniciAdi).IsRequired();


            Property(x => x.Ucret).IsOptional();
            Property(x => x.SaatlikUcret).IsOptional();
            Property(x => x.Maas).IsOptional();




        }


    }
}
