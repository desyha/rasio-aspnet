using RAiso.Handler;
using RAiso.Models;
using RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factory
{
    public class UserFactory
    {
        public static MsUser CreateUser(string name, string gender, DateTime DOB, string phone, string address, string password, string role)
        {
            MsUser user = new MsUser();
            user.UserName = name;
            user.UserGender = gender;
            user.UserDOB = DOB;
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            user.UserRole = role;
            return user;

        }

        
    }
}