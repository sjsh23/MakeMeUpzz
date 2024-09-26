using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Views
{
    public partial class TransactionDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDetails.Visible = false;
            AdminDetails.Visible = false;
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

            List<Model.TransactionDetail> the = null;
            TransactionDetailsController td = new TransactionDetailsController();
            string transactionId = Request.QueryString["TransactionID"];
            int tId = Convert.ToInt32(transactionId);
            if (currentuser.UserRole.Equals("customer"))
            {

                UserDetails.Visible = true;
                the = TransactionDetailsController.FindByTransactionId(tId);

            }
            else if (currentuser.UserRole.Equals("admin"))
            {
                AdminDetails.Visible = true;
                the = TransactionDetailsController.getAllTransactionDetails();

            }

            if (!IsPostBack)
            {
                TransactionHeaderController th = new TransactionHeaderController();
                UserDetails.DataSource = the;
                UserDetails.DataBind();
                AdminDetails.DataSource = the;
                AdminDetails.DataBind();
            }
        }
    }
}