using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class CartController
    {
        public static void CreateCart(int customerId, int albumId, int qty)
        {
            CartHandler.CreateCart(customerId, albumId, qty);
            return;
        }
    }
}