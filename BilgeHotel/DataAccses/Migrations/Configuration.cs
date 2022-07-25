namespace DataAccses.Migrations
{
    using DataAccses.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;
    

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccses.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccses.Context.ProjectContext context)
        {

            //Çalışanlar

            List<Employee> employees = new List<Employee>()
            {
                new Employee{Firstname="Selahattin",Lastname="Alkomut",Email="selahattin.alkomut@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.Yonetici,Ucret=30000,Pozisyon="Title bakınız"},
                new Employee{Firstname="Levent",Lastname="Sişarpsoy",Email="levent.sisarp@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.Yonetici,Ucret=30000,Pozisyon="Title bakınız"},
                new Employee{Firstname="Gülay",Lastname="Aydınlık",Email="gulay.aydinlik@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.resepsiyon_sefi,Ucret=20000,Pozisyon="Title bakınız"},
                new Employee{Firstname="Selahattin",Lastname="Karadibag",Email="selahattin.karadibak@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.IT_sorumlusu,SaatlikUcret=300,VardiyaSuresi=80,Pozisyon="Title bakınız"},
                new Employee{Firstname="Bahattin",Lastname="Karanlık",Email="bahattin.karanlik@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.resepsiyon_gorevlisi,SaatlikUcret=30,VardiyaSuresi=192, Pozisyon = "Title bakınız"},
                new Employee{Firstname="Ayşe",Lastname="Akıncı",Email="ayse.akinci@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.ascı,SaatlikUcret=50,VardiyaSuresi=192, Pozisyon = "Title bakınız"},
                new Employee{Firstname="Feyzullah",Lastname="Alşarp",Email="feyzullah.alsarp@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.elektrikci,SaatlikUcret=50,VardiyaSuresi=10, Pozisyon = "Title bakınız"},
                new Employee{Firstname="Kader",Lastname="Kısmet",Email="kader.kismet@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.garson,SaatlikUcret=50,VardiyaSuresi=192, Pozisyon = "Title bakınız"},
                new Employee{Firstname="Bilge",Lastname="Akserver",Email="bilge.akserver@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.bilgi_islem,SaatlikUcret=100,VardiyaSuresi=160, Pozisyon = "Title bakınız" },
                new Employee{Firstname="Mesut",Lastname="Bahtiyar",Email="mesut.bahtiyar@bilgehotel.com",Password="123",Title=DataAccses.Enums.Title.temizlik_gorevlisi,SaatlikUcret=50,VardiyaSuresi=192, Pozisyon = "Title bakınız"},

            };
            if (!context.Employees.Any()) //herhangi bir employee yoksa
            {
                foreach (var employee1 in employees)
                {
                    context.Employees.Add(employee1);
                    context.SaveChanges();
                }
            }

            //customer
            List<Customer> customer = new List<Customer>()
             {
                 new Customer{Firstname="Faik",Lastname="Server",Email="faik.server@bilgehotel.com",Password="123",Tckn="11111111111",PhoneNumber="22222222222"},
                 new Customer{Firstname="Muzaffer",Lastname="Bagdakalmış",Email="muzaffer.bagdakalmis@bilgehotel.com",Password="123",Tckn="11111111111",PhoneNumber="22222222222"},
                 new Customer{Firstname="Melek",Lastname="Yıkılmış",Email="melek.yikilmis@bilgehotel.com",Password="123",Tckn="11111111111",PhoneNumber="22222222222"},
                 new Customer{Firstname="Deniz",Lastname="Körşarp",Email="deniz.korsarp@bilgehotel.com",Password="123",Tckn="11111111111",PhoneNumber="22222222222"},


             };
            if (!context.Customers.Any()) //herhangi bir müşteri yoksa
            {
                foreach (var customer1 in customer)
                {
                    context.Customers.Add(customer1);
                    context.SaveChanges();
                }
            }

            //Oda Tipleri
            List<RoomType> roomTypes = new List<RoomType>()
             {
                 new RoomType { OdaTipi="Tam pansiyon", OdaTuru="Üç kişilik",Fiyat=5000},
                 new RoomType { OdaTipi="Her şey dahil", OdaTuru="Dört kişilik",Fiyat=15000 },
                 new RoomType { OdaTipi="Tam pansiyon", OdaTuru="Tek kişilik",Fiyat=2000 },
                 new RoomType { OdaTipi="Her şey dahil", OdaTuru="Kral dairesi",Fiyat=20000 },
             };

            if (!context.RoomTypes.Any())//herhangi bir oda tipi yoksa
            {
                foreach (var roomType in roomTypes)
                {
                    context.RoomTypes.Add(roomType);
                    context.SaveChanges();
                }
            }

            //HolidayPackage
            List<HolidayPackage> holidayPackages = new List<HolidayPackage>()
             {
                 new HolidayPackage { HolidayPackageId=1 , Fiyat=1500 },
                 new HolidayPackage {HolidayPackageId =2,Fiyat=8000 },
                 new HolidayPackage {HolidayPackageId=3 ,Fiyat=11000 },
                 new HolidayPackage { HolidayPackageId=4, Fiyat=7000 },
             };

            if (!context.HolidayPackages.Any())//herhangi bir tatil paketi yoksa
            {
                foreach (var holidayPackage in holidayPackages)
                {
                    context.HolidayPackages.Add(holidayPackage);
                    context.SaveChanges();
                }
            }

            
            //Rezervasyon

            DateTime dt1 = new DateTime(2020,06,14);
            DateTime dt2 = new DateTime(2020,06,21);

            List<ReservationInfo> reservationInfos = new List<ReservationInfo>()
            {
                new ReservationInfo{RezBaslangic=dt1,RezBitis=dt2,HolidayPackageId=1,CustomerId=1,RoomTypeId=1},
                new ReservationInfo{RezBaslangic=dt1,RezBitis=dt2,RezervasyonTarihi=DateTime.Now,HolidayPackageId=2,CustomerId=2,RoomTypeId=2}
               
            };

            if (!context.ReservationInfos.Any())
            {
                foreach (var rez in reservationInfos)
                {
                    context.ReservationInfos.Add(rez);
                    context.SaveChanges();
                }
            }


            DateTime dtVardiya = new DateTime(2020, 06, 23);
            DateTime dtVardiya2 = new DateTime(2020, 06, 24);
            //Vardiya
            List<Vardiya> vardiyas = new List<Vardiya>()
             {
                 new Vardiya { VardiyaBaslangic=DateTime.Now,VardiyaBitis=DateTime.Now},
                 new Vardiya { VardiyaBaslangic=DateTime.Now,VardiyaBitis=DateTime.Now},
                 new Vardiya { VardiyaBaslangic=DateTime.Now,VardiyaBitis=DateTime.Now},
                 
             };

            



        }
    }
}
