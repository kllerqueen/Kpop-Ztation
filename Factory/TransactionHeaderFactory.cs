using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHeader history = new TransactionHeader();
            history.TransactionDate = transactionDate;
            history.CustomerID = customerId;

            return history;
        }
    }
}