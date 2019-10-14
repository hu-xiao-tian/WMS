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
using System.Runtime.InteropServices;

namespace 仓库管理系统
{
    public partial class WMSMainForm : Form
    {
        LoginUser loginUser = new LoginUser();
        DrawTabControl drawTabControl ;
        public WMSMainForm(LoginUser loginUser)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            mainTabControl.Hide();
            this.loginUser = loginUser;
            ShowWelcome(this.loginUser);
            drawTabControl = new DrawTabControl(mainTabControl, this.Font);
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

        //[DllImport("User32.dll")]
        //public static extern int SetParent(int hWndChild, int hWndNewParent);
        private void 操作员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIForm f1 = new MDIForm();
            drawTabControl.Add_TabPage("操作员设置", f1);
            //MDIForm mdiForm = new MDIForm();
            //mdiForm.MdiParent = this;
            //this.workPanel.Controls.Add(mdiForm);
            //SetParent((int)mdiForm.Handle, (int)workPanel.Handle);
            //mdiForm.Show();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIForm f2 = new MDIForm();
            drawTabControl.Add_TabPage("测试", f2);
        }
    }
}
