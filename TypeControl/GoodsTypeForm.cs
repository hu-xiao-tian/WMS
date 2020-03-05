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
    
    public partial class GoodsTypeForm : TypeControlForm
    {
        GoodsTemplateForm goodsTemplateForm;
        GoodsForm goodsForm;
        ModelHandlerA.ModelHandler<TGoodsType> modelHandler = new ModelHandlerA.ModelHandler<TGoodsType>();
        public GoodsTypeForm()
        {
            InitializeComponent();
        }
        public GoodsTypeForm(GoodsTemplateForm goodsTemplateForm)
        {
            InitializeComponent();
            this.goodsTemplateForm = goodsTemplateForm;
        }
        public GoodsTypeForm(GoodsForm goodsForm)
        {
            InitializeComponent();
            this.goodsForm = goodsForm;
        }
        private void GoodsTypeForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }

        private void FlashForm()
        {
            List<TGoodsType> goodsTypes = TypeControlQuery.GetGoodsTypes();
            TypeControlAction.SetClientTypeDataGridView(dataGridView1, goodsTypes);
            TypeControlAction.InitGoodsTypeTree(treeView, goodsTypes);
            if (goodsTemplateForm != null)
            {
                goodsTemplateForm.FlashForm();
            }
            if (goodsForm != null)
            {
                goodsForm.FlashForm();
            }
        }

        public override void delTypeBtn_Click(object sender, EventArgs e)
        {
            DelBtnClick();
        }

        private void DelBtnClick()
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            List<TGoodsType> goodsTypes = TypeControlAction.DataRowToGoodsType(dataRows);
            if (MDIAction.CheckIsAllowDelGoodsType(goodsTypes))
            {
                int rows = TypeControlQuery.DeleteGoodsTypeInfo(goodsTypes);
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
            TGoodsType goodsType = TypeControlAction.SetGoodsType(typeNameTxt.Text, typeRankTxt.Text);
            if (goodsType != null)
            {
                bool result = TypeControlQuery.InsertGoodsTypeInfo(goodsType);
                MessageBox.Show(result ? "插入成功" : "插入失败");
                FlashForm();
            }
        }
        public override void alterBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idLab.Text);
            TGoodsType goodsType = TypeControlAction.SetGoodsType(typeNameTxt.Text, typeRankTxt.Text, id);
            bool result = TypeControlQuery.UpdateGoodsTypeInfo(goodsType);
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
                TGoodsType goodsType = modelHandler.FillModel(dr);
                if (idLab.Text == goodsType.AutoId.ToString() || alterBtn.Visible == false)
                {
                    TypeControlAction.ChangeTypeBtnClick(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, alterBtn, saveBtn, insertBtn);
                }
                typeNameTxt.Text = goodsType.Name;
                typeRankTxt.Text = goodsType.RankNum.ToString();
                idLab.Text = goodsType.AutoId.ToString();
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            TypeControlAction.UpdateDataGridViewRankValue(dataGridView1);
            DataTable dt = MDIAction.DataGridViewToDataTable(dataGridView1);
            List<TGoodsType> goodsTypes = modelHandler.FillModel(dt);
            bool result = TypeControlQuery.UpdateGoodsTypesInfo(goodsTypes);
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
