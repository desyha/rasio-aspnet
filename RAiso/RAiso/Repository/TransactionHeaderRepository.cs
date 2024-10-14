using RAiso.Factory;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAiso.Repository
{
    public class TransactionHeaderRepository
    {
        private static Database1Entities db = new Database1Entities();
        public static int GetThId()
        {
            TransactionHeader th = db.TransactionHeaders.ToList().LastOrDefault();
            int id;
            if (th == null)
            {
                id = 1;
            }
            else
            {
                id = th.TansactionId + 1;
            }
            return id;
        }

        //public static int insertTH(TransactionHeader th)
        //{
        //    db.TransactionHeaders.Add(th);
        //    return db.SaveChanges();
           
        //}

        //internal static void insertTh(int userId, DateTime transactionDate)
        //{
        //    throw new NotImplementedException();
        //}

        public static TransactionHeader GetlastTransactionHeader()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }

        public static bool AddTransactionHeader(TransactionHeader transaction)
        {
            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();
            return true;
        }

        public static List<TransactionHeader> GetByUserId(int UserId)
        {
            return db.TransactionHeaders.Where(x => x.UserId == UserId).ToList();   
        }
        
    }
}