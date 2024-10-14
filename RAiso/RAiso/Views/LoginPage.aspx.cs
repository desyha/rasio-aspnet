using RAiso.Controller;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user-cred"] != null)
            {
                Response<MsUser> response = UserController.GetUserById(Convert.ToInt32(Request.Cookies["user-cred"]));
                if (response.isSuccess)
                {
                    Session["user"] = response.Data;

                }
            }
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                if (user.UserRole == "Admin")
                {
                    Response.Redirect("AdminHomePage.aspx");
                }
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            string username = TextBox_Name.Text;
            string password = TextBox_Password.Text;

            Response<MsUser> response = UserController.Login(username, password);

            if (response.isSuccess)
            {
                MsUser user = response.Data;
                Session["user"] = response.Data;
                if (CheckBox_remember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user");
                    cookie["user-cred"] = user.UserId.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                if (user.UserRole == "admin")
                {
                    Response.Redirect("AdminHomePage.aspx");
                }
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label_Error.Text = response.Message;
            }

        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/RegisterPage.aspx");
        }
    }
}