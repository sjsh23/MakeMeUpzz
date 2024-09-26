using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class InsertMakeup : System.Web.UI.Page
    {
        public User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            MakeupBrandRepository brepo = new MakeupBrandRepository();
            MakeupTypeRepository trepo = new MakeupTypeRepository();
            List<MakeupBrand> brand = brepo.GetMakeupBrands();
            List<MakeupType> type = trepo.GetMakeupTypes();
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

            if (!IsPostBack)
            {
                foreach (var t in type)
                {
                    TypeIDDDL.Items.Add(t.MakeupTypeName);
                }

                foreach (var b in brand)
                {
                    BrandIDDDL.Items.Add(b.MakeupBrandName);
                }
            }
            
        }

        protected void insertbtn_Click(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();

            string name = nameTB.Text;
            bool priceIsEmpty = false;
            bool weightIsEmpty = false;
            int price = 0;
            int weight = 0;
            errorlbl.Text = "";

            if(string.IsNullOrEmpty(priceTB.Text))
            {
                priceIsEmpty = true;
            }
            else
            {
                priceIsEmpty = false;
                price = Convert.ToInt32(priceTB.Text);
            }
            if (string.IsNullOrEmpty(weightTB.Text))
            {
                weightIsEmpty = true;
            }
            else
            {
                weightIsEmpty = false;
                weight = Convert.ToInt32(weightTB.Text);
            }
            
            string typeName = TypeIDDDL.Text;
            string brandName = BrandIDDDL.Text;

            int typeid = (from t in db.MakeupTypes where t.MakeupTypeName == typeName select t).FirstOrDefault().MakeupTypeID;
            int brandid = (from b in db.MakeupBrands where b.MakeupBrandName == brandName select b).FirstOrDefault().MakeupBrandID;  

            errorlbl.Text = MakeupController.insertMakeup(name, price, weight, typeid, brandid, priceIsEmpty, weightIsEmpty);

            if(errorlbl.Text == "success")
            {
                Response.Redirect("~/View/ManageMakeup.aspx");
            }

        }
    }
}