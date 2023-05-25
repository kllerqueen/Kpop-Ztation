using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class AlbumRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        public static void CreateAlbum(Album Collection)
        {
            db.Albums.Add(Collection);
            db.SaveChanges();
            return;
        }
        public static List<Album> GetRelevantAlbums(int ID)
        {
            List<Album> ArtistAlbums = GetAlbumByArtistID(ID);
            return ArtistAlbums;
        }

        public static List<Album> GetAlbumByArtistID(int ID)
        { 
            return (from u in db.Albums where ID.Equals(u.ArtistID) select u).ToList();
        }
    }
}