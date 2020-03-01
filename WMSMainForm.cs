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
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    public partial class WMSMainForm : Form
    {
        TLoginUser loginUser = new TLoginUser();
        DrawTabControl drawTabControl ;
        public WMSMainForm(TLoginUser loginUser)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            mainTabControl.Hide();
            this.loginUser = loginUser;
            ShowWelcome(this.loginUser);
            drawTabControl = new DrawTabControl(mainTabControl, this.Font);
        }

        private void ShowWelcome(TLoginUser loginUser)
        {
            lvLab.Text = "欢迎回来：" + MainForm.GetLvInfo(loginUser.UserLV);
            userIdLab.Text = "工号：" + loginUser.AutoId.ToString();
            nicknameLab.Text = "昵称：" + loginUser.UserNickname;
            DateTime loginTime = DateTime.Now;
            var multi = new MultiThreadWork();
            multi.DoMultiWork((user) => {
                portraitPictureBox.Image = MainForm.GetPortraitImage(user.UserPortraitUrl);
            }, loginUser);
            multi.DoMultiWork((time) => {
                while (true)
                {
                    TimeSpan onLineTimeRecord = DateTime.Now - time;
                    onLineTime.Text = "你已在线："+onLineTimeRecord.ToString(@"hh\:mm\:ss");
                    Thread.Sleep(1000);
                }
            }, loginTime);
        }

        //[DllImport("User32.dll")]
        //public static extern int SetParent(int hWndChild, int hWndNewParent);
        private void 操作员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm(loginUser);
            drawTabControl.Add_TabPage("操作员设置", workerForm);
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MDIForm f2 = new MDIForm(loginUser);
            //drawTabControl.Add_TabPage("测试", f2);
        }

        private void 公司信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo companyInfo = new CompanyInfo(loginUser);
            companyInfo.Show();
        }

        private void 仓库设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm(loginUser);
            drawTabControl.Add_TabPage("仓库设置", warehouseForm);
        }

        private void 供应商资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            drawTabControl.Add_TabPage("供应商资料", supplierForm);
        }

        private void 供应商类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierTypeForm supplierTypeForm = new SupplierTypeForm();
            supplierTypeForm.Show();
        }

        private void 客户资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            drawTabControl.Add_TabPage("客户资料", clientForm);
        }

        private void 客户类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTypeForm clientTypeForm = new ClientTypeForm();
            clientTypeForm.Show();
        }
    }
}
