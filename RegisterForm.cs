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
    public partial class RegisterForm : Form
    {
        LoginUser user = new LoginUser();
        int regeditCode = 1000000;
        DateTime codeSendTime = DateTime.Now;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void sendEmailCode_Click(object sender, EventArgs e)
        {
            if (!RegexCheck.EmailCheck(emailTxt.Text.Trim()))
            {
                emailLab.Text = "邮箱格式错误";
            }
            else if (Login.EmailExists(emailTxt.Text.Trim())>0)
            {
                emailLab.Text = "该邮箱已注册，请直接登入";
            }
            else if (DateTime.Now > codeSendTime)
            {
                regeditCode = new Random(Guid.NewGuid().GetHashCode()).Next(100000, 999999);
                if (Email.SentMailHXD(emailTxt.Text.Trim(), regeditCode.ToString(), "注册验证码"))
                {
                    user.UserEmail = emailTxt.Text.Trim();
                    emailLab.Text = "";
                    codeSendTime = DateTime.Now.AddSeconds(60);
                }
            }
            else
            {
                int waitSeconds = (codeSendTime- DateTime.Now).Seconds;
                codeLab.Text = $"每次发送验证码后要等待1分钟，剩余时间{waitSeconds}";
            }
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (emailCodeTxt.Text.Trim().Equals(regeditCode.ToString())
                && emailTxt.Text.Trim().Equals(user.UserEmail))
            {
                if (Login.RegisterCheck(user))
                {
                    MessageBox.Show(Login.RegisterUser(user)?"注册成功":"失败");
                }
            }
            else
            {
                MessageBox.Show("验证码错误");
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (!RegexCheck.EmailCheck(emailTxt.Text.Trim()))
            {
                emailLab.Text = "邮箱格式错误";
            }
            else if (Login.EmailExists(emailTxt.Text.Trim()) > 0)
            {
                emailLab.Text = "该邮箱已注册，请直接登入";
            }
            else if(!emailTxt.Text.Trim().Equals(user.UserEmail))
            {
                emailLab.Text = "检测到当前邮件地址未获取验证码";
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            emailLab.Text = "";
        }

        private void userNameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTxt.Text.Trim())|| userNameTxt.Text.Trim().Length<6)
            {
                userNameLab.Text = "用户名不可为空，且长度必须占6个字符及以上";
                user.UserName = "";
            }
            else if (Login.UserNameCheck(userNameTxt.Text.Trim()) != 0)
            {
                userNameLab.Text = "当前用户名已被注册";
                user.UserName = "";
            }
            else
            {
                userNameLab.Text = "当前用户名可以使用";
                user.UserName = userNameTxt.Text.Trim();
            }
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

        private void userNicknameTxt_TextChanged(object sender, EventArgs e)
        {
            user.UserNickname = userNicknameTxt.Text;
        }

        private void userTelTxt_TextChanged(object sender, EventArgs e)
        {
            if (RegexCheck.TelCheck(userTelTxt.Text.Trim()))
            {
                user.UserTel = userTelTxt.Text.Trim();
                userTelLab.Text = "";
            }
            else
            {
                user.UserTel = "";
                userTelLab.Text = "电话号码格式错误";

            }
        }
    }
}
