using RAiso.Handler;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controller
{
    public class TransactionHeaderController
    {
        public static bool AddTransaction(int UserID, DateTime now, List<Cart> cartList)
        {
            TransactionHeaderHandler.AddTransactionHeader(UserID, now, cartList);

            return true;
        }

        public static List<TransactionHeader> ShowById(int UserId)
        {
            return TransactionHeaderHandler.ShowById(UserId);
        }
    }
}