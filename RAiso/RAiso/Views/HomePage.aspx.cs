using RAiso.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView_User.DataSource = StationeryHandler.GetAllStationery();
            GridView_User.DataBind();
        }
        protected void GridView_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(GridView_User.SelectedRow.Cells[1].Text);
            string name = GridView_User.SelectedRow.Cells[2].Text;
            int price = int.Parse(GridView_User.SelectedRow.Cells[3].Text);

            Response.Redirect("StationeryDetailPage.aspx?id=" + id + "&name=" + name + "&price=" + price);
        }
    }
}