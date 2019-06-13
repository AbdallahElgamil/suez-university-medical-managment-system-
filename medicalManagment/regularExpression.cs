using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Clinic
{
    class regularExpression
    {
        public bool checkId(string str)
        {
            Regex rgx = new Regex("^\\d+$");
            return rgx.IsMatch(str.ToString());

        }
        public bool checkName(string str)
        { 
            Regex rgx = new Regex("^[ _A-Za-zئؤيءأإلإلآلأآا-ى]+$");
            return rgx.IsMatch(str);

        }
        public bool checkString(string str)
        {
            Regex rgx = new Regex("^[0-9۱-۹ _ \\s A-Za-z ئؤيءأإلإلآلأآا-ى]+$");
            return rgx.IsMatch(str);

        }
        public bool checkemail(string str)
        {
            Regex rgx = new Regex(@"^$|^[a-zA-Z](\w+)*([-_.]\w+)*@\w+([-.]\w+)*\.[a-zA-Z]\w+([-.]\w+)*$");
            return rgx.IsMatch(str);

        }
        public bool checkphone(string str)
        {
            Regex rgx = new Regex(@"^\d{11}$");
            return rgx.IsMatch(str);

        }
        public bool checkBarCode(string str)
        {
            Regex rgx = new Regex(@"^\d{14}$");
            return rgx.IsMatch(str);

        }
        public bool checkage(string str)
        {
            Regex rgx = new Regex(@"^(\d{1}|\d{2}|\d{3})$");
            return rgx.IsMatch(str);

        }
    }
}
