using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class ArtistController
    {
        public static String CreateArtist(String Name, String Image, String imageExtension, int fileSize)
        {
            if(Functions.CheckEmpty(Name))
            {
                return "Please fill the name field";
            }

            if(Functions.CheckEmpty(Image))
            {
                return "Please upload an image";
            }

            if (imageExtension != ".png" && imageExtension != ".jpg" && imageExtension != ".jpeg" && imageExtension != ".jfif")
            {
                return "Incorrect image type. Uploaded image can only be .png, .jpg, .jpeg, or .jfif";
            }

            int maxFileSize = 2 * 1024 * 1024;
            if (fileSize > maxFileSize)
            {
                return "Image can not be larger than 2MB";
            }

            AccountHandler.CreateArtist(Name, Image);
            return "Artist Succesfully Added";
        }

        public static String UpdateArtist(int ID, string Name, string Image, string ImageExtension, int fileSize)
        {
            //Validasi

            AccountHandler.UpdateArtist(ID, Name, Image);
            return "Artist succesfully updated";
        }
    }
}