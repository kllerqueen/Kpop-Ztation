using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;

namespace Kpop_Ztation.Controller
{
    public class Functions
    {
        public static bool CheckEmpty(String Text)
        {
            if(Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool CheckName(String Name)
        {
            if(Name.Length < 5 || Name.Length > 50)
            {
                return true;
            }
            return false;
        }

        public static bool CheckEmail(String Email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            Customer User = AccountRepository.GetEmail(Email);

            if(!(emailRegex.IsMatch(Email)) || User != null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckAddress(String Address)
        {
            if(!(Address.EndsWith("Street")))
            {
                return true;
            }
            return false;
        }

        public static bool CheckPassword(String Password)
        {
            if((Password.Any(Char.IsDigit)) && (Password.Any(Char.IsLetter)))
            {
                return false;
            }
            return true;
        }
    }
}