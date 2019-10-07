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
        int regeditCode = 1000000;
        string userEmail = "";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void sendEmailCode_Click(object sender, EventArgs e)
        {
            regeditCode = new Random(Guid.NewGuid().GetHashCode()).Next(100000, 999999);
            Email.SentMailHXD(emailTxt.Text.Trim(), regeditCode.ToString(), "注册验证码");
            userEmail = emailTxt.Text.Trim();
            label1.Text = "";
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(regeditCode.ToString())
                &&emailTxt.Text.Trim().Equals(userEmail))
            {
                MessageBox.Show("验证成功");
            }
            else
            {
                MessageBox.Show("验证码错误");
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (!emailTxt.Text.Trim().Equals(userEmail))
            {
                label1.Text = "检测到当前邮件地址未获取验证码";
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
