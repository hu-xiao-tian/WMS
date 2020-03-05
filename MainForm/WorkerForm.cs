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
    public partial class WorkerForm : MDIForm
    {
        public WorkerForm()
        {
            InitializeComponent();
            MDIAction.InitUserTree(treeView1);
            

        }
        public WorkerForm(TLoginUser loginUser) : base(loginUser)
        {
            InitializeComponent();
            MDIAction.InitUserTree(treeView1);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.GetUserInfo(e.Node.Name));
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.GetUserInfo());
        }

        private void delTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TLoginUser> loginUsers = MDIAction.DataRowToLoginUser(dataRows);
            loginUsers = MDIQuery.GetUserInfo(loginUsers);
            MDIAction.AlterUserLV(loginUsers,loginUser,0);
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.GetUserInfo());
        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TLoginUser> loginUsers = MDIAction.DataRowToLoginUser(dataRows);
            loginUsers = MDIQuery.GetUserInfo(loginUsers);
            MDIAction.AlterUserLV(loginUsers, loginUser, 1);
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.GetUserInfo());
        }

        private void subTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TLoginUser> loginUsers = MDIAction.DataRowToLoginUser(dataRows);
            loginUsers = MDIQuery.GetUserInfo(loginUsers);
            MDIAction.AlterUserLV(loginUsers, loginUser, -1);
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.GetUserInfo());
        }

        private void sidebarTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.LeftSidebarControl(panel3, sidebarTSBtn);
        }

        private void selectTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.SetLoginUserDataGridView(dataGridView1, MDIQuery.SelectUserInfo(selectTSTxt.Text.Trim()));
        }
    }
}
