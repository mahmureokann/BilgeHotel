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
                CustomerService customerService = new CustomerService();
                Customer customer = new Customer();

                customer.Email = appUserVM.Email;
                customer.Password = appUserVM.Password;
                //var result = cs.Create(customer);
                
                var result = customerService.Create(customer);

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
        public ActionResult Login(AppUserVM appUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (db.Customers.Any(x => x.Email == appUser.Email && x.Password == appUser.Password))
                    {
                        Customer user = db.Customers.Where(x => x.Email == appUser.Email && x.Password == appUser.Password).FirstOrDefault();

                        Session["scart"] = user;
                        return RedirectToAction("MyCart");
                    }
                    else
                    {
                        TempData["error"] = "E-mail veya şifre hatalı!";
                        return View(appUser);
                    }
                }
                catch (Exception)
                {
                    return View();
                }
            }
            else
            {
                return View(appUser);
            }
        }

        //Kart ekleme işlemleri
        public ActionResult AddToCart(int id)
        {
            try
            {
                HolidayPackage holiday = new HolidayPackage();

                RoomType room = db.RoomTypes.Find(id);


                Cart c = null;

                if (Session["scart"] == null) //oturum acilmamissa scart isimli bir session olustur.
                {
                    c = new Cart();

                }
                else //scart isimli bir session varsa, var olan oturumu kullan
                {
                    c = Session["scart"] as Cart; //scart isimli session'i cart olarak unboxing yap ve icerisine at.                   
                }

                //veya ternary if ile asagidaki sekilde de yazilabilir:

                //Card c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;

                CartItemVM ci = new CartItemVM();
                ci.ID = room.RoomTypeId;
                ci.Price = room.Fiyat; //Bos gecilebilir bir degere bos gecilemez bir deger aktarilamaz. bu nedenle property'ler duzeltilir.
                ci.RoomType = room.OdaTipi;
                ci.HolidayPackagePrice = holiday.Fiyat;
                ci.HolidayPackage = holiday.PaketAdi;
                c.AddItem(ci); //oturum icerisindeki karta kart item'larini ekle.
                Session["scart"] = c;

                return RedirectToAction("MyCart");
            }
            catch (Exception)
            {
                TempData["error"] = $"{id} karsilik gelen bir oda bulunamadi!";
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
                TempData["error"] = "Herhangi bir oda seçimi yapınız!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult CompleteCart()
        {
            Cart cart = Session["scart"] as Cart;
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

    }
}