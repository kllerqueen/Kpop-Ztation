using Kpop_Ztation.Controller;
using Kpop_Ztation.Repository;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        public static void UpdateCart()
        {
            db.SaveChanges();
            return;
        }

        public static int RemoveAllItems(List<Cart> cartList)
        {
            db.Carts.RemoveRange(cartList);
            return db.SaveChanges();
        }

        public static List<Cart> getAllCarts(int userID)
        {
            return (from Cart in db.Carts where Cart.CustomerID == userID select Cart).ToList();
        }

        public static int getLastTransactionID(int userID)
        {
            var lastTransactionID = db.TransactionHeaders.Where(t => t.CustomerID == userID).OrderByDescending(t => t.TransactionID).Select(t => t.TransactionID).FirstOrDefault();
            return lastTransactionID;
        }

        public static Cart getCartDelete(int userID, int albumID)
        {
            Cart toDelete = db.Carts.FirstOrDefault(c => c.CustomerID == userID && c.AlbumID == albumID);
            return toDelete;
        }
    }
}