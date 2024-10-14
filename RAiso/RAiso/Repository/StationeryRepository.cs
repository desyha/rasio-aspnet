using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repository
{
    public class StationeryRepository
    {
        private static Database1Entities db = new Database1Entities();

        public static int GetStationeryId()
        {
            MsStationery stationery = db.MsStationeries.ToList().LastOrDefault();
            int id;
            if (stationery == null)
            {
                id = 1;
            }
            else
            {
                id = stationery.StationeryId + 1;
            }
            return id;
        }

        public static String insertStationery(string name, int price)
        {
            MsStationery stationery = new MsStationery();
            stationery.StationeryId = GetStationeryId();
            stationery.StationeryName = name;
            stationery.StationeryPrice = price;
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
            return "Success";
        }

        public static List<MsStationery> GetAllStationery()
        {
            Database1Entities db = new Database1Entities();
            return (from x in db.MsStationeries select x).ToList();
        }

        public static MsStationery SelectStationary(int id)
        {
            Database1Entities db = new Database1Entities();
            return (db.MsStationeries.Find(id));
        }

        public static void DeleteStationery(int id)
        {
            Database1Entities db = new Database1Entities();
            MsStationery st = db.MsStationeries.Find(id);
            db.MsStationeries.Remove(st);
            db.SaveChanges();
        }

        public static MsStationery GetStationeryByName(string name)
        {
            return db.MsStationeries.Where(x => x.StationeryName == name).FirstOrDefault();
        }

        public static MsStationery GetStationeryById(int id)
        {
            return db.MsStationeries.Find(id);
        }

        public static void UpdateStationery(int id, string name, int price)
        {
            MsStationery st = db.MsStationeries.Find(id);
            st.StationeryName = name;
            st.StationeryPrice = price;
            db.SaveChanges();
        }
    }
}