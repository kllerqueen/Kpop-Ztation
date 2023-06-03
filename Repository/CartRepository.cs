using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class CartRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateCart(Cart newCart)
        {
            db.Carts.Add(newCart);
            db.SaveChanges();
            return;
        }

        public static void updateCart(Cart newCart)
        {
            db.SaveChanges();
            return;
        }
    }
}