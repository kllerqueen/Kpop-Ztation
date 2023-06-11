using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public class CartItem
    {
        public String albumPicture;
        public String albumName;
        public int Quantity;
        public int albumPrice;

    }

    public partial class CartPage : System.Web.UI.Page
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        List<Cart> cartList = new List<Cart>();
        

        // Still need to revise where to each part of the code
        public List<Cart> getAllCarts()
        {
            return (from Cart in db.Carts where Cart.CustomerID == (int)Session["User"] select Cart).ToList();
        }

        protected void refreshTable()
        {
            List<CartItem> cartItems = new List<CartItem>();
            cartList = getAllCarts();
            foreach (var item in cartList)
            {
                CartItem dataList = new CartItem { albumPicture = item.Album.AlbumImage, albumName = item.Album.AlbumName, albumPrice = item.Album.AlbumPrice, Quantity = item.Qty }
                cartItems.Add(dataList);
            }

            CartGridView.DataSource = cartItems;
            CartGridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
        }


        protected void CartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var item = cartList[e.RowIndex];
            var albumID = item.AlbumID;
            String id = (string)Session["User"];
            Cart toDelete = db.Carts.FirstOrDefault(c => c.CustomerID == (int)Session["User"] && c.AlbumID == albumID);

            db.Carts.Remove(toDelete);
            db.SaveChanges();
            refreshTable();
        }

        public static int RemoveAllItems(List<Cart> cartList)
        {
            db.Carts.RemoveRange(cartList);
            return db.SaveChanges();
        }

        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            TransactionController.CreateTransactionHeader(DateTime.Now, (int)Session["User"]);
            var lastID = db.TransactionHeaders.OrderByDescending(item => item.TransactionID).Select(item => item.TransactionID).FirstOrDefault();
            foreach(var item in cartList)
            {
                TransactionController.CreateTransactionDetail(lastID, item.AlbumID, item.Qty);
            }

            RemoveAllItems(cartList);
            db.SaveChanges();
        }
    }
}