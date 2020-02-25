using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class ManageForm2 : Form
    {
        public DataGridView dataGridView = new DataGridView();
        public TreeView treeView = new TreeView();
        public int index = 0;
        public ManageForm2()
        {
            InitializeComponent();
        }
        public ManageForm2(DataGridView dataGridView, TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            this.index = MDIAction.GetGridViewCheckedIndexs(dataGridView).Min();
            InitializeComponent();
        }

        public virtual void companyNameTxt_TextChanged(object sender, EventArgs e)
        {
            pinyinCodeTxt.Text = PinyinHelper.GetPinyin(companyNameTxt.Text, false);
        }

        public virtual void typeIdTxt_TextChanged(object sender, EventArgs e)
        {
        }


        public virtual void typeNameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveCloseBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void upBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void downBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
