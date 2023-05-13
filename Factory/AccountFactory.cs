using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class AccountFactory
    {
        public static Customer CreateAccount(String Name, String Email, String Password, String Gender, String Address)
        {
            Customer User = new Customer();
            User.CustomerName = Name;
            User.CustomerEmail = Email;
            User.CustomerPassword = Password;
            User.CustomerGender = Gender;
            User.CustomerAddress = Address;

            return User;
        }
    }
}