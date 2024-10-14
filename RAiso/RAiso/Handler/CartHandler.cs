using RAiso.Factory;
using RAiso.Models;
using RAiso.Modules;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handler
{
    public class CartHandler
    {
        public static Response<Cart> InsertCart(int id, int stationeryId, int quantity)
        {
            CartRepository.insertCart(id, stationeryId, quantity);
            Cart cart = CartFactory.CreateCart(id, stationeryId, quantity);
            return new Response<Cart> { isSuccess = true, Data = cart, Message = "Success" };
        }

        public static List<Cart> GetCartById(int UserId)
        {
            return CartRepository.GetCartById(UserId);
        }

        public static void UpdateCart(int id, int quantity)
        {
            CartRepository.updateCart(id, quantity);
        }

        public static void DeleteCart(int id)
        {
            Cart cart = CartRepository.SelectCart(id);
            if (cart == null)
            {
                return;
            }
            CartRepository.DeleteCart(id);
            
        }

        public static Response<List<Cart>> GetCartByUserId(int id)
        {
            List<Cart> c = CartRepository.GetCartByUserId(id);
            if(c.Count == 0)
            {
                return new Response<List<Cart>> { isSuccess = false, Data = null, Message = "Cart is empty" };
            }
            return new Response<List<Cart>> { isSuccess = true, Data = c, Message = "Success" };
        }

        public static Response<List<Cart>> RemoveCartById(List<int> id)
        {
            foreach (int i in id)
            {
                CartRepository.RemoveCartById(i);
            }
            return new Response<List<Cart>> { isSuccess = true, Data = null, Message = "Success" };
        }

        public static List<Cart> GetAllCart()
        {
            return CartRepository.GetAllCart();
        }

        public static bool RemoveCart(int Cart)
        {
            return CartRepository.RemoveCart(Cart);
        }
    }
}