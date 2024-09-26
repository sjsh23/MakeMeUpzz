using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HeaderUser.Visible = false;
            HeaderAdmin.Visible = false;
            User currentuser = null;


            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
                return;
            }

            if (Session["user"] == null)
            {
                string id = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(id, out int nid))
                {
                    currentuser = UserController.GetUserById(nid);
                    Session["user"] = currentuser;
                }
                else
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                    return;
                }
            }
            else
            {
                currentuser = Session["user"] as User;
            }


            List<TransactionHeader> the = null;
            TransactionHeaderController t = new TransactionHeaderController();
            if (currentuser.UserRole.Equals("customer"))
            {

                HeaderUser.Visible = true;
                the = t.getbyuserid(currentuser.UserID);

            }
            else if (currentuser.UserRole.Equals("admin"))
            {
                HeaderAdmin.Visible = true;
                the = t.getAllTransactionHeaders();
            }

            if (!IsPostBack)
            {
                HeaderUser.DataSource = the;
                HeaderUser.DataBind();
                HeaderAdmin.DataSource = the;
                HeaderAdmin.DataBind();
            }
        }
        protected void TransactionDetailsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string transactionId = button.CommandArgument;
            Response.Redirect("~/View/TransactionDetails.aspx?TransactionID=" + transactionId);
        }
    }
}