using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class InsertMakeupBrand : System.Web.UI.Page
    {
        User user = new User();
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

            if (!user.UserRole.Equals("admin"))
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void insertbtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            bool ratingIsEmpty = false;
            int rating = 0;
            errorlbl.Text = "";

            if (string.IsNullOrEmpty(ratingTB.Text))
            {
                ratingIsEmpty = true;
            }
            else
            {
                ratingIsEmpty = false;
                rating = Convert.ToInt32(ratingTB.Text);
            }

            errorlbl.Text = MakeupBrandController.insertMakeupBrand(name, rating, ratingIsEmpty);

            if(errorlbl.Text == "success")
            {
                Response.Redirect("~/View/ManageMakeup.aspx");
            }

        }
    }
}