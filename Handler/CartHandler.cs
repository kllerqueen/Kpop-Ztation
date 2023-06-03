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
    }
}