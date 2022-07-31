using DataAccses.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Entity
{
    public class Employee : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Title Title { get; set; } //Enum Title listelemede kullanılacak
       
        public string Pozisyon { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }

        


        //public int GunSayisi { get; set; } // ? Boş geçilip geçilemeyeceği ilie ilgili bir durum.
        public decimal Ucret { get; set; } //Yalnızca yöneticiler için
        public decimal SaatlikUcret { get; set; }

        
        public int VardiyaSuresi { get; set; }
        private decimal _maas { get; set; }
        public decimal Maas
        {
            get

            {

                switch (Title)
                {
                    case Title.resepsiyon_gorevlisi: // Confifuration'da kayıtlar yapıldı
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.temizlik_gorevlisi://
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.ascı://
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.elektrikci: //
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.garson://
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.bilgi_islem://
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    case Title.Yonetici: //
                        _maas = Ucret;
                        break;

                    case Title.resepsiyon_sefi: //
                        _maas = Ucret;
                        break;
                    case Title.IT_sorumlusu: //
                        _maas = SaatlikUcret * VardiyaSuresi;
                        break;
                    default:
                        break;

                }
                return _maas;


            }


            set { _maas = value; }
        }

        //Bir çalışanın kaç vardiyası olur? Bir
        public int? VardiyaId { get; set; }
        public Vardiya Vardiya { get; set; }

        

    }






}
