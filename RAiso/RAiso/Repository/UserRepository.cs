using RAiso.Factory;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repository
{
    public class UserRepository
    {
        private static Database1Entities db = new Database1Entities();
        public static MsUser GetUser(string username, string password)
        {
            return db.MsUsers.Where(x => x.UserName == username && x.UserPassword == password).FirstOrDefault();
        }

        public static int GetUserId()
        {
            MsUser user = db.MsUsers.ToList().LastOrDefault();
            int id;
            if(user == null)
            {
                id = 1;
            }
            else
            {
                id = user.UserId + 1;
            }
            return id;
        }

        public static String insertUser(string name, string gender, DateTime DOB, string phone, string address, string password, string role)
        {
            MsUser user = UserFactory.CreateUser(name, gender, DOB, phone, address, password, role);
            user.UserId = GetUserId();
            db.MsUsers.Add(user);
            db.SaveChanges();
            return "Success";
        }

        public static MsUser GetUserByUserName(string username)
        {
            return db.MsUsers.Where(x => x.UserName == username).FirstOrDefault();
        }

        public static MsUser GetUserById(int v)
        {
            return db.MsUsers.Find(v);
        }

        public static MsUser GetIdfromCookie()
        {
            return (from x in db.MsUsers where x.UserId == 1 select x).FirstOrDefault();
        }

        public static List<MsUser> GetByUserId(int UserID)
        {
            return db.MsUsers.Where(x => x.UserId == UserID).ToList();
        }

        public static String UpdateUser(int id,string name, string gender, DateTime DOB, string phone, string address, string password)
        {
            MsUser user = db.MsUsers.Where(x => x.UserId == id).FirstOrDefault();
            user.UserName = name;
            user.UserGender = gender;
            user.UserDOB = DOB;
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            db.SaveChanges();
            return "Success";
        }
    }
}