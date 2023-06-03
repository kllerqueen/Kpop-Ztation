using Kpop_Ztation.Controller;
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
    public partial class AlbumDetail : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }    
            else
            {
                if (Request.QueryString["albumId"] != null)
                {
                    string ID = Request.QueryString["albumId"];
                    int albumID = int.Parse(ID);
                    Album album = AlbumRepository.GetAlbumByAlbumID(albumID);

                    albumImage.ImageUrl = album.AlbumImage;
                    albumName.Text = album.AlbumName;
                    albumDesc.Text = album.AlbumDescription;
                    albumPrice.Text = "Rp." + album.AlbumPrice;
                    albumStock.Text = "Available stock: " + album.AlbumStock;                    
                }
            }
        }

        protected void addCart_Click(object sender, EventArgs e)
        {
            
        }
    }
}