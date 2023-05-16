using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class AccountRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateAccount(Customer User)
        {
            db.Customers.Add(User);
            db.SaveChanges();
            return;
        }

        public static Customer GetUser(string Email, string Password)
        {
            return (from u in db.Customers where Email.Equals(u.CustomerEmail) && Password.Equals(u.CustomerPassword) select u).FirstOrDefault();
        }
    }
}