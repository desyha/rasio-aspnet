using RAiso.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView_Admin.DataSource = StationeryHandler.GetAllStationery();
            GridView_Admin.DataBind();
        }

        protected void Button_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertStationeryPage.aspx");
        }
    }
}