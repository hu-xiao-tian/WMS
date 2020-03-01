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
using System.Threading;

namespace 仓库管理系统
{
    public partial class SupplierForm : MDIForm
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }
        public void FlashForm()
        {
            MDIAction.SetSupplierDataGridView(dataGridView1, MDIQuery.GetSuppliers());
            MDIAction.AutoSetDGVCol(dataGridView1);
            List<TSupplierType> supplierTypes = TypeControlQuery.GetSupplierTypes();
            TypeControlAction.InitSupplierTypeTree(treeView, supplierTypes);
        }

        private void sidebarTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.LeftSidebarControl(panel3, sidebarTSBtn);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MDIAction.SetSupplierDataGridView(dataGridView1, MDIQuery.GetSuppliers(e.Node.Name));
        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            ManageSupplier1 manageSupplier1 = new ManageSupplier1(dataGridView1, treeView);
            manageSupplier1.ShowDialog();
        }

        private void alterTSBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ManageSupplier2 manageSupplier2 = new ManageSupplier2(dataGridView1, treeView);
                manageSupplier2.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择修改对象");
            }
        }

        private void delTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            if (dataRows.Count > 0)
            {
                List<TSupplier> suppliers = MDIAction.DataRowToSupplier(dataRows);
                int rows = MDIQuery.DeleteSupplierInfo(suppliers);
                MessageBox.Show($"成功删除{rows}行");
                FlashForm();
            }
            else
            {
                MessageBox.Show("请选择要删除的对象");
            }

        }

        private void outputTSBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("供应商表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            List<TSupplier> suppliers = MDIQuery.GetSupplierByName(selectTxt.Text.Trim());
            MDIAction.SetSupplierDataGridView(dataGridView1, suppliers);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            SupplierTypeForm supplierTypeForm = new SupplierTypeForm(this);
            supplierTypeForm.ShowDialog();
        }
        private void inputTSBtn_Click(object sender, EventArgs e)
        {
            string openPath = MDIAction.SetExcelOpenUrl("供应商表格导入");
            if (!string.IsNullOrEmpty(openPath))
            {
                List<TSupplier> suppliers = MDIAction.ExcelToSupplierOBJ(openPath);
                InputFormAction.InputSupplier(suppliers,this,dataGridView1,treeView);
            }
        }
    }
}
