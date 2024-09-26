using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using MakeMeUpzz.Model;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Controller;

namespace MakeMeUpzz.View
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        UserRepository repo = new UserRepository();
        UserFactory factory = new UserFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string email = emailTB.Text;
            string gender = "";
            string password = passwordTB.Text;
            string confirmation = confirmPasswordTB.Text;
            DateTime DOB = Calendar1.SelectedDate;
            errorlbl.Text = "";

            if(rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
          
            errorlbl.Text = UserController.register(username, email, DOB, gender, password, confirmation);
            
            
            if (errorlbl.Text == "success")
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }

            
        }
    }
}