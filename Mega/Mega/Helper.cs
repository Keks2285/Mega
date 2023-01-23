using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mega
{
    public class Helper
    {
        public static RestClient client = new RestClient("http://192.168.1.49:8080/MegaApi/"); //192.168.1.49 192.168.182.74
        public static bool CheckPostName(string postName)
        {
            foreach (char a in postName)
            {
                if (!Regex.IsMatch(a.ToString(), @"[а-яА-Я ]") && a != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool CheckFIO(string fio)
        {
            foreach (char a in fio)
            {
                if (!Regex.IsMatch(a.ToString(), @"[а-яА-Я]") && (int)a != 65279)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool onlyDightsCheck (string inn)
        {
            foreach (char a in inn)
            {
                if (!Regex.IsMatch(a.ToString(), @"[0-9]"))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }

    }
}
