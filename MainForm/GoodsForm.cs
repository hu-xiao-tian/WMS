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
    public partial class GoodsForm : MDIForm
    {
        ImageShowForm imageShowForm;
        ModelHandlerA.ModelHandler<TGoods> modelHandler = new ModelHandlerA.ModelHandler<TGoods>();
        public GoodsForm()
        {
            InitializeComponent();
        }
       
        private void GoodsForm_Load(object sender, EventArgs e)
        {
            FlashForm();
        }
        public void FlashForm()
        {
            MDIAction.SetGoodsDataGridView(dataGridView1, MDIQuery.GetGoods());
            //MDIAction.AutoSetDGVCol(dataGridView1);
            List<TGoodsType> goodsTypes = TypeControlQuery.GetGoodsTypes();
            TypeControlAction.InitGoodsTypeTree(treeView, goodsTypes);
        }

        private void sidebarTSBtn_Click(object sender, EventArgs e)
        {
            MDIAction.LeftSidebarControl(panel3, sidebarTSBtn);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MDIAction.SetGoodsDataGridView(dataGridView1, MDIQuery.GetGoods(e.Node.Name));
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            List<TGoods> goods = MDIQuery.GetGoodsByName(selectTxt.Text.Trim());
            MDIAction.SetGoodsDataGridView(dataGridView1, goods);
        }

        private void imageTSBtn_Click(object sender, EventArgs e)
        {
            if (imageShowForm == null || imageShowForm.IsDisposed)
            {
                DataRow dr = MDIAction.GetGridViewCheckedMinRow(dataGridView1);
                if (dr != null)
                {
                    TGoods goods = modelHandler.FillModel(dr);
                    MDIAction.InitImageShowForm(this, ref imageShowForm, goods.ImageName);
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
                TGoods goods = modelHandler.FillModel(dr);
                if (imageShowForm != null && !imageShowForm.IsDisposed)
                {
                    imageShowForm.Close();
                    MDIAction.InitImageShowForm(this, ref imageShowForm, goods.ImageName);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            GoodsTypeForm goodsTypeForm = new GoodsTypeForm(this);
            goodsTypeForm.ShowDialog();
        }

        private void outputTSBtn_Click(object sender, EventArgs e)
        {
            string savePath = MDIAction.SetExcelSaveUrl("商品库存表格导出");
            if (!string.IsNullOrEmpty(savePath))
            {
                bool result = MDIAction.GridViewToExcel(savePath, dataGridView1);
                MessageBox.Show(result ? "导出成功" : "导出失败");
            }
        }

        private void inWarehouseTSBtn_Click(object sender, EventArgs e)
        {
            ManageGoods1 manageGoods1 = new ManageGoods1(dataGridView1, treeView);
            manageGoods1.ShowDialog();
        }
        private void alterTSBtn_Click(object sender, EventArgs e)
        {
            ManageGoods3 manageGoods3 = new ManageGoods3(dataGridView1, treeView);
            manageGoods3.ShowDialog();
        }
        private void inputTSBtn_Click(object sender, EventArgs e)
        {
            string openPath = MDIAction.SetExcelOpenUrl("商品表格导入");
            if (!string.IsNullOrEmpty(openPath))
            {
                List<TGoods> goodsTemplates = MDIAction.ExcelToGoodsOBJ(openPath);
                InputFormAction.InputGoods(goodsTemplates, this, dataGridView1, treeView);
            }
        }

        private void outWarehouseTSBtn_Click(object sender, EventArgs e)
        {
            ManageGoods2 manageGoods2 = new ManageGoods2(dataGridView1);
            manageGoods2.ShowDialog();
        }

        
    }
}
