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
        public static void CheckCellIsFloat(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }
        /// <summary>
        /// 文本非空限长检测
        /// </summary>
        /// <param name="text">要检查的文本</param>
        /// <param name="lenth">限制的长度</param>
        /// <param name="property">检查的属性名称</param>
        /// <returns>布尔</returns>
        public static bool TextCheck(string text, int lenth)
        {
            if (string.IsNullOrEmpty(text) || text.Length > lenth)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 文本限长检测
        /// </summary>
        /// <param name="text">要检查的文本</param>
        /// <param name="lenth">限制的长度</param>
        /// <returns>布尔</returns>
        public static bool TextLengthCheck(string text, int lenth)
        {
            if (text.Length > lenth)
            {
                return false;
            }
            return true;
        }

        public static bool IsFloat(string str)
        {
            string regextext = @"^\d+\.\d+$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str);
        }
    }
}
