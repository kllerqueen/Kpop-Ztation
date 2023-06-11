using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class TransactionController
    {
        public static void CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHandler.CreateTransactionHeader(transactionDate, customerId);
            return;
        }

        public static void CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionHandler.CreateTransactionDetail(transactionId, albumId, qty);
            return;
        }
    }
}