using Kpop_Ztation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertArtistButton_Click(object sender, EventArgs e)
        {
            string Name = artistNameTxt.Text;
            string Filename = ImageUpload.PostedFile.FileName;
            string Filepath = "Images/" + ImageUpload.FileName;
            ImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/") + Filename);

            String labelText = ArtistController.CreateArtist(Name, Filepath);
            errorTxt.Text = labelText;
        }
    }
}