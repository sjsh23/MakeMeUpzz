using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MakeMeUpzz.Model;

namespace MakeMeUpzz.Factory
{
    public class CartFactory
    {
        public Cart createCart(int id, int userid, int makeupid, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = id;
            cart.UserID = userid;
            cart.MakeupID = makeupid;
            cart.Quantity = quantity;

            return cart;
        }
    }
}