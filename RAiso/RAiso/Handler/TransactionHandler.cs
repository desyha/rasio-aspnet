using RAiso.Models;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetTransactionsData()
        {
            return TransactionRepository.GetTransactions();
        }

        public static List<MsStationery> GetStationeryData(int id)
        {
            return TransactionRepository.GetID(id);
        }

        
    }
}