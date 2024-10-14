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
    public partial class UpdateProfileAdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserId = user.UserId;
            GridView_AdminData.DataSource = UserController.ShowById(UserId);
            GridView_AdminData.DataBind();

        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserId = user.UserId;
            string name = TextBox_Name.Text;
            string gender = Radio_Gender.Text;
            string phoneNum = TextBox_PhoneNumber.Text;
            string address = TextBox_Address.Text;
            string password = TextBox_Password.Text;

            Response<MsUser> response = UserController.UpdateUser(UserId, name, gender, dob, phoneNum, address, password);
            if (!response.isSuccess)
            {
                Label_Error.Text = response.Message;
                Label_Error.Visible = true;
            }
            else
            {
                if (Session["user"] != null)
                { 
                    if (user.UserRole == "Admin")
                    {
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    Response.Redirect("HomePage.aspx");
                }
            }
        }
    }
}