using RAiso.Handler;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controller
{
    public class TransactionDetailController
    {
        public static List<TransactionDetail> ShowById(int TransactionId)
        {
            return TransactionDetailHandler.ShowById(TransactionId);
        }
    }
}