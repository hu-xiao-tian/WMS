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

        private void 公司信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo companyInfo = new CompanyInfo(loginUser);
            companyInfo.ShowDialog();
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
            supplierTypeForm.ShowDialog();
        }
        
        private void 客户类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTypeForm clientTypeForm = new ClientTypeForm();
            clientTypeForm.ShowDialog();
        }

        private void 客户资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            drawTabControl.Add_TabPage("客户资料", clientForm);
        }

        private void 商品类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsTypeForm goodsTypeForm = new GoodsTypeForm();
            goodsTypeForm.ShowDialog();
        }

        private void 商品资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            drawTabControl.Add_TabPage("商品资料", goodsForm);
        }

        private void 商品库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsCountForm goodsCountForm = new GoodsCountForm();
            drawTabControl.Add_TabPage("商品库存", goodsCountForm);
        }

        private void 商品模板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsTemplateForm goodsTemplateForm = new GoodsTemplateForm();
            drawTabControl.Add_TabPage("商品模板", goodsTemplateForm);
        }

        private void 入库检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InWarehouseForm inWarehouseForm = new InWarehouseForm();
            drawTabControl.Add_TabPage("入库检查", inWarehouseForm);
        }

        private void 出库检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutWarehouseForm outWarehouseForm = new OutWarehouseForm();
            drawTabControl.Add_TabPage("出库检查", outWarehouseForm);
        }

        private void 库存检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WStatisticsForm statisticsForm = new WStatisticsForm();
            drawTabControl.Add_TabPage("统计报表", statisticsForm);
        }

        private void 商品资料TSB_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            drawTabControl.Add_TabPage("商品资料", goodsForm);
        }

        private void 客户资料TSB_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            drawTabControl.Add_TabPage("客户资料", clientForm);
        }

        private void 供应商资料TSB_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            drawTabControl.Add_TabPage("供应商资料", supplierForm);
        }

        private void 仓库资料TSB_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm(loginUser);
            drawTabControl.Add_TabPage("仓库设置", warehouseForm);
        }

        private void 商品库存TSB_Click(object sender, EventArgs e)
        {
            GoodsCountForm goodsCountForm = new GoodsCountForm();
            drawTabControl.Add_TabPage("商品库存", goodsCountForm);
        }

        private void 统计报表TSB_Click(object sender, EventArgs e)
        {
            WStatisticsForm statisticsForm = new WStatisticsForm();
            drawTabControl.Add_TabPage("统计报表", statisticsForm);
        }

        private void WMSMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
