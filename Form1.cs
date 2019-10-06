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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginUser user = new LoginUser();
            
            user.UserName = textBox1.Text;
            user.UserPassword = Encryption.GetMd5Str(textBox2.Text);
            if (Login.LoginCheck(user) >0)
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Encryption.GetMd5Str("55746039"));
        }
    }
}
