using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class Cart
    {
        Dictionary<int, CartItemVM> _myCart = new Dictionary<int, CartItemVM>();

        public List<CartItemVM> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddItem(CartItemVM cartItem)
        {
            if (_myCart.ContainsKey(cartItem.ID)) //Eger eklenen urunun ID'sini iceriyorsa, adeti artir.
            {
                _myCart[cartItem.ID].OdaSayisi += cartItem.OdaSayisi;
                return;
            }
            _myCart.Add(cartItem.ID, cartItem); //Eger eklenen urunun ID'sini icermiyorsa, urunu ekle
        }
    }
}