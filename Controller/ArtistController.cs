using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class ArtistController
    {
        public static String CreateArtist(String Name, String Image)
        {
            if(Functions.CheckEmpty(Name))
            {
                return "Please fill the name field";
            }

            if(Functions.CheckEmpty(Image))
            {
                return "Please upload an image";
            }
            AccountHandler.CreateArtist(Name, Image);
            return "Artist Succesfully Added";
        }
    }
}