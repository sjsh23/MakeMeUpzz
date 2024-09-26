using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class CartRepository
    {
        Database1Entities db = DatabaseSingleton.getinstance();
        CartFactory factory = new CartFactory();

        public int AutomateID()
        {
            if (GetCarts().Count == 0)
            {
                return 1;
            }
            else
            {
                return GetLastCart().CartID + 1;
            }

        }

        public List<Cart> GetCarts()
        {
            return (from c in db.Carts select c).ToList();
        }

        public Cart GetLastCart()
        {
            return GetCarts().LastOrDefault();
        }

        public Cart GetCartByID(int id)
        {
            return (from c in db.Carts where c.CartID == id select c).FirstOrDefault();
        }

        public List<Cart> GetCartByUserID(int id)
        {
            return (from c in db.Carts where c.UserID == id select c).ToList();
        }

        public Cart GetCartByUserAndMakeupID(int userid, int makeupid)
        {
            return (from c in db.Carts where c.MakeupID == makeupid && c.UserID == userid  select c).FirstOrDefault();
        }

        public void insertCart(int id, int userid, int makeupid, int quantity)
        {
            Cart cart = factory.createCart(id, userid, makeupid, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void updateCartQuantity(int id, int quantity)
        {
            Cart update = db.Carts.Find(id);
            update.Quantity += quantity;
            db.SaveChanges();
        }

        public void RemoveCartByID(int id)
        {
            Cart del = GetCartByID(id);
            db.Carts.Remove(del);
            db.SaveChanges();
        }

        public void DeleteCartByUserID(int id)
        {
            List<Cart> del = GetCartByUserID(id);
            db.Carts.RemoveRange(del);
            db.SaveChanges();
        }

    }
}