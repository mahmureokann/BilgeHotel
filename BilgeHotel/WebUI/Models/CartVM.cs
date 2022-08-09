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
            _myCart.Add(cartItem.ID, cartItem); //Eger eklenen urunun ID'sini icermiyorsa, urunu ekle
        }

        public void AddPackage(CartItemVM cartItem)
        {
            //if (_myCart.ContainsKey(cartItem.TatilPaketID))
            //{
            //    _myCart[cartItem.TatilPaketID].GunSayisi += cartItem.GunSayisi;
            //    return;
            //}
            _myCart.Add(cartItem.HolidayPackageId, cartItem); //Eger eklenen urunun ID'sini icermiyorsa, urunu ekle
        }
    }
}