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
    public partial class InWarehouseForm : MDIForm
    {
        public InWarehouseForm()
        {
            InitializeComponent();
            startDTP.Value = DateTime.Now.AddMonths(-6);
            endDTP.Value = DateTime.Now;
            FlashForm();
        }
        public void FlashForm(string Key=null)
        {
            List<TInWarehouse> inWarehouses = MDIQuery.GetInWarehouse(startDTP.Value, endDTP.Value, Key);
            MDIAction.SetInWarehouseGridView(dataGridView1, inWarehouses);
            //MDIAction.AutoSetDGVCol(dataGridView1);
        }

        private void startDTP_ValueChanged(object sender, EventArgs e)
        {
            FlashForm();
        }

        private void endDTP_ValueChanged(object sender, EventArgs e)
        {
            FlashForm();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            FlashForm(selectTxt.Text.Trim());
        }

        private void outPutBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("入库记录表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }
    }
}
