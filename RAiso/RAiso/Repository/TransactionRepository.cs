using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace RAiso.Repository
{
    public class TransactionRepository
    {

        public static List<TransactionHeader> GetTransactions()
        {
            Database1Entities db = new Database1Entities();
            return db.TransactionHeaders.ToList();
        }

        public static List<MsStationery> GetID(int id)
        {
            Database1Entities db = new Database1Entities();
            return db.MsStationeries.Where(x => x.StationeryId == id).ToList();
        }

    } 
}