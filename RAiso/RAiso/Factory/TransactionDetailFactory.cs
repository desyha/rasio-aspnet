using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTD(int TransactionId, int StationeryId, int Quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionId = TransactionId;
            td.StationeryId = StationeryId;
            td.Quantity = Quantity;
            return td;
        }
    }
}