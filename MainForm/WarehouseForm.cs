using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    public partial class WarehouseForm:MDIForm
    {
        public WarehouseForm(TLoginUser loginUser):base(loginUser)
        {
            InitializeComponent();
            if (loginUser.UserLV<3)
            {
                addTSBtn.Enabled = false;
                alterTSBtn.Enabled = false;
                delTSBtn.Enabled = false;
            }
        }
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            ManageWarehouse manageWarehouse = new ManageWarehouse(loginUser,dataGridView1);
            manageWarehouse.ShowDialog();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            MDIAction.SetWarehouseDataGridView(dataGridView1, MDIQuery.GetWarehouseInfo());
        }

        private void alterTSBtn_Click(object sender, EventArgs e)
        {
            ManageWarehouse manageWarehouse = new ManageWarehouse(loginUser, dataGridView1,true);
            manageWarehouse.ShowDialog();
        }

        private void delTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows=MDIAction.GetGridViewCheckedRows(dataGridView1);
            if (dataRows.Count > 0)
            {
                List<TWarehouse> warehouses = MDIAction.DataRowToWarehouse(dataRows);
                if (MDIAction.CheckIsAllowDelWarehouses(warehouses))
                {
                    int rows = MDIQuery.DeleteWarehouseInfo(warehouses);
                    MessageBox.Show($"成功删除{rows}行");
                    MDIAction.SetWarehouseDataGridView(dataGridView1, MDIQuery.GetWarehouseInfo());
                }
                else
                {
                    MessageBox.Show("选中仓库仍有关联不可删除");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的对象");
            }

        }

        private void outputTSBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("仓库表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            List<TWarehouse> warehouses=MDIQuery.GetWarehouseByName(selectTxt.Text.Trim());
            MDIAction.SetWarehouseDataGridView(dataGridView1, warehouses);
            FilterCheckBox.Checked = false;
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterCheckBox.Checked == true)
            {
                MDIAction.FilterIsUse(dataGridView1);
            }
            else
            {
                List<TWarehouse> warehouses = MDIQuery.GetWarehouseByName(selectTxt.Text.Trim());
                MDIAction.SetWarehouseDataGridView(dataGridView1, warehouses);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string telStr = "无法直接修改id,若要修改id只能建新的再删除旧的。仓库修改权限只有主管以上才具备";
            MessageBox.Show(telStr);
        }
    }
}
