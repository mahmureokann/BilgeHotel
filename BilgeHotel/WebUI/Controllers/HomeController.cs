using BLL.Concrete;
using DataAccses.Context;
using DataAccses.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();

        CustomerService cs = new CustomerService();

        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Register işlemleri

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {

                Customer customer = new Customer();

                customer.Email = appUserVM.Email;
                customer.Password = appUserVM.Password;
                customer.Firstname = appUserVM.Firstname;
                customer.Lastname = appUserVM.Lastname;
                customer.PhoneNumber = appUserVM.Tel;

                customer.Tckn = appUserVM.Tckn;


                var result = cs.Create(customer);



                TempData["info"] = result;



                return RedirectToAction("Login");

            }
            else
            {
                return View(appUserVM);
            }
        }

        ////Login işlemleri
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUserVm loginUserVm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (db.Customers.Any(x => x.Email == loginUserVm.Email && x.Password == loginUserVm.Password))
                    {
                        Customer user = db.Customers.Where(x => x.Email == loginUserVm.Email && x.Password == loginUserVm.Password).FirstOrDefault();

                        Session["scart"] = user;
                        return RedirectToAction("Index");
                    }

                    else
                    {
                        TempData["error"] = "E-mail veya şifre hatalı! Eğer kayıtlı değilseniz lütfen Kayıt Ol butonuna basınız!";
                        return View(loginUserVm);


                    }

                }
                catch (Exception)
                {
                    return View();
                }
            }
            else
            {
                return View(loginUserVm);
            }
        }

        //Kart ekleme işlemleri
        public ActionResult AddToCart(int id)
        {
            try
            {
                HolidayPackage holiday = new HolidayPackage();

                RoomType room = db.RoomTypes.Find(id);


                CartVM c = null;

                if (Session["scart"] == null) //oturum acilmamissa scart isimli bir session olustur.
                {
                    c = new CartVM();

                }
                else //scart isimli bir session varsa, var olan oturumu kullan
                {
                    c = Session["scart"] as CartVM; //scart isimli session'i cart olarak unboxing yap ve icerisine at.                   
                }

                //veya ternary if ile asagidaki sekilde de yazilabilir:

                //Card c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;

                CartItemVM ci = new CartItemVM();
                ci.ID = room.RoomTypeId;
                ci.Price = room.Fiyat; //Bos gecilebilir bir degere bos gecilemez bir deger aktarilamaz. bu nedenle property'ler duzeltilir.
                ci.RoomType = room.OdaTipi;
                ci.HolidayPackagePrice = holiday.Fiyat;
                ci.HolidayPackage = holiday.PaketAdi;
                c.AddPackage(ci); //oturum icerisindeki karta kart item'larini ekle.
                Session["scart"] = c;

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["error"] = $"{id} karsilik gelen bir oda bulunamadi!";
                return View();
            }

        }

        //Paket ekleme
        public ActionResult AddPackageToCart(int id)
        {
            try
            {
                HolidayPackage tatilPaketi = db.HolidayPackages.Find(id);
                ReservationInfo rezervasyon = new ReservationInfo();
                RoomType oda = db.RoomTypes.Find(id);


                CartVM c = null;

                if (Session["scart"] == null) //oturum acilmamissa scart isimli bir session olustur.
                {
                    c = new CartVM();

                }
                else //scart isimli bir session varsa, var olan oturumu kullan
                {
                    c = Session["scart"] as CartVM; //scart isimli session'i cartVM olarak unboxing yap ve icerisine at.
                }


                CartItemVM ci = new CartItemVM();

                ci.HolidayPackage = tatilPaketi.PaketAdi;
                ci.HolidayPackageId = tatilPaketi.HolidayPackageId;
                ci.HolidayPackagePrice = tatilPaketi.Fiyat;
                c.AddRoom(ci);
                Session["scart"] = c;

                return RedirectToAction("HolidayPackages");
            }
            catch (Exception)
            {
                return View();
            }
        }

        //kart işlemleri
        public ActionResult MyCart()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "Lütfen tüm alanları doldurunuz!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult CompleteCart()
        {
            CartVM cart = Session["scart"] as CartVM;
            foreach (var item in cart.myCart)
            {
                RoomType room = db.RoomTypes.Find(item.ID);
                room.OdaSayisi -= item.OdaSayisi;
                db.Entry(room).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                Session.Remove("scart"); //scard isimli session'i bosalt.
            }
            return View();
        }
        //Odalar
        public ActionResult Rooms()
        {
            TempData["odalar"] = db.RoomTypes.OrderBy(x => x.RoomTypeId).ToList();

            TempData.Keep();

            return View();
        }
        //Tatil paketleri
        public ActionResult HolidayPackage()
        {
            TempData["tatilPaketleri"] = db.HolidayPackages.OrderBy(x => x.HolidayPackageId).ToList();

            TempData.Keep();

            return View();
        }
        public ActionResult Rezervasyon()
        {
            return View();
        }
        
       
        

    }
    
}
