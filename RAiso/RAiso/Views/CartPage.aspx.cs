using RAiso.Controller;
using RAiso.Handler;
using RAiso.Models;
using RAiso.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace RAiso.Views
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int UserId = user.UserId;
            GridView_Cart.DataSource = CartController.GetCartById(UserId);
            GridView_Cart.DataBind();
        }

        protected void GridView_Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(GridView_Cart.SelectedRow.Cells[0].Text);
            string name = GridView_Cart.SelectedRow.Cells[1].Text;
            int price = int.Parse(GridView_Cart.SelectedRow.Cells[2].Text);
            Response.Redirect("UpdateCartPage.aspx?id=" + id + "&name=" + name + "&price=" + price);
        }

        protected void GridView_Cart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridView_Cart.Rows[e.RowIndex].Cells[0].Text);
            CartHandler.DeleteCart(id);
            Response.Redirect("CartPage.aspx");

        }

        //public List<Cart> Carts
        //{
        //    get
        //    {
        //        return Session["cart"] == null ? (List<Cart>)Session["cart"] : InitializeSession();
        //    }
        //}

        private List<Cart> InitializeSession()
        {
            Response<List<Cart>> response = CartController.GetCardByUserId(((MsUser)Session["user"]).UserId);
            if (response.isSuccess)
            {
                Session["cart"] = response.Data;
                return response.Data;
            }
            Session["cart"] = new List<Cart>();
            return (List<Cart>)Session["cart"];
        }

        protected void Button_CheckOut_Click(object sender, EventArgs e)
        {

            MsUser user = (MsUser)Session["user"];

            int UserId = user.UserId;
            var cartList = CartController.GetAllCart();

            if (cartList == null || !cartList.Any()) return; 

            DateTime now = DateTime.Now;

            bool transactionAdded = TransactionHeaderController.AddTransaction(UserId, now, cartList);

            if (transactionAdded)
            {
                foreach (var cart in cartList)
                {
                    CartController.RemoveCart(cart.CartId);
                }
            }

            Response.Redirect(Request.RawUrl);
        }


    }
}