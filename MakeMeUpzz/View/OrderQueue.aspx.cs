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
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user;

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
                    user = UserController.GetUserById(nid);
                    Session["user"] = user;
                }
                else
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                    return;
                }
            }
            else
            {
                user = Session["user"] as User;
            }

            List<TransactionHeader> the = null;
            TransactionHeaderController t = new TransactionHeaderController();
            HeaderAdmin.Visible = true;
            the = t.getunhandledtransaction();

            if (!IsPostBack)
            {
                HeaderAdmin.DataSource = the;
                HeaderAdmin.DataBind();
            }
        }
        protected void handleQueuebtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int transactionId = Convert.ToInt32(button.CommandArgument);
            TransactionHeaderController th = new TransactionHeaderController();
            th.handleTransaction(transactionId);

            HeaderAdmin.DataSource = th.getunhandledtransaction();
            HeaderAdmin.DataBind();
            Response.Redirect(Request.RawUrl);
        }
    }
}