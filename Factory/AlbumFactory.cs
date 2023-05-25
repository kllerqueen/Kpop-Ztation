using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class AlbumFactory
    {
        public static Album CreateAlbum(int ArtistID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = new Album();
            Collection.ArtistID = ArtistID;
            Collection.AlbumName = Name;
            Collection.AlbumDescription = Desc;
            Collection.AlbumPrice = Price;
            Collection.AlbumStock = Stock;
            Collection.AlbumImage = Image;

            return Collection;
        }
    }
}