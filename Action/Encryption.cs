using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    class Encryption
    {
        public static string GetMd5Str(string str)
        {
            StringBuilder sb = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
