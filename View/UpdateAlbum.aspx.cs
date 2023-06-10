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
        }

        protected void UpdateAlbumButton_Click(object sender, EventArgs e)
        {
            int albumID = Convert.ToInt32(Request.QueryString["albumID"]);
            string name = nameTxt.Text;
            string desc = descTxt.Text;
            int price = Convert.ToInt32(priceTxt.Text);
            int stock = Convert.ToInt32(stockTxt.Text);

            Album album = AlbumRepository.GetAlbumByAlbumID(albumID);
            if (album != null)
            {
                if (!string.IsNullOrEmpty(name))
                    album.AlbumName = name;

                if (!string.IsNullOrEmpty(desc))
                    album.AlbumDescription = desc;

                if (price > 0)
                    album.AlbumPrice = price;

                if (stock >= 0)
                    album.AlbumStock = stock;

                if (ImageUpload.HasFile)
                {
                    string imageExtension = Path.GetExtension(ImageUpload.FileName);
                    int fileSize = ImageUpload.PostedFile.ContentLength;

                    if (imageExtension != ".png" && imageExtension != ".jpg" && imageExtension != ".jpeg" && imageExtension != ".jfif")
                    {
                        errorTxt.Text = "Incorrect image type. Uploaded image can only be .png, .jpg, .jpeg, or .jfif";
                        return;
                    }

                    int maxFileSize = 2 * 1024 * 1024;
                    if (fileSize > maxFileSize)
                    {
                        errorTxt.Text = "Image cannot be larger than 2MB";
                        return;
                    }

                    string imagePath = SaveImage(ImageUpload);
                    album.ImagePath = imagePath;
                }

                AlbumRepository.UpdateAlbum(album);
                Response.Redirect("AlbumDetails.aspx?albumID=" + albumID);
            }
            else
            {
                errorTxt.Text = "Album not found";
            }
        }

        private string SaveImage(FileUpload fileUpload)
        {
            string fileName = Path.GetFileName(fileUpload.FileName);
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + fileName;
            string filePath = Server.MapPath("~/Images/" + uniqueFileName);
            fileUpload.SaveAs(filePath);
            return "~/Images/" + uniqueFileName;
        }
    }
}