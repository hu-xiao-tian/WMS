using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Regex regex = new Regex("^1[34578]\\d{9}$");
            if (regex.IsMatch(tel))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FixTelCheck(string tel)
        {
            if (tel.Length < 16)
            {
                Regex regex = new Regex(@"^0\d{2,3}-\d{7,8}|\(?0\d{2,3}[)-]?\d{7,8}|\(?0\d{2,3}[)-]*\d{7,8}$");
                if (regex.IsMatch(tel))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        public static bool IsInterger(string str)
        {
            if (str == "")
            {
                return false;
            }
            else
            {
                foreach (char c in str)
                {
                    if (char.IsNumber(c))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        public static void CheckCellIsInteger(object sender, KeyPressEventArgs e)
        {
            //运用了正则表达式进行验证
            //需加命名空间using System.Text.RegularExpressions;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }

    }
}
