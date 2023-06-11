using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class TransactionRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateTransactionHeader(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return;
        }

        public static void UpdateTransactionHeader(TransactionHeader th)
        {
            db.SaveChanges();
            return;
        }

        public static void CreateTransactionDetail(TransactionDetail td)
        {
            db.TransactionDetails.Add(td);
            db.SaveChanges();
            return;
        }

        public static void UpdateTransactionDetail(TransactionDetail td)
        {
            db.SaveChanges();
            return;
        }
    }
}