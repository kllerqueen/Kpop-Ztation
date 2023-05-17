using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class ArtistFactory
    {
        public static Artist CreateArtist(String Name, String Image)
        {
            Artist Idol = new Artist();
            Idol.ArtistName = Name;
            Idol.ArtistImage = Image;

            return Idol;
        }
    }
}