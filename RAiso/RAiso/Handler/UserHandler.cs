using RAiso.Factory;
using RAiso.Models;
using RAiso.Modules;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace RAiso.Handler
{
    public class UserHandler
    {
        public static Response<MsUser> Login(string username, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            MsUser user = UserRepository.GetUser(username, password);
            if (user != null)
            {
                response.isSuccess = true;
                response.Message = "Login Success";
                response.Data = user;
            }
            else
            {
                response.isSuccess = false;
                response.Message = "Login Failed";
            }
            return response;

        }

        public static Response<MsUser> Register(string name, string gender, DateTime dob, string phoneNum, string address, string password, string role)
        {
            Response<MsUser> response = new Response<MsUser>();
            MsUser user = UserRepository.GetUserByUserName(name);
            if (user != null)
            {
                response.isSuccess = false;
                response.Message = "Username already exists";
                return response;
            }
            UserRepository.insertUser(name, gender, dob, phoneNum, address, password, role);
            response.isSuccess = true;
            response.Message = "Register Success";
            return response;
        }

        public static Response<MsUser> GetUserById(int v)
        {
            MsUser user = UserRepository.GetUserById(v);
            Response<MsUser> response = new Response<MsUser>();
            if (user != null)
            {
                response.isSuccess = true;
                response.Message = "User Found";
                response.Data = user;
            }
            else
            {
                response.isSuccess = false;
                response.Message = "User Not Found";
            }
            return response;
        }

        public static MsUser GetIdfromCookie()
        {
            return UserRepository.GetIdfromCookie();
        }

        public static List<MsUser> ShowById(int UserId)
        {
            return UserRepository.GetByUserId(UserId);
        }

        public static Response<MsUser> UpdateUser(int id, string name, string gender, DateTime DOB, string phone, string address, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            MsUser user = UserRepository.GetUserByUserName(name);
            if (user != null)
            {
                response.isSuccess = false;
                response.Message = "Username already exists";
                return response;
            }
            UserRepository.UpdateUser(id, name, gender, DOB, phone, address, password);
            response.isSuccess = true;
            response.Message = "Register Success";
            return response;
        }
    }
}