using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MakeMeUpzz.Model;
using MakeMeUpzz.MasterPage;
using MakeMeUpzz.Controller;
using System.Diagnostics.Eventing.Reader;

namespace MakeMeUpzz.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentuser = null;
            if (Session["user"] != null && Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
                return;
            }
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                return;
            }
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");

                return;
            }
            if (Session["user"] == null)
            {
                string id = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(id, out int nid))
                {
                    currentuser = UserController.GetUserById(nid);
                    Session["user"] = currentuser;
                    Response.Redirect("~/View/HomePage.aspx");
                    return;
                }
            }

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string password = PasswordTB.Text;
            bool remember = rememberMeCB.Checked;
            errorlbl.Text = "";

            errorlbl.Text = UserController.login(username, password);

            if (errorlbl.Text == "success")
                if (errorlbl.Text == "success")
                {
                    User user = (from u in db.Users where u.Username == username select u).FirstOrDefault();
                    Session["user"] = user;
                    if (remember)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = user.UserID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    Response.Redirect("~/View/HomePage.aspx");
                }



        }
    }
}