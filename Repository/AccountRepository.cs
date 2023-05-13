using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class AccountRepository
    {
        static KpopZtationDatabaseEntities db = new KpopZtationDatabaseEntities();

        public static void CreateAccount(Customer User)
        {
            db.Customers.Add(User);
            db.SaveChanges();
            return;
        }
    }
}