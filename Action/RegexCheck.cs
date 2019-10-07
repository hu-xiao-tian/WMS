using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    class RegexCheck
    {
        public static bool EmailCheck(string email)
        {
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool TelCheck(string tel)
        {
            Regex regex = new Regex(@"^(\d{3.4}-)\d{7,8}$");
            if (regex.IsMatch(tel))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
