using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace 仓库管理系统
{
    class Login
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;
        public static void Test()
        {
            string s = conStr;
            using (var conn = new SqlConnection(conStr))
            {
                MessageBox.Show("sql链接成功");
            }
        }
    }
}
