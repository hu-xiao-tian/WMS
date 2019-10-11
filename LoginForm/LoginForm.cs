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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginUser user = new LoginUser();
            
            user.UserName = userNameTxt.Text;
            user.UserPassword = Encryption.GetMd5Str(userPasswordTxt.Text);
            user.UserEmail = userNameTxt.Text;
            if(string.IsNullOrEmpty(userNameTxt.Text)
                || string.IsNullOrEmpty(userPasswordTxt.Text)){
                MessageBox.Show("用户名或密码不可为空");
            }
            else if (Login.LoginCheck(user) >0)
            {
                MessageBox.Show("登录成功");
                WMSMainForm mainForm = new WMSMainForm(user);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
        
        private void losePWLab_Click(object sender, EventArgs e)
        {
            FindPasswordForm findPasswordForm = new FindPasswordForm();
            findPasswordForm.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
