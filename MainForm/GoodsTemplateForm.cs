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
    public partial class GoodsTemplateForm : MDIForm
    {
        ImageShowForm imageShowForm;
        ModelHandlerA.ModelHandler<TGoodsTemplate> modelHandler = new ModelHandlerA.ModelHandler<TGoodsTemplate>();
        public delegate void TransmitDelegate(TGoodsTemplate goodsTemplate);
        public GoodsTemplateForm()
        {
            InitializeComponent();
        }

        private void GoodsTemplateForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }
        public void FlashForm()
        {
            MDIAction.SetGoodsTemplateDataGridView(dataGridView1, MDIQuery.GetGoodsTemplate());
            MDIAction.AutoSetDGVCol(dataGridView1);
            List<TGoodsType> goodsTypes = TypeControlQuery.GetGoodsTypes();
            TypeControlAction.InitGoodsTypeTree(treeView, goodsTypes);
        }

        private void sidebarTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.LeftSidebarControl(panel3, sidebarTSBtn);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MDIAction.SetGoodsTemplateDataGridView(dataGridView1, MDIQuery.GetGoodsTemplate(e.Node.Name));
        }

        private void selectTSBtn_Click(object sender, EventArgs e)
        {
            List <TGoodsTemplate> goodsTemplates = MDIQuery.GetGoodsTemplateByName(selectTSTxt.Text.Trim());
            MDIAction.SetGoodsTemplateDataGridView(dataGridView1, goodsTemplates);
        }

        private void outputTSBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("商品模板表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            GoodsTypeForm goodsTypeForm = new GoodsTypeForm(this);
            goodsTypeForm.ShowDialog();
        }

        private void delTSBtn_Click(object sender, EventArgs e)
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            if (dataRows.Count > 0)
            {
                List<TGoodsTemplate> goodsTemplates = MDIAction.DataRowToGoodsTemplate(dataRows);
                int rows = MDIQuery.DeleteGoodsTemplateInfo(goodsTemplates);
                MessageBox.Show($"成功删除{rows}行");
                FlashForm();
            }
            else
            {
                MessageBox.Show("请选择要删除的对象");
            }
        }
        
        private void imageTSBtn_Click(object sender, EventArgs e)
        {
            if (imageShowForm==null||imageShowForm.IsDisposed)
            {
                DataRow dr = MDIAction.GetGridViewCheckedMinRow(dataGridView1);
                if (dr != null)
                {
                    TGoodsTemplate goodsTemplate = modelHandler.FillModel(dr);
                    MDIAction.InitImageShowForm(this, ref imageShowForm, goodsTemplate.ImageName);
                }
            }
            else
            {
                imageShowForm.Close();
            }
            
        }

        public override void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = MDIAction.GetGridViewCheckedMinRow(dataGridView1);
            if (dr != null)
            {
                TGoodsTemplate goodsTemplate = modelHandler.FillModel(dr);
                if (imageShowForm != null&& !imageShowForm.IsDisposed)
                {
                    imageShowForm.Close();
                    MDIAction.InitImageShowForm(this, ref imageShowForm, goodsTemplate.ImageName);
                }
            }
            
        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            ManageGoodsTemplate1 manageGoodsTemplate1 = new ManageGoodsTemplate1(dataGridView1,treeView);
            manageGoodsTemplate1.ShowDialog();
        }

        private void alterTSBtn_Click(object sender, EventArgs e)
        {
            ManageGoodsTemplate2 manageGoodsTemplate2 = new ManageGoodsTemplate2(dataGridView1, treeView);
            manageGoodsTemplate2.ShowDialog();
        }

        private void inputTSBtn_Click(object sender, EventArgs e)
        {
            string openPath = MDIAction.SetExcelOpenUrl("商品模板表格导入");
            if (!string.IsNullOrEmpty(openPath))
            {
                List<TGoodsTemplate> goodsTemplates = MDIAction.ExcelToGoodsTemplateOBJ(openPath);
                InputFormAction.InputGoodsTemplate(goodsTemplates, this, dataGridView1, treeView);
            }
        }

        public event TransmitDelegate TransmitEvent;
        public override void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            DataRow dr = MDIAction.GetGridViewCheckedMinRow(dataGridView1);
            if (dr != null&& TransmitEvent!=null)
            {
                TGoodsTemplate goodsTemplate = modelHandler.FillModel(dr);
                TransmitEvent(goodsTemplate);
                this.Close();
            }
        }
    }
}
