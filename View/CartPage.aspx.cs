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
        public String Picture { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int albumID { get; set; }
    }

    public partial class CartPage : System.Web.UI.Page
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        List<Cart> cartList = new List<Cart>();

        protected int getUserID()
        {
            String userID = Session["User"].ToString();
            int currUserID = int.Parse(userID);
            return currUserID;
        }

        protected void refreshTable()
        {
            List<CartItem> cartItems = new List<CartItem>();
            CartItem dataList = new CartItem();
            cartList = CartController.getAllCarts(getUserID());
            foreach (var item in cartList)
            {
                dataList = new CartItem{ Picture = item.Album.AlbumImage, Name = item.Album.AlbumName, Quantity = item.Qty, Price = item.Album.AlbumPrice * item.Qty, albumID = item.AlbumID };
                cartItems.Add(dataList);
            }

            //var albumIdColumn = CartGridView.Columns.Cast<DataControlField>().FirstOrDefault(column => column.HeaderText == "AlbumID");
            //if (albumIdColumn != null)
           // {
            //    albumIdColumn.Visible = false;
            //}

            CartGridView.DataSource = cartItems;
            CartGridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            } else if (!checkUserRole())
            {
                Response.Redirect("../View/Homepage.aspx");
            }
            refreshTable();
        }


        protected void CartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = CartGridView.Rows[e.RowIndex];
            String albumID = row.Cells[4].Text.ToString();
            //var item = cartList[e.RowIndex];
            //var albumID = item.AlbumID;
            Cart toDelete = CartController.getCartDelete(getUserID(), int.Parse(albumID));

            db.Carts.Remove(toDelete);
            CartController.UpdateCart();
            refreshTable();
        }

        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            if(cartList != null)
            {
                CartController.addTransactionHeader(DateTime.Now, getUserID());
                int lastID = CartController.getLastTransactionID(getUserID());
                foreach (var item in cartList)
                {
                    CartController.addTransactionDetail(lastID, item.AlbumID, item.Qty);
                }

                CartController.RemoveAllItems(cartList, getUserID());
                Response.Redirect("../View/Homepage.aspx");
            }
        }

        protected bool checkUserRole()
        {
            Customer data = AccountController.GetCustomer(getUserID());

            if (data.CustomerRole.Equals("User"))
            {
                return true;
            }
            return false;
        }
    }
}