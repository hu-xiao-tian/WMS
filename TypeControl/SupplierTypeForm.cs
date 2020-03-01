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
    public partial class SupplierTypeForm : TypeControlForm
    {
        private SupplierForm supplierForm;
        ModelHandlerA.ModelHandler<TSupplierType> modelHandler = new ModelHandlerA.ModelHandler<TSupplierType>();
        public SupplierTypeForm()
        {
            InitializeComponent();
        }

        public SupplierTypeForm(SupplierForm supplierForm)
        {
            InitializeComponent();
            this.supplierForm = supplierForm;
        }

        private void SupplierTypeForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }

        private void FlashForm()
        {
            List<TSupplierType> supplierTypes = TypeControlQuery.GetSupplierTypes();
            TypeControlAction.SetSupplierTypeDataGridView(dataGridView1, supplierTypes);
            TypeControlAction.InitSupplierTypeTree(treeView, supplierTypes);
            if (supplierForm != null)
            {
                supplierForm.FlashForm();
            }
        }

        public override void delTypeBtn_Click(object sender, EventArgs e)
        {
            DelBtnClick();
        }

        private void DelBtnClick()
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TSupplierType> supplierTypes = TypeControlAction.DataRowToSupplierType(dataRows);
            int rows = TypeControlQuery.DeleteSupplierTypeInfo(supplierTypes);
            MessageBox.Show($"成功删除{rows}行");
            TypeControlAction.HideLabTxtBtn(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, insertBtn, alterBtn);
            saveBtn.Visible = true;
            FlashForm();
        }

        public override void insertBtn_Click(object sender, EventArgs e)
        {
            TSupplierType supplierType= TypeControlAction.SetSupplierType(typeNameTxt.Text, typeRankTxt.Text);
            if (supplierType != null)
            {
                bool result=TypeControlQuery.InsertSupplierTypeInfo(supplierType);
                MessageBox.Show(result ? "插入成功" : "插入失败");
                FlashForm();
            }
        }

        public override void alterBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idLab.Text);
            TSupplierType supplierType = TypeControlAction.SetSupplierType(typeNameTxt.Text, typeRankTxt.Text, id);
            bool result=TypeControlQuery.UpdateSupplierTypeInfo(supplierType);
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
                
                
                TSupplierType supplierType = modelHandler.FillModel(dr);
                if(idLab.Text== supplierType.AutoId.ToString()|| alterBtn.Visible==false)
                {
                    TypeControlAction.ChangeTypeBtnClick(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, alterBtn, saveBtn, insertBtn);
                }
                typeNameTxt.Text = supplierType.Name;
                typeRankTxt.Text = supplierType.RankNum.ToString();
                idLab.Text = supplierType.AutoId.ToString();
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            TypeControlAction.UpdateDataGridViewRankValue(dataGridView1);
            DataTable dt = MDIAction.DataGridViewToDataTable(dataGridView1);
            List<TSupplierType> supplierTypes = modelHandler.FillModel(dt);
            bool result = TypeControlQuery.UpdateSupplierTypesInfo(supplierTypes);
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
