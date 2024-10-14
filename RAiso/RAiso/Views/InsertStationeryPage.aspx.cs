using RAiso.Controller;
using RAiso.Handler;
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
    public partial class InsertStationeryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            AdminGridview.DataSource = StationeryHandler.GetAllStationery();
            AdminGridview.DataBind();
        }

        protected void AdminGridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(AdminGridview.Rows[e.RowIndex].Cells[2].Text);
            StationeryHandler.DeleteStationery(id);
            BindGrid();

        }

        protected void AdminGridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(AdminGridview.SelectedRow.Cells[2].Text);
            string name = AdminGridview.SelectedRow.Cells[3].Text;
            int price = int.Parse(AdminGridview.SelectedRow.Cells[4].Text);
            Response.Redirect("UpdateStationeryPage.aspx?id=" + id + "&name=" + name + "&price=" + price);
        }

        protected void Button_Insert_Click(object sender, EventArgs e)
        {
            string ItemName = TextBox_STName.Text;
            string ItemPrice = TextBox_STPrice.Text;

            Response<MsStationery> response = StationeryController.InsertStationery(ItemName, Convert.ToInt32(ItemPrice));
            if (!response.isSuccess)
            {
                Label_error.Text = response.Message;
                Label_error.Visible = true;
            }
            Response.Redirect("InsertStationeryPage.aspx");
        }
    }
}