using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTH(int UserId, DateTime TransactionDate)
        {
            TransactionHeader th = new TransactionHeader();
            th.UserId = UserId;
            th.TransactionDate = TransactionDate;
            return th;

        }

        //internal static TransactionHeader CreateTH(int TransactionId, int? userId, DateTime now)
        //{
        //    if(userId == null)
        //    {
        //        throw new ArgumentNullException(nameof(userId));
        //    }

        //    return new TransactionHeader
        //    {
        //        TansactionId = TransactionId,
        //        UserId = userId.Value,
        //        TransactionDate = now
        //    };
        //}
    }
}