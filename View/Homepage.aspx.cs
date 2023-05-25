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
    public partial class Homepage : System.Web.UI.Page
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        private void updateListView()
        {
            ArtistListView.DataSource = ArtistRepository.GetAllArtist();
            ArtistListView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //String user = Session["User"].ToString();
            //Customer data = (from dat in db.Customers where dat.CustomerEmail.Equals(user) select dat).FirstOrDefault();

            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }            
            else
            {
                updateListView();
            }            

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/ArtistDetail.aspx");
        }

        protected void InsertArtistButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/InsertArtist.aspx");
        }

        protected void ArtistGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("../View/ArtistDetail.aspx");
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

        protected void artistUpdateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/UpdateArtist.aspx");
        }

        protected void artistDeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}