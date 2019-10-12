using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class WMSMainForm : Form
    {
        LoginUser loginUser = new LoginUser();
        public WMSMainForm(LoginUser loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
            ShowWelcome(this.loginUser);
        }

        private void ShowWelcome(LoginUser loginUser)
        {
            lvLab.Text = "欢迎回来：" + MainForm.GetLvInfo(loginUser.UserLV);
            userIdLab.Text = "工号：" + loginUser.AutoId.ToString();
            nicknameLab.Text = "昵称：" + loginUser.UserNickname;
            var multi = new MultiThreadWork();
            multi.DoMultiWork((user) => {
                portraitPictureBox.Image = MainForm.GetPortraitImage(user.UserPortraitUrl);
            }, loginUser);
        }

    }
}
