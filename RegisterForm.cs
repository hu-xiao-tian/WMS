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
        int regeditCode = 0000;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void sendEmailCode_Click(object sender, EventArgs e)
        {
            regeditCode = new Random(Guid.NewGuid().GetHashCode()).Next(100000, 999999);
            Email.SentMailHXD(textBox1.Text.Trim(), regeditCode.ToString(), "注册验证码");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(regeditCode.ToString()))
            {
                MessageBox.Show("验证成功");
            }
            else
            {
                MessageBox.Show("验证码错误");
            }
        }
    }
}
