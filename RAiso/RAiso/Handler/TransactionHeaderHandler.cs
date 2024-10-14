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
    public class TransactionHeaderHandler
    {
        

        public static bool AddTransactionHeader(int UserId, DateTime now, List<Cart>cartList)
        {
            int id = TransactionHeaderRepository.GetThId();
            TransactionHeader transaction = TransactionHeaderFactory.CreateTH(UserId, now);
            transaction.TansactionId = id;
            TransactionHeaderRepository.AddTransactionHeader(transaction);

            int transactionId = transaction.TansactionId;
            TransactionDetailRepository.AddTransactionDetail(id, cartList);
            return true;

        }

        public static List<TransactionHeader> ShowById(int UserId)
        {
            return TransactionHeaderRepository.GetByUserId(UserId);
        }
    }
}