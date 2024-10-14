using RAiso.Factory;
using RAiso.Models;
using RAiso.Modules;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace RAiso.Handler
{
    public class TransactionDetailHandler
    {
        public static List<TransactionDetail> ShowById(int TransactionId)
        {
            return TransactionDetailRepository.GetByUserId(TransactionId);
        }
    }
}