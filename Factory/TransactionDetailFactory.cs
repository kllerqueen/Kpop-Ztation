using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionDetail history = new TransactionDetail();
            history.TransactionID = transactionId;
            history.AlbumID = albumId;
            history.Qty = qty;

            return history;
        }
    }
}