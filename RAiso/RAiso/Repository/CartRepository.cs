using RAiso.Factory;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RAiso.Repository
{
    public class CartRepository
    {
        private static Database1Entities db = new Database1Entities();

        public static List<Cart> GetAllCart()
        {
            return db.Carts.ToList();
        }

        public static Cart GetCartByID(int id)
        {
            return db.Carts.Find(id);
        }

        public static List<Cart> GetCartByUserId(int id)
        {
            return db.Carts.Where(x => x.UserId == id).ToList();
        }
        public static int GetCartId()
        {
            Cart cart = db.Carts.ToList().LastOrDefault();
            int id;
            if (cart == null)
            {
                id = 1;
            }
            else
            {
                id = cart.CartId + 1;
            }
            return id;
        }
        public static string insertCart(int id, int stationeryId, int quantity)
        {
           
            Cart cart = CartFactory.CreateCart(id, stationeryId, quantity);
            cart.CartId = GetCartId();
            db.Carts.Add(cart);
            db.SaveChanges();
            return "Success";
        }

        public static List<Cart> GetCartById(int UserId)
        {
            return db.Carts.Include(td => td.MsStationery)
                .Where(x => x.UserId == UserId)
                .ToList();
            
        }

        public static void updateCart(int id, int quantity)
        {
            Cart cart = db.Carts.Where(x => x.CartId == id).FirstOrDefault();
            cart.Quantity = quantity;
            db.SaveChanges();
        }

        public static Cart SelectCart(int id)
        {
            return db.Carts.Find(id);
        }

        public static void DeleteCart(int id)
        {
            Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public static int RemoveCartById(int id)
        {
            Cart c = GetCartByID(id);
            if (c != null)
            {
                db.Carts.Remove(c);
                db.SaveChanges();
            }
            return 0;
        }

        public static bool RemoveCart(int Cart)
        {
            var cart = db.Carts.Find(Cart);
            if (cart ==  null)
            {
                return false;
            }
            db.Carts.Remove(cart);
            return db.SaveChanges()>0;
        }
    }
}