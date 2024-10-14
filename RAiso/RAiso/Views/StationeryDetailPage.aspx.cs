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
    public partial class StationeryDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_Name.Text = Request.QueryString["name"];
            TextBox_Price.Text = Request.QueryString["price"];
        }

        protected void Button_AddCart_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((MsUser)Session["user"]).UserId);
            int StationaryId = int.Parse(Request.QueryString["id"]);
            int Quantity = int.Parse(TextBox_Quantity.Text);

            Response<Cart> response = CartController.InsertCart(id, StationaryId, Quantity);
            if (response.isSuccess)
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label_Error.Text = response.Message;
                Label_Error.Visible = true;
            }
        }
    }
}