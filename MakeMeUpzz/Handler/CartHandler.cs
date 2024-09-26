using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace MakeMeUpzz.Handler
{
    public class CartHandler
    {
        public static List<Cart> GetCartsbyUserID(int id)
        {
            CartRepository repo = new CartRepository();
            return repo.GetCartByUserID(id);
        }

        public static string insertCart(int userid, int makeupid, int quantity)
        {
            CartRepository repo = new CartRepository();
            Cart cart = repo.GetCartByUserAndMakeupID(userid, makeupid);
            if ( cart != null)
            {
                repo.updateCartQuantity(cart.CartID, quantity);
            }
            else
            {
                repo.insertCart(repo.AutomateID(), userid, makeupid, quantity); 
            }
            return "success";
        }

        public static string deleteAllCartByUserID(int id)
        {
            CartRepository repo = new CartRepository();
            repo.DeleteCartByUserID(id);
            return "cart cleared";
        }


    }
}