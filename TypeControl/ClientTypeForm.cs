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
    public partial class ClientTypeForm : TypeControlForm
    {
        private ClientForm clientForm;
        ModelHandlerA.ModelHandler<TClientType> modelHandler = new ModelHandlerA.ModelHandler<TClientType>();
        public ClientTypeForm()
        {
            InitializeComponent();
        }

        public ClientTypeForm(ClientForm clientForm)
        {
            InitializeComponent();
            this.clientForm = clientForm;
        }

        private void ClientTypeForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }
        private void FlashForm()
        {
            List<TClientType> clientTypes = TypeControlQuery.GetClientTypes();
            TypeControlAction.SetClientTypeDataGridView(dataGridView1, clientTypes);
            TypeControlAction.InitClientTypeTree(treeView, clientTypes);
            if (clientForm != null)
            {
                clientForm.FlashForm();
            }
        }

        public override void delTypeBtn_Click(object sender, EventArgs e)
        {
            DelBtnClick();
        }

        private void DelBtnClick()
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TClientType> clientTypes = TypeControlAction.DataRowToClientType(dataRows);
            if (MDIAction.CheckIsAllowDelClientType(clientTypes))
            {
                int rows = TypeControlQuery.DeleteClientTypeInfo(clientTypes);
                MessageBox.Show($"成功删除{rows}行");
                TypeControlAction.HideLabTxtBtn(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, insertBtn, alterBtn);
                saveBtn.Visible = true;
                FlashForm();
            }
            else
            {
                MessageBox.Show("选中类型仍有关联不可删除");
            }

        }

        public override void insertBtn_Click(object sender, EventArgs e)
        {
            TClientType clientType = TypeControlAction.SetClientType(typeNameTxt.Text, typeRankTxt.Text);
            if (clientType != null)
            {
                bool result = TypeControlQuery.InsertClientTypeInfo(clientType);
                MessageBox.Show(result ? "插入成功" : "插入失败");
                FlashForm();
            }
        }

        public override void alterBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idLab.Text);
            TClientType clientType = TypeControlAction.SetClientType(typeNameTxt.Text, typeRankTxt.Text, id);
            bool result = TypeControlQuery.UpdateClientTypeInfo(clientType);
            MessageBox.Show(result ? "更新成功" : "更新失败");
            FlashForm();
        }
        public override void alterTypeBtn_Click(object sender, EventArgs e)
        {
            AlterBtnClick();
        }

        private void AlterBtnClick()
        {
            DataRow dr = MDIAction.GetGridViewCheckedMinRow(dataGridView1);
            if (dr != null)
            {
                TClientType clientType = modelHandler.FillModel(dr);
                if (idLab.Text == clientType.AutoId.ToString() || alterBtn.Visible == false)
                {
                    TypeControlAction.ChangeTypeBtnClick(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, alterBtn, saveBtn, insertBtn);
                }
                typeNameTxt.Text = clientType.Name;
                typeRankTxt.Text = clientType.RankNum.ToString();
                idLab.Text = clientType.AutoId.ToString();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            TypeControlAction.UpdateDataGridViewRankValue(dataGridView1);
            DataTable dt = MDIAction.DataGridViewToDataTable(dataGridView1);
            List<TClientType> clientTypes = modelHandler.FillModel(dt);
            bool result = TypeControlQuery.UpdateClientTypesInfo(clientTypes);
            MessageBox.Show(result ? "更新成功" : "更新失败");
            FlashForm();
        }

        public override void addTypeBtn_Click(object sender, EventArgs e)
        {
            AddBtnClikc();
        }
        private void AddBtnClikc()
        {
            TypeControlAction.ChangeTypeBtnClick(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, insertBtn, saveBtn, alterBtn);
        }
        public override void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBtnClikc();
        }

        public override void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterBtnClick();
        }

        public override void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelBtnClick();
        }
        public override void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (alterBtn.Visible == true)
            {
                AlterBtnClick();
            }
        }
    }
}
