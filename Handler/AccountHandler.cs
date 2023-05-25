using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class AccountHandler
    {        

        public static void CreateAccount(String Name, String Email, String Password, String Gender, String Address)
        {
            Customer User = AccountFactory.CreateAccount(Name, Email, Password, Gender, Address);

            AccountRepository.CreateAccount(User);
            return;
        }

        public static void CreateArtist(String Name, String Image)
        {
            Artist Idol = ArtistFactory.CreateArtist(Name, Image);

            ArtistRepository.CreateArtist(Idol);
            return;
        }

        public static void CreateAlbum(int ArtistID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = AlbumFactory.CreateAlbum(ArtistID, Name, Desc, Price, Stock, Image);

            AlbumRepository.CreateAlbum(Collection);
            return;
        }
    }
}