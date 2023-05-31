using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;

namespace Kpop_Ztation.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Customer User = AccountRepository.GetUser
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
        }

        protected void updateProfile_Click(object sender, EventArgs e)
        {
            string Name = nameTxt.Text;
            string Email = emailTxt.Text;
            string Gender = GenderSelect.SelectedItem.Value.ToString();
            string Address = addressTxt.Text;
            string Password = passwordTxt.Text;

            String labelText = AccountController.UpdateProfile(Name, Email, Password, Gender, Address);
            errorTxt.Text = labelText;

        }
    }
}