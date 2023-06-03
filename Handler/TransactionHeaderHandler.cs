using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class TransactionHeaderHandler
    {
        public static void CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHeader history = TransactionHeaderFactory.CreateTransactionHeader(transactionDate, customerId);

            TransactionHeaderRepository.CreateTransactionHeader(history);
            return;
        }
    }
}