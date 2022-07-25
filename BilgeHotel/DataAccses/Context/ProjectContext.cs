using DataAccses.Entity;
using DataAccses.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-S4HM3GR\\SQLEXPRESS;database=BilgeHotelDB;Trusted_Connection=true";
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HolidayPackage> HolidayPackages { get; set; }
        public DbSet<ReservationInfo> ReservationInfos { get; set; }
       
        public DbSet<RoomType> RoomTypes { get; set; }
      
  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
        
            modelBuilder.Configurations.Add(new RoomTypeMap());
            modelBuilder.Configurations.Add(new HolidayMap()); //class'taki constructor'in calismasi icin new yazarak instance aldik.
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new VardiyaMap());
           
            
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
