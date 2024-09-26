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
    public partial class ManageMakeup : System.Web.UI.Page
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

            makeupGV.DataSource = MakeupController.GetMakeups();
            makeupGV.DataBind();
            makeupBrandGV.DataSource = MakeupBrandController.GetMakeupBrands();
            makeupBrandGV.DataBind();
            makeupTypeGV.DataSource = MakeupTypeController.getMakeupType();
            makeupTypeGV.DataBind();
        }

        protected void insertMakeupbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeup.aspx");
        }

        protected void insertBrandbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeupBrand.aspx");
        }

        protected void insertTypebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeupType.aspx");
        }

        protected void makeupGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            MakeupController.deleteMakeup(id);
            Response.Redirect(Request.RawUrl);
        }

        protected void makeupGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupGV.Rows[e.NewEditIndex];
            Response.Redirect("~/View/UpdateMakeup.aspx?id=" + row.Cells[0].Text);

        }

        protected void makeupBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupBrandGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            MakeupBrandController.deleteMakeupBrand(id);
            Response.Redirect(Request.RawUrl);
        }

        protected void makeupBrandGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupBrandGV.Rows[e.NewEditIndex];
            Response.Redirect("~/View/UpdateMakeupBrand.aspx?id=" + row.Cells[0].Text);
        }

        protected void makeupTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupTypeGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text) - 1;

            MakeupTypeController.deleteMakeupType(id);
            Response.Redirect(Request.RawUrl);
        }

        protected void makeupTypeGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupTypeGV.Rows[e.NewEditIndex];
            Response.Redirect("~/View/UpdateMakeupType.aspx?id=" + row.Cells[0].Text);
        }
    }
}