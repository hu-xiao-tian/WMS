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
            try
            {
                if (string.IsNullOrEmpty(userPortraitUrl))
                {
                    userPortraitUrl = "http://p1.qzone.la/upload/20150311/tsljdoeq.png";
                }
                Image userPortraitPicture = HttpAction.GetPicture(userPortraitUrl);
                return userPortraitPicture;
            }catch(Exception ex)
            {
                IOStream.WriteErrorLog("头像资源访问失败.txt", $"错误内容：{ex.ToString()}");
                return null;
            }
            
        }
    }
}
