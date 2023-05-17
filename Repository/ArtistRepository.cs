using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class ArtistRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateArtist(Artist Idol)
        {
            db.Artists.Add(Idol);
            db.SaveChanges();
            return;
        }
    }
}