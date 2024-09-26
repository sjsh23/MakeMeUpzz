using MakeMeUpzz.Model;
using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        public User user = new User();
        public List<Makeup> makeup = new List<Makeup>();
        public List<Cart> cart = new List<Cart>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                user = (User)Session["user"];
            }

            cart = CartController.GetCartsByUserID(user.UserID);

            if (!IsPostBack)
            {
                refreshCart();
                makeup = MakeupController.GetMakeups();
                makeupGV.DataSource = makeup;
                makeupGV.DataBind();
            }
            
        }

        protected void clearCartbtn_Click(object sender, EventArgs e)
        {
            alertlbl.Text = CartController.deleteAllCartByUserID(user.UserID, cart);
            if (alertlbl.Text == "cart cleared")
            {
                Response.Redirect(Request.RawUrl);
            }
            refreshCart();
        }

       protected void refreshCart()
        {
            cartGV.DataSource = cart;
            cartGV.DataBind();
        }

        protected void checkoutbtn_Click(object sender, EventArgs e)
        {
            TransactionHeaderController th = new TransactionHeaderController();
            TransactionDetailsController td = new TransactionDetailsController();
            List<Cart> insert = new List<Cart>();
            insert = CartController.GetCartsByUserID(user.UserID).ToList();

            int id = th.generateTransactionID();

            string done = th.InsertNewUnhandledTransaction(id, user.UserID, insert);

            if (done == "success")
            {
                refreshCart();
            }
        }

        protected void makeupGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridView gv = (GridView)sender;
            GridViewRow gvRow = gv.Rows[e.RowIndex];
            TextBox tb = (TextBox)gvRow.FindControl("quantityTB");
            HiddenField hf = (HiddenField)gvRow.FindControl("IDhf");
            Label lbl = (Label)gvRow.FindControl("errorlbl");
            int userid = user.UserID;
            int makeupid = Convert.ToInt32(hf.Value);
            int quantity;
            if (string.IsNullOrEmpty(tb.Text))
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToInt32(tb.Text);
            }

            lbl.Text = CartController.insertCart(userid, makeupid, quantity);

            if (lbl.Text == "success")
            {
                Response.Redirect(Request.RawUrl);
            }
            refreshCart();
        }
    }
}