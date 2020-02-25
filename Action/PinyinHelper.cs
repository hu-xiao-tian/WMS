using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    class PinyinHelper
    {
        /// <summary>
        /// 取得中文字符串的拼音
        /// </summary>
        /// <param name="str">传入的中文字符串</param>
        /// <param name="isAllUpper">是否全大写，false时只有首字母大写</param>
        /// <returns></returns>
        public static string GetPinyin(string str, bool isAllUpper = true)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    if (isAllUpper)
                    {
                        r += t.Substring(0, t.Length - 1);
                    }
                    else
                    {
                        string s1 = t.Substring(0, 1);
                        string s2 = t.Substring(1, t.Length - 1);
                        r += t.Substring(0, 1) + t.Substring(1, t.Length - 2).ToLower();
                    }
                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }
        /// <summary>
        /// 取得中文字符串的首个拼音
        /// </summary>
        /// <param name="str">传入的中文字符串</param>
        /// <param name="isUpper">是否大写，默认大写</param>
        /// <returns></returns>
        public static string GetFirstPinyin(string str, bool isUpper = true)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    if (isUpper)
                    {
                        r += t.Substring(0, 1);
                    }
                    else
                    {
                        r += t.Substring(0, 1).ToLower();
                    }

                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }
    }
}
