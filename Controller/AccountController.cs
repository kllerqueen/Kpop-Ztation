using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class AccountController
    {
        public static String CreateAccount(String Name, String Email, String Password, String Gender, String Address)
        {
            if(Functions.CheckEmpty(Name) || Functions.CheckEmpty(Email) || Functions.CheckEmpty(Password) || Functions.CheckEmpty(Gender) || Functions.CheckEmpty(Address))
            {
                return "Please fill all fields";
            }

            if(Functions.CheckName(Name) || Functions.CheckEmail(Email) || Gender.Equals("") || Functions.CheckAddress(Address) || Functions.CheckPassword(Password))
            {
                return "Invalid input";
            }
            AccountHandler.CreateAccount(Name, Email, Password, Gender, Address);
            return "Account Successfuly Created.";
        }

        public static bool Login(String Email, String Password)
        {
            if(Email.Equals("") || Password.Equals(""))
            {
                return false;
            }
            return true;
        }       
    }
}