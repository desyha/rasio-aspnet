using RAiso.Controller;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            string name = TextBox_Name.Text;
            string gender = Radio_Gender.Text;
            DateTime dob = Convert.ToDateTime(TextBox_DOB.Text);
            string phoneNum = TextBox_PhoneNumber.Text;
            string address = TextBox_Address.Text;
            string password = TextBox_Password.Text;

            //Response.Write($"{name}, {gender}, {dob}, {phoneNum}, {address}, {password}");
            Response<MsUser> response = UserController.Register(name, gender, dob, phoneNum, address, password);
            if (response.isSuccess)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                Label_Error.Text = response.Message;
            }
        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}