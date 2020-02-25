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
    public partial class TypeControlForm : Form
    {
        public TypeControlForm()
        {
            InitializeComponent();
            idLab.Visible = false;
            TypeControlAction.HideLabTxtBtn(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, insertBtn,alterBtn);
            TypeControlAction.SetPanelBothSize(Width, leftPanel);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            TypeControlAction.SetPanelBothSize(Width, leftPanel);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TypeControlAction.CallTreeViewRightMenu(e, treeView, treeCMStrip);
            }
            TypeControlAction.TreeViewLinkDataGridView(e.Node.Name, dataGridView1);
        }


        public virtual void addTypeBtn_Click(object sender, EventArgs e)
        {
            TypeControlAction.ChangeTypeBtnClick(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt,insertBtn,saveBtn,alterBtn);
            
        }

        public virtual void alterTypeBtn_Click(object sender, EventArgs e)
        {
        }

        public virtual void delTypeBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void insertBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void alterBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }
        public DataGridViewTextBoxEditingControl CellEdit = null;
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                //Control是单元格选中是向用户显示的控件
                //转化为TextBox控件
                CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                //选中文本框中所有文本
                CellEdit.SelectAll();
                CellEdit.KeyPress += RegexCheck.CheckCellIsInteger; //绑定事件
            }
            
        }

        public virtual void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public virtual void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public virtual void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public virtual void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
