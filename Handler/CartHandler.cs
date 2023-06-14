using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class CartHandler
    {
        public static void CreateCart(int customerId, int albumId, int qty)
        {
            Cart newCart = CartFactory.CreateCart(customerId, albumId, qty);

            CartRepository.CreateCart(newCart);
            return;
        }

        public static void UpdateCart()
        {
            CartRepository.UpdateCart();
            return;
        }

        public static void RemoveAllItems(List<Cart> cartList, int userID)
        {
            cartList = CartRepository.getAllCarts(userID);
            CartRepository.RemoveAllItems(cartList);
            return;
        }

        public static List<Cart> getAllCarts(int userID)
        {
            List<Cart> allUserItems = CartRepository.getAllCarts(userID);
            return allUserItems;
        }

        public static int getLastTransactionID(int userID)
        {
            int lastTransactionID = CartRepository.getLastTransactionID(userID);
            return lastTransactionID;
        }

        public static Cart getCartDelete(int userID, int albumID)
        {
            Cart cartDelete = CartRepository.getCartDelete(userID, albumID);
            return cartDelete;
        }


    }
}