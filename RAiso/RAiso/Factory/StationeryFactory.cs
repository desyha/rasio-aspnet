using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factory
{
    public class StationeryFactory
    {
        public static MsStationery CreateStationery(string name, int price)
        {
            MsStationery stationery = new MsStationery();
            stationery.StationeryName = name;
            stationery.StationeryPrice = price;
            return stationery;
        }
    }
}