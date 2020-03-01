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
    public partial class ManageSupplier2 : ManageSupplier1
    {
        public ManageSupplier2()
        {
            InitializeComponent();
        }
        public ManageSupplier2(DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataRow dr = (dataGridView.Rows[index].DataBoundItem as DataRowView).Row;
                this.supplier = modelHandler.FillModel(dr);
                FillText(supplier);
                InitializeComponent();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            AlterSupplierInfo();
        }
        public override void saveCloseBtn_Click(object sender, EventArgs e)
        {
            AlterSupplierInfo();
            Close();
        }
        private void AlterSupplierInfo()
        {
            bool result = false;
            TSupplier supplier = SetSupplier(this.supplier);
            if (supplier != null)
            {
                result = ObjCheck.CheckSupplier(supplier);
            }
            if (result)
            {
                result = MDIQuery.AlterSupplierInfo(supplier);
                MessageBox.Show(result ? "修改成功" : "修改失败");
                FlashForm();
            }
        }
    }
}
