﻿using Kpop_Ztation.Handler;
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
    public partial class ArtistDetail : System.Web.UI.Page
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        private void updateListView()
        {
            string ID = Request.QueryString["artistId"];
            int artistID = int.Parse(ID);
            List<Album> ArtistAlbums = AlbumRepository.GetAllAlbumByArtistID(artistID);
            AlbumListView.DataSource = ArtistAlbums;
            //AlbumListView.DataSource = AlbumRepository.GetRelevantAlbums(artistID);
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
                if(Request.QueryString["artistId"] != null)
                {
                    string ID = Request.QueryString["artistId"];
                    int artistID = int.Parse(ID);
                    Artist artist = ArtistRepository.GetArtistByID(artistID);

                    artistImage.ImageUrl = artist.ArtistImage;
                    artistName.Text = "Artist Name: " + artist.ArtistName;

                    updateListView();
                }
            }
        }

        protected void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            string ID = Request.QueryString["artistId"];            
            Response.Redirect("../View/InsertAlbum.aspx?param=" + ID);
        }

        public bool checkRole()
        {
            int ID = int.Parse(Session["User"].ToString());
            Customer data = (from dat in db.Customers where dat.CustomerID.Equals(ID) select dat).FirstOrDefault();

            if (data.CustomerRole.Equals("Admin"))
            {
                return true;
            }
            return false;
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteButton = (LinkButton)sender;
            string ID = deleteButton.CommandArgument;
            int albumID = int.Parse(ID);
            AlbumHandler.DeleteAlbum(albumID);
            db.SaveChanges();

            updateListView();
        }                
    }
}