using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int Userid, int stationeryId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserId = Userid;
            cart.StationeryId = stationeryId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}