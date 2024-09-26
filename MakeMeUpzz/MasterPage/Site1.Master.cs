
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MakeMeUpzz.Model;
using MakeMeUpzz.View;

namespace MakeMeUpzz.MasterPage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        public Database1Entities db = new Database1Entities();
        public User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (User)Session["user"];
        }

        protected void homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void Logoutbtn_Click(object sender, EventArgs e)
        {
            string[] cookie_keys = Request.Cookies.AllKeys;
            foreach (string cookie_key in cookie_keys)
            {
                HttpCookie cookie = new HttpCookie(cookie_key);
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Session.Remove("user");

            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void OrderQueuebtn_Click(object sender, EventArgs e)
        {

        }

        protected void Orderbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderMakeup.aspx");
        }

        protected void Profilebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void Managebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeup.aspx");
        }

        protected void Historybtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistory.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void ManageMakeupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeUp.aspx");
        }

        protected void OrderQbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderQueue.aspx");
        }

        protected void HistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistory.aspx");
        }

        protected void OrderMakeupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderMakeup.aspx");
        }

        protected void TransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("");
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

            Session["user"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}
