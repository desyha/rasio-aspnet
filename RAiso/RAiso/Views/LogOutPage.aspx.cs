using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class LogOutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_yes_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("GuestHomePage.aspx");
        }

        protected void Button_No_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            if(user.UserRole == "user")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Response.Redirect("AdminHomePage.aspx");
            }
        }
    }
}