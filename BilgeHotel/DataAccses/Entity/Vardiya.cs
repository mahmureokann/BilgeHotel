using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class Vardiya:BaseEntity
    {
        public int VardiyaId { get; set; }
        public DateTime VardiyaBaslangic { get; set; }
        public DateTime VardiyaBitis { get; set; }
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        

        //Bir vardiyanın kaç çalışanı olur? Çok
        public List<Employee> Employee { get; set; }
    }
}
