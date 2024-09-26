using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class UpdateMakeupBrand : System.Web.UI.Page
    {
        User user = new User();
        int id;
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
            id = Convert.ToInt32(Request.QueryString["id"]);
            MakeupBrand update = MakeupBrandController.GetMakeupBrandByID(id);
            if (!IsPostBack)
            {
                nameTB.Text = update.MakeupBrandName;
                ratingTB.Text = update.MakeupBrandRating.ToString();
            }

        }

        protected void updatebtn_Click(object sender, EventArgs e)
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

            errorlbl.Text = MakeupBrandController.updateMakeupBrand(id, name, rating, ratingIsEmpty);

            if (errorlbl.Text == "success")
            {
                Response.Redirect("~/View/ManageMakeup.aspx");
            }
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeup.aspx");
        }
    }
}