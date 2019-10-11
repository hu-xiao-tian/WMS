using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace 仓库管理系统
{
    class MainForm
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;

        public static LoginUser GetUserInfo(LoginUser loginUser)
        {
            using(var conn = new SqlConnection(conStr))
            {
                string sql = @"select top 1 * from LoginUser(nolock) 
                where  UserName=@UserName
                Or  UserEmail=@UserEmail
                Or UserTel=@UserTel";
                return conn.QueryFirst<LoginUser>(sql, loginUser);
            }
        }

        public static string GetLvInfo(int userLv)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select top 1 [LvInstructions] from LvInfo(nolock) where UserLv=@UserLv";
                return conn.QueryFirst<string>(sql, new { UserLv=userLv });
            }
        }

        internal static Image GetPortraitImage(string userPortraitUrl)
        {
            throw new NotImplementedException();
        }
    }
}
