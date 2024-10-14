using RAiso.Handler;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controller
{
    public class CartController
    {
        public static Response<Cart> InsertCart(int id, int stationeryId, int quantity)
        {
            Response<Cart> response = new Response<Cart>();
            if (quantity <= 0)
            {
                response.isSuccess = false;
                response.Message = "Quantity must be filled and must more than 0 !!";
                return response;
            }
            return CartHandler.InsertCart(id, stationeryId, quantity);
        }

        public static List<Cart> GetCartById(int UserId)
        {
            return CartHandler.GetCartById(UserId);
        }

        public static Response<Cart> UpdateCart(int id, int quantity)
        {
            Response<Cart> response = new Response<Cart>();
            if (quantity <= 0)
            {
                response.isSuccess = false;
                response.Message = "Quantity must be filled and must more than 0 !!";
                return response;
            }
            CartHandler.UpdateCart(id, quantity);
            response.isSuccess = true;
            response.Message = "Update Success";
            return response;
        }

        public static Response<List<Cart>> GetCardByUserId(int id)
        {
            return CartHandler.GetCartByUserId(id);
        }

        public static Response<List<Cart>> RemoveCartById(List<int> id)
        {
            return CartHandler.RemoveCartById(id);
        }

        public static List<Cart> GetAllCart()
        {
            return CartHandler.GetAllCart();
        }   

        public static bool RemoveCart(int cart)
        {
            return CartHandler.RemoveCart(cart);
        }
    }
}