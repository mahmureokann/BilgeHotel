using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CartVM 
    {

        Dictionary<int, CartItemVM> _myCart = new Dictionary<int, CartItemVM>();

        public List<CartItemVM> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddRoom(CartItemVM cartItem)
        {
            if (_myCart.ContainsKey(cartItem.ID)) //Eger eklenen urunun ID'sini iceriyorsa, adeti artir.
            {
                _myCart[cartItem.ID].GunSayisi = cartItem.GunSayisi;
                return;
            }
            _myCart.Add(cartItem.ID, cartItem); //odayi ekle
        }

        public void AddPackage(CartItemVM cartItem)
        {
            _myCart.Add(cartItem.HolidayPackageId, cartItem); //Tatil paketini ekle
        }

        public void AddDate(CartItemVM cartItem)
        {
            _myCart.Add(cartItem.RezBaslangic.Day, cartItem); //Baslangic ekle
            _myCart.Add(cartItem.RezBitis.Day, cartItem); //Bitis ekle
        }

    }
}