using RAiso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAiso.Views
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int transactionId = int.Parse(Request.QueryString["id"]);
            GridView_TransactionDetail.DataSource = TransactionDetailController.ShowById(transactionId);
            GridView_TransactionDetail.DataBind();
        }
    }
}