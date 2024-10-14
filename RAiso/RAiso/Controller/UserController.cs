using RAiso.Handler;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controller
{
    public class UserController
    {
        public static Response<MsUser> Login(string username, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            if (username == "" || password == "")
            {
                response.isSuccess = false;
                response.Message = "Username or Password cannot be empty";
                return response;
            }
            return UserHandler.Login(username, password);

        }

        public static Response<MsUser> Register(string name, string gender, DateTime dob, string phoneNum, string address, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            if (name == "" || gender == "" || dob == null || phoneNum == "" || address == "" || password == "")
            {
                response.isSuccess = false;
                response.Message = "All fields must be filled";
                return response;
            }
            if (name.Length < 5 || name.Length > 50)
            {
                response.isSuccess = false;
                response.Message = "Username must be between 5 and 50 characters";
                return response;
            }
            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                response.isSuccess = false;
                response.Message = "Password must contain only alphanumeric";
                return response;
            }
            if (dob.AddYears(1) > DateTime.Now)
            {
                response.isSuccess = false;
                response.Message = "Age must be at least 1 year age";
                return response;
            }
            return UserHandler.Register(name, gender, dob, phoneNum, address, password, "user");
        }

        public static Response<MsUser> GetUserById(int v)
        {
            if (v < 1)
            {
                Response<MsUser> response = new Response<MsUser>();
                response.isSuccess = false;
                response.Message = "User not found";
                return response;
            }
            return UserHandler.GetUserById(v);
        }

        public static MsUser GetIdfromCookie()
        {
            return UserHandler.GetIdfromCookie();
        }

        public static List<MsUser> ShowById(int UserId)
        {
            return UserHandler.ShowById(UserId);
        }

        public static Response<MsUser> UpdateUser(int id, string name, string gender, DateTime DOB, string phone, string address, string password)
        {
            Response<MsUser > response = new Response<MsUser>();
            if (name == "" || gender == "" || DOB == null || phone == "" || address == "" || password == "")
            {
                response.isSuccess = false;
                response.Message = "All fields must be filled";
                return response;
            }
            if (name.Length < 5 || name.Length > 50)
            {
                response.isSuccess = false;
                response.Message = "Username must be between 5 and 50 characters";
                return response;
            }
            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                response.isSuccess = false;
                response.Message = "Password must contain only alphanumeric";
                return response;
            }
            if (DOB.AddYears(1) > DateTime.Now)
            {
                response.isSuccess = false;
                response.Message = "Age must be at least 1 year age";
                return response;
            }
            return UserHandler.UpdateUser(id, name, gender, DOB, phone, address, password);
        }
    }
}