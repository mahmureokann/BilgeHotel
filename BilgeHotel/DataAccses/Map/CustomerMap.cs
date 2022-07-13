using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Map
{
    public class CustomerMap: System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("dbo.Customers");
            Property(x => x.CustomerId).IsRequired();
            Property(x => x.Firstname).IsRequired().HasMaxLength(50);
            Property(x => x.Lastname).IsRequired().HasMaxLength(50);
            Property(x => x.Tckn).IsRequired();
            Property(x => x.Email).IsRequired().HasMaxLength(100);
            Property(x => x.Password).IsRequired().HasMaxLength(20);
            Property(x => x.PhoneNumber).IsRequired().HasMaxLength(20);


        }
    }
}
