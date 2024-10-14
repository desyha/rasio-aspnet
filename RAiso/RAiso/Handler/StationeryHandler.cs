using RAiso.Models;
using RAiso.Modules;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace RAiso.Handler
{
    public class StationeryHandler
    {
        public static void DeleteStationery(int id)
        {
            MsStationery ms = StationeryRepository.SelectStationary(id);
            if (ms == null)
            {
                return;
            }
            StationeryRepository.DeleteStationery(id);
        }

        public static Response<MsStationery> InsertStationery(string name, int price)
        {
            Response<MsStationery> response = new Response<MsStationery>();
            MsStationery stationery = StationeryRepository.GetStationeryByName(name);
            if (stationery != null)
            {
                response.isSuccess = false;
                response.Message = "Stationery already exists";
                return response;
            }
            StationeryRepository.insertStationery(name, price);
            response.isSuccess = true;
            response.Message = "Insert Success";
            return response;
        }

        public static List<MsStationery> GetAllStationery()
        {
            return StationeryRepository.GetAllStationery();
        }

        public static void UpdateStationery(int id, string name, int price)
        {
            StationeryRepository.UpdateStationery(id, name, price);
        }

    }
}