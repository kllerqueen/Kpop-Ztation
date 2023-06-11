using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class TransactionHeaderController
    {
        public static void CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHeaderHandler.CreateTransactionHeader(transactionDate, customerId);
            return;
        }
    }
}