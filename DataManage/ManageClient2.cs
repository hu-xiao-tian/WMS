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
    public partial class ManageClient2 : ManageClient1
    {
        public ManageClient2()
        {
            InitializeComponent();
        }
        public ManageClient2(DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataRow dr = (dataGridView.Rows[index].DataBoundItem as DataRowView).Row;
                this.client = modelHandler.FillModel(dr);
                FillText(client);
                InitializeComponent();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            AlterClientInfo();
        }
        public override void saveCloseBtn_Click(object sender, EventArgs e)
        {
            AlterClientInfo();
            Close();
        }
        private void AlterClientInfo()
        {
            bool result = false;
            TClient client = SetClient(this.client);
            if (client != null)
            {
                result = ObjCheck.CheckClient(client);
            }
            if (result)
            {
                result = MDIQuery.AlterClientInfo(client);
                MessageBox.Show(result ? "修改成功" : "修改失败");
                FlashForm();
            }
        }
    }
}
