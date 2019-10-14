using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class FindPasswordForm : Form
    {
        LoginUser user = new LoginUser();
        int regeditCode = 1000000;
        DateTime codeSendTime = DateTime.Now;
        bool isRight = false;

        public FindPasswordForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (!RegexCheck.EmailCheck(emailTxt.Text.Trim()))
            {
                emailLab.Text = "邮箱格式错误";
            }
            else if (!(Login.EmailExists(emailTxt.Text.Trim()) > 0))
            {
                emailLab.Text = "该邮箱未注册，请检查";
            }
            else if (!emailTxt.Text.Trim().Equals(user.UserEmail))
            {
                emailLab.Text = "检测到当前邮件地址未获取验证码";
            }
            else
            {
                emailLab.Text = "";
            }
        }

        private void sendEmailCode_Click(object sender, EventArgs e)
        {
            if (!RegexCheck.EmailCheck(emailTxt.Text.Trim()))
            {
                emailLab.Text = "邮箱格式错误";
            }
            else if (!(Login.EmailExists(emailTxt.Text.Trim()) > 0))
            {
                emailLab.Text = "该邮箱未注册，请检查";
            }
            else if (DateTime.Now > codeSendTime)
            {
                regeditCode = new Random(Guid.NewGuid().GetHashCode()).Next(100000, 999999);
                if (Email.SentMailHXD(emailTxt.Text.Trim(), regeditCode.ToString(), "改密验证码"))
                {
                    user.UserEmail = emailTxt.Text.Trim();
                    emailLab.Text = "";
                    codeSendTime = DateTime.Now.AddSeconds(60);
                }
                Login.CheckSendEmail(codeSendTime, sendEmailCode);
            }
            //else
            //{
            //    int waitSeconds = (codeSendTime - DateTime.Now).Seconds;
            //    codeLab.Text = $"每次发送验证码后要等待1分钟，剩余时间{waitSeconds}";
            //}
        }

        private void userPWTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userPWTxt.Text.Trim()))
            {
                userPWLab.Text = "密码不可为空";
                user.UserPassword = "";
            }
            else if (userPWTxt.Text.Trim().Length > 6)
            {
                userPWLab.Text = "小贴士：密码尽量复杂，避免破解";
                user.UserPassword = Encryption.GetMd5Str(userPWTxt.Text.Trim());
            }
            else
            {
                userPWLab.Text = "密码长度必须大于6个字符";
                user.UserPassword = "";
            }
        }

        private void userPWTxt2_TextChanged(object sender, EventArgs e)
        {
            if (!userPWTxt.Text.Trim().Equals(userPWTxt2.Text.Trim()))
            {
                userPWLab2.Text = "两次密码不一致请检查";
                isRight = false;
            }
            else
            {
                userPWLab2.Text = "密码校验成功";
                isRight = true;
            }
        }

        private void alterPWBtn_Click(object sender, EventArgs e)
        {
            if (!isRight)
            {
                MessageBox.Show("两次密码不一致");
            }
            else if (emailCodeTxt.Text.Trim().Equals(regeditCode.ToString())
                && emailTxt.Text.Trim().Equals(user.UserEmail))
            {
                if (Login.AlterPasswordCheck(user))
                {
                    MessageBox.Show(Login.AlterPassword(user) ? "改密成功" : "失败");
                }
            }
            else
            {
                MessageBox.Show("验证码错误");
            }
        }
    }
}
