using RAiso.Controller;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace RAiso.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView_TH.DataSource = TransactionHeaderController.ShowById(((MsUser)Session["user"]).UserId);
            GridView_TH.DataBind();
        }

        protected void GridView_TH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(GridView_TH.SelectedRow.Cells[0].Text);
            Response.Redirect("TransactionDetailPage.aspx?id=" + id);
        }
    }
}