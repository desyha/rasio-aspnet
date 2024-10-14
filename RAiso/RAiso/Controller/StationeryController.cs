using RAiso.Handler;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace RAiso.Controller
{
    public class StationeryController
    {
        //public static Response<MsStationery> GetAllStationery()
        //{
        //   Response<MsStationery> response = new Response<MsStationery>();
        //   return response;

        //}

        public static Response<MsStationery> InsertStationery(string name, int price)
        {
            Response<MsStationery> response = new Response<MsStationery>();
            if (name == "" || price == 0)
            {
                response.isSuccess = false;
                response.Message = "Please fill all the form";
                return response;
            }
            if (name.Length < 3 || name.Length > 50)
            {
                response.isSuccess = false;
                response.Message = "Stationery name must be between 3 and 50 characters";
                return response;
            }
            if (price < 2000)
            {
                response.isSuccess = false;
                response.Message = "Price must be greater or equal to 2000";
                return response;
            }
            if (!price.ToString().Any(char.IsDigit))
            {
                response.isSuccess = false;
                response.Message = "Price must be numeric";
                return response;
            }
            return StationeryHandler.InsertStationery(name, price);
        }

        public static Response<MsStationery> UpdateStationery(int id, string name, int price)
        {
            Response<MsStationery> response = new Response<MsStationery>();
            if (name == "" || price == 0)
            {
                response.isSuccess = false;
                response.Message = "Please fill all the form";
                return response;
            }
            if (name.Length < 3 || name.Length > 50)
            {
                response.isSuccess = false;
                response.Message = "Stationery name must be between 3 and 50 characters";
                return response;
            }
            if (price < 2000)
            {
                response.isSuccess = false;
                response.Message = "Price must be greater or equal to 2000";
                return response;
            }
            if (!price.ToString().Any(char.IsDigit))
            {
                response.isSuccess = false;
                response.Message = "Price must be numeric";
                return response;
            }
            StationeryHandler.UpdateStationery(id, name, price);
            response.isSuccess = true;
            response.Message = "Update Success";
            return response;
        }
    }
}