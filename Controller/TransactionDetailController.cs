using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class TransactionDetailController
    {
        public static void CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            CartHandler.CreateCart(transactionId, albumId, qty);
            return;
        }
    }
}