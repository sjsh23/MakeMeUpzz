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
    public partial class WebForm4 : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                usernameTB.Text = user.Username;
                emailTB.Text = user.UserEmail;
                if (user.UserGender.Equals("Male"))
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                Calendar1.SelectedDate = user.UserDOB;
            }
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string email = emailTB.Text;
            string gender = "";
            DateTime DOB = Calendar1.SelectedDate;
            errorlbl.Text = "";

            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }

            errorlbl.Text = UserController.updateProfile(user.UserID, username, email, DOB, gender);

        }

        protected void changePasswordbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ChangePassword.aspx");
        }
    }
}