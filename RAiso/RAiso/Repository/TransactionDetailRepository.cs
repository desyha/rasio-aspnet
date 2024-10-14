using RAiso.Controller;
using RAiso.Factory;
using RAiso.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repository
{
    public class TransactionDetailRepository
    {
        private static Database1Entities db= new Database1Entities();
        public static int GetTdId()
        {
            TransactionDetail td = db.TransactionDetails.ToList().LastOrDefault(); 
            int id;
            if (td == null)
            {
                id = 1;
            }
            else
            {
                id = td.TransactionDetailId + 1;
            }
            return id;
        }

        //public static int insertTD(TransactionDetail td)
        //{
        //    db.TransactionDetails.Add(td);
        //    return db.SaveChanges();
        //}

        public static TransactionDetail GetlastTransactionDetail()
        {
            return db.TransactionDetails.ToList().LastOrDefault();
        }

        public static bool AddTransactionDetail(int TransactionID, List<Cart>cartList)
        {
            foreach (var cart in cartList)
            {
                TransactionDetail transactionDetail = TransactionDetailFactory.CreateTD(TransactionID, (int)cart.StationeryId, cart.Quantity);
                transactionDetail.TransactionDetailId = GetTdId();
                db.TransactionDetails.Add(transactionDetail);
                db.SaveChanges();
            }


            return true;
        }
        public static List<TransactionDetail> GetByUserId(int TransactionId)
        {
            return db.TransactionDetails
              .Include(td => td.MsStationery)
              .Where(x => x.TransactionId == TransactionId)
              .ToList();
        }
    }
}