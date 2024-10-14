using RAiso.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class GuestHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView_Guest.DataSource = StationeryHandler.GetAllStationery();
            GridView_Guest.DataBind();

        }
    }
}