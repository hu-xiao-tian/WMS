using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Dapper;

namespace 仓库管理系统
{
    class Login
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;
        public static void Test()
        {
            using (var conn = new SqlConnection(conStr))
            {
                MessageBox.Show("sql链接成功");
                //xk-pc推送测试
            }
        }
        public static int LoginCheck(LoginUser user)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select count(*) from LoginUser Where UserName=@UserName and UserPassword=@UserPassword";
                return conn.ExecuteScalar<int>(sql,user);
            }
        }
    }
}
