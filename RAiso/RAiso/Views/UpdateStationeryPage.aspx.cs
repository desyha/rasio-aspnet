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
    public partial class UpdateStationeryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_Id.Text = Request.QueryString["id"];
            TextBox_OldName.Text = Request.QueryString["name"];
            TextBox_OldPrice.Text = Request.QueryString["price"];
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox_Id.Text);
            string name = TextBox_NewName.Text;
            int price = int.Parse(TextBox_NewPrice.Text);
            Response<MsStationery> response = StationeryController.UpdateStationery(id, name, price);
            if (!response.isSuccess)
            {
                Label_Error.Text = response.Message;
                Label_Error.Visible = true;
            }
            else
            {
                Response.Redirect("InsertStationeryPage.aspx");
            }
        }
    }
}