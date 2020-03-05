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
    public partial class ClientForm : MDIForm
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }
        public void FlashForm()
        {
            MDIAction.SetClientDataGridView(dataGridView1, MDIQuery.GetClients());
            MDIAction.AutoSetDGVCol(dataGridView1);
            List<TClientType> clientTypes = TypeControlQuery.GetClientTypes();
            TypeControlAction.InitClientTypeTree(treeView, clientTypes);
        }
        private void sidebarTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.LeftSidebarControl(panel3, sidebarTSBtn);
        }
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MDIAction.SetClientDataGridView(dataGridView1, MDIQuery.GetClients(e.Node.Name));
        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            ManageClient1 manageClient1 = new ManageClient1(dataGridView1, treeView);
            manageClient1.ShowDialog();
        }
        private void alterTSBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ManageClient2 manageClient2 = new ManageClient2(dataGridView1, treeView);
                manageClient2.ShowDialog();
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
                List<TClient> clients = MDIAction.DataRowToClient(dataRows);
                int rows = MDIQuery.DeleteClientInfo(clients);
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
            string savePath = MDIAction.SetExcelSaveUrl("客户表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            List<TClient> clients = MDIQuery.GetClientByName(selectTxt.Text.Trim());
            MDIAction.SetClientDataGridView(dataGridView1, clients);
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            ClientTypeForm clientTypeForm = new ClientTypeForm(this);
            clientTypeForm.ShowDialog();
        }
        private void inputTSBtn_Click(object sender, EventArgs e)
        {
            string openPath = MDIAction.SetExcelOpenUrl("客户表格导入");
            if (!string.IsNullOrEmpty(openPath))
            {
                List<TClient> clients = MDIAction.ExcelToClientOBJ(openPath);
                InputFormAction.InputClient(clients, this, dataGridView1, treeView);
            }
        }
    }
}
