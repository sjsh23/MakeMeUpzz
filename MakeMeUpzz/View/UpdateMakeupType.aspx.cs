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
    public partial class UpdateMakeupType : System.Web.UI.Page
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
            MakeupType update = MakeupTypeController.GetMakeupTypeByID(id);
            if (!IsPostBack)
            {
                nameTB.Text = update.MakeupTypeName;
            }
        }

        protected void insertbtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            errorlbl.Text = "";

            errorlbl.Text = MakeupTypeController.updateMakeupType(id, name);

            if (errorlbl.Text == "success")
            {
                Response.Redirect("~/View/ManageMakeup.aspx");
            }

        }
    }
}