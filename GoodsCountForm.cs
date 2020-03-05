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
    public partial class GoodsCountForm : MDIForm
    {
        public GoodsCountForm()
        {
            InitializeComponent();
            EffectiveTimeCBox.SelectedIndex = 0;
            FlashForm();
        }

        public void FlashForm(string Key = null)
        {
            List<TGoodsCount> goodsCounts = MDIQuery.GetGoodsCount(EffectiveTimeCBox.Text, Key);
            MDIAction.SetGoodsCountGridView(dataGridView1, goodsCounts);
            //MDIAction.AutoSetDGVCol(dataGridView1);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            FlashForm(selectTxt.Text.Trim());
        }

        private void EffectiveTimeCBox_TextChanged(object sender, EventArgs e)
        {
            FlashForm(selectTxt.Text.Trim());
        }

        private void outPutBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("库存管理表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }
    }
}
