﻿using Kpop_Ztation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Kpop_Ztation.View
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
        }

        protected void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            string Name = nameTxt.Text;
            string Desc = descTxt.Text;
            int Price = int.Parse(priceTxt.Text);
            int Stock = int.Parse(stockTxt.Text);

            string Filename = ImageUpload.PostedFile.FileName;
            string Filepath = "/Images/Album/" + ImageUpload.FileName;
            string imageExtension = Path.GetExtension(Filename).ToLower();
            int fileSize = ImageUpload.PostedFile.ContentLength;

            ImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/Album/") + Filename);

            string labelText = AlbumController.CreateAlbum(Name, Desc, Price, Stock, Filepath, imageExtension, fileSize);
            errorTxt.Text = labelText;
        }
    }
}