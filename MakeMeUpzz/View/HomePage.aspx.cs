using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MakeMeUpzz.Model;
using MakeMeUpzz.Controller;

namespace MakeMeUpzz.View
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public Database1Entities db = new Database1Entities();
        public User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                if (Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = (from u in db.Users where u.UserID == id select u).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (User)Session["user"];
                }
            }

            CustomerGV.DataSource = UserController.getCustomer();
            CustomerGV.DataBind();
        }
    }
}