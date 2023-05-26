using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        private void updateListView()
        {           
            AlbumListView.DataSource = AlbumRepository.GetAllAlbums();
            AlbumListView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
            else
            {
                updateListView();
            }
        }
    }
}