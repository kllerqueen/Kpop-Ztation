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
        private void updateListView()
        {
            ArtistListView.DataSource = ArtistRepository.GetAllArtist();
            ArtistListView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            updateListView();
            
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
    }
}