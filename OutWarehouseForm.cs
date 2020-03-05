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
    public partial class OutWarehouseForm : MDIForm
    {
        public OutWarehouseForm()
        {
            InitializeComponent();
            startDTP.Value = DateTime.Now.AddMonths(-6);
            endDTP.Value = DateTime.Now;
            FlashForm();
        }
        public void FlashForm(string Key = null)
        {
            List<TOutWarehouse> outWarehouses = MDIQuery.GetOutWarehouse(startDTP.Value, endDTP.Value, Key);
            MDIAction.SetOutWarehouseGridView(dataGridView1, outWarehouses);
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

        private void outPutBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("出库记录表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            FlashForm(selectTxt.Text.Trim());
        }
    }
}
