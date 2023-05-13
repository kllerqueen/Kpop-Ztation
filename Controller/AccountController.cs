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
            if(Functions.CheckEmpty(Name, Email, Password, Gender, Address))
            {
                return "Please fill all fields";
            }

            else if(Functions.CheckName(Name) || Functions.CheckEmail(Email) || Gender.Equals("") || Functions.CheckAddress(Address) || Functions.CheckPassword(Password))
            {
                return "Invalid input";
            }
            AccountHandler.CreateAccount(Name, Email, Password, Gender, Address);
            return "Success!";
        }

        //public static String Login(String Email, String Password)
        //{

        //}
    }
}