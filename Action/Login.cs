using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Dapper;
using System.Text.RegularExpressions;
using System.IO;

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

        public static int EmailLoginCheck(LoginUser user)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select count(*) from LoginUser Where UserEmail=@UserEmail and UserPassword=@UserPassword";
                return conn.ExecuteScalar<int>(sql, user);
            }
        }
        public static int UserNameCheck(string userName)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select count(*) from LoginUser Where UserName=@UserName";
                return conn.ExecuteScalar<int>(sql, new { UserName=userName });
            }
        }

        public static bool RegisterCheck(LoginUser user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                MessageBox.Show("请更正用户名");
                return false;
            }
            else if (string.IsNullOrEmpty(user.UserPassword))
            {
                MessageBox.Show("请更正密码");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool AlterPasswordCheck(LoginUser user)
        {
            if (string.IsNullOrEmpty(user.UserEmail))
            {
                MessageBox.Show("请更正邮箱");
                return false;
            }
            else if (string.IsNullOrEmpty(user.UserPassword))
            {
                MessageBox.Show("请更正密码");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int EmailExists(string email)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select count(*) from LoginUser Where UserEmail=@UserEmail";
                return conn.ExecuteScalar<int>(sql, new { UserEmail = email });
            }
        }

        public static bool RegisterUser(LoginUser user)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "insert into LoginUser(UserName, UserPassword, UserEmail,UserNickname) Values(@UserName, @UserPassword, @UserEmail,@UserNickname)";
                    conn.Execute(sql,user);
                    return true;
                }
            }catch(Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("RegisterError.txt", info);
                return false;
            }
            
        }

        public static bool AlterPassword(LoginUser user)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "update LoginUser set UserPassword=@UserPassword where UserEmail=@UserEmail";
                    conn.Execute(sql, user);
                    return true;
                }
            }catch(Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("AlterPasswordError.txt", info);
                return false;
            }
            
        }
    }
}
