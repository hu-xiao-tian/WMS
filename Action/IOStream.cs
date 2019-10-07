using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    class IOStream
    {
        public static void WriteErrorLog(string path,string info)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(info);
            if (File.Exists(path))
            {
                File.AppendAllText(path, sb.ToString());
            }
            else
            {
                File.Create(path);
                File.AppendAllText(path, sb.ToString());
            }
        }
        
    }
}
