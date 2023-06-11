using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class TransactionDetailHandler
    {
        public static void CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionDetail history = TransactionDetailFactory.CreateTransactionDetail(transactionId, albumId, qty);

            TransactionDetailRepository.CreateTransactionDetail(history);
            return;
        }
    }
}