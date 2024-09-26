using MakeMeUpzz.Model;
using MakeMeUpzz.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Deployment.Internal;

namespace MakeMeUpzz.Controller
{
    public class CartController
    {
        public static List<Cart> GetCartsByUserID(int id)
        {
            return CartHandler.GetCartsbyUserID(id);
        }

        public static string insertCart(int userid, int makeupid, int quantity)
        {
            if (quantity <= 0)
            {
                return "quantity must be more than 0";
            }
            else
            {
                return CartHandler.insertCart(userid, makeupid, quantity);
            }

        }

        public static string deleteAllCartByUserID(int id, List<Cart> cart)
        {
            if (cart == null)
            {
                return "cart is empty";
            }
            else
            {
                return CartHandler.deleteAllCartByUserID(id);
            }
        }
    }
}