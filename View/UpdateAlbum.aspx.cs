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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                // Retrieve the album ID from the query string
                if (Request.QueryString["albumID"] != null)
                {
                    int albumID = Convert.ToInt32(Request.QueryString["albumID"]);
                    LoadAlbum(albumID);
                }
            }
        }

        protected void LoadAlbum(int albumID)
        {
            // Get the album from the repository based on the ID
            Album album = AlbumRepository.GetAlbumByAlbumID(albumID);

            if (album != null)
            {
                // Populate the form fields with the album data
                hdnAlbumID.Value = album.AlbumID.ToString();
                txtAlbumName.Text = album.AlbumName;
                txtDescription.Text = album.AlbumDescription;
                txtPrice.Text = album.AlbumPrice.ToString();
                txtStock.Text = album.AlbumStock.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve the album ID from the hidden field
            int albumID = Convert.ToInt32(hdnAlbumID.Value);

            // Get the album from the repository based on the ID
            Album album = AlbumRepository.GetAlbumByAlbumID(albumID);

            if (album != null)
            {
                // Update the album object with the new data
                album.AlbumName = txtAlbumName.Text;
                album.AlbumDescription = txtDescription.Text;
                album.AlbumPrice = Convert.ToInt32(txtPrice.Text);
                album.AlbumStock = Convert.ToInt32(txtStock.Text);

                // Save the updated album to the repository
                AlbumRepository.UpdateAlbum(album);

                lblMessage.Text = "Album updated successfully.";
            }
        }
    }
}