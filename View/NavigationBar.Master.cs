using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("../View/LoginPage.aspx");
        }

        public bool checkRole()
        {
            String user = Session["User"].ToString();
            Customer data = (from dat in db.Customers where dat.CustomerEmail.Equals(user) select dat).FirstOrDefault();

            if (data.CustomerRole.Equals("Admin"))
            {
                return true;
            }
            return false;
        }
    }
}