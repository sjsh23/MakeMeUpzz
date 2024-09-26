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
    public partial class ChangePassword : System.Web.UI.Page
    {
        public User user = new User();
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
        }

        protected void changebtn_Click(object sender, EventArgs e)
        {
            string newpassword = newpasswordTB.Text;
            string oldpassword = oldpasswordTB.Text;
            string confirmation = confirmPasswordTB.Text;

            errorlbl.Text = UserController.updatePassword(user.Username, oldpassword, newpassword, confirmation);
        }
    }
}