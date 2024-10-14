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
    public partial class UpdateCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_Name.Text = Request.QueryString["name"];
            TextBox_Price.Text = Request.QueryString["price"];

        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            int quantity = int.Parse(TextBox_Quantity.Text);
            Response<Cart> response = CartController.UpdateCart(id, quantity);
            if(!response.isSuccess)
            {
                Label_Error.Text = response.Message;
                Label_Error.Visible = true;
            }
            else
            {
                Response.Redirect("CartPage.aspx");
            }
        }
    }
}