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
using System.Threading;

namespace 仓库管理系统
{
    class Login
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;


        public static void CheckSendEmail(DateTime codeSendTime,Button sendEmailCode)
        {

            var multi = new MultiThreadWork();
            multi.DoMultiWork((btn) => {
                while (true)
                {
                    int waitTime = (codeSendTime - DateTime.Now).Seconds;
                    if (waitTime > 0)
                    {
                        btn.Text = $"等待：{waitTime}";
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.Text = "发送";
                        btn.Enabled = true;
                    }
                    Thread.Sleep(1000);
                }
            }, sendEmailCode);
        }
        public static int LoginCheck(LoginUser user)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select count(*) from LoginUser(nolock) 
                Where (UserName=@UserName and UserPassword=@UserPassword)
                Or  (UserEmail=@UserEmail and UserPassword=@UserPassword)
                Or (UserTel=@UserTel and UserPassword=@UserPassword)";
                return conn.ExecuteScalar<int>(sql,user);
            }
        }

        public static int UserNameCheck(string userName)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select count(*) from LoginUser(nolock) Where UserName=@UserName";
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
            else if (string.IsNullOrEmpty(user.UserTel))
            {
                MessageBox.Show("请更正电话");
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
                string sql = "select count(*) from LoginUser(nolock) Where UserEmail=@UserEmail";
                return conn.ExecuteScalar<int>(sql, new { UserEmail = email });
            }
        }

        public static bool RegisterUser(LoginUser user)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "insert into LoginUser(UserName, UserPassword, UserEmail,UserNickname,UserTel) Values(@UserName, @UserPassword, @UserEmail,@UserNickname,@UserTel)";
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

        public static LoginUser GetUserInfo(LoginUser loginUser)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select top 1 * from LoginUser(nolock) 
                where  UserName=@UserName
                Or  UserEmail=@UserEmail
                Or UserTel=@UserTel";
                return conn.QueryFirst<LoginUser>(sql, loginUser);
            }
        }
    }
}
