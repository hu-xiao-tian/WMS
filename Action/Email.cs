using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    class Email
    {
        /// <summary>
        /// 发送邮件,成功返回true,否则false
        /// </summary>
        /// <param name="to">收件人</param>
        /// <param name="body">内容</param>
        /// <param name="title">标题</param>
        /// <param name="whichEmail">是否join</param>
        /// <param name="path">附件</param>
        /// <param name="Fname">姓名</param>
        /// <returns>结果</returns>
        public static bool SentMailHXD(string to, string body, string title, string whichEmail="", string path="", string Fname="星尘。")
        {
            bool retrunBool = false;
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            string strFromEmail = "603269609@qq.com";//你的邮箱
            string strEmailPassword = "ylcfljuommizbdfb";//QQPOP3/SMTP服务码
            try
            {
                mail.From = new MailAddress("" + Fname + "<" + strFromEmail + ">");
                mail.To.Add(new MailAddress(to));
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Priority = MailPriority.Normal;
                mail.Body = body;
                mail.Subject = title;
                smtp.Host = "smtp.qq.com";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential(strFromEmail, strEmailPassword);
                //发送邮件
                smtp.Send(mail);   //同步发送
                retrunBool = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"邮件发送异常：{ex}");
                retrunBool = false;
            }
            // smtp.SendAsync(mail, mail.To); //异步发送 （异步发送时页面上要加上Async="true" ）
            return retrunBool;
        }
    }
}
