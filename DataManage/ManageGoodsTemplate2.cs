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
    public partial class ManageGoodsTemplate2 : ManageGoodsTemplate1
    {
        public ManageGoodsTemplate2()
        {
            InitializeComponent();
        }
        public ManageGoodsTemplate2(DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataRow dr = (dataGridView.Rows[index].DataBoundItem as DataRowView).Row;
                this.goodsTemplate = modelHandler.FillModel(dr);
                FillText(goodsTemplate);
                InitializeComponent();
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            AlterSupplierInfo();
        }
        public override void saveCloseBtn_Click(object sender, EventArgs e)
        {
            AlterSupplierInfo();
            Close();
        }
        private void AlterSupplierInfo()
        {
            bool result = false;
            TGoodsTemplate goodsTemplate = FillGoodsTemplate();
            if (goodsTemplate != null)
            {
                result = MDIQuery.AlterGoodsTemplateInfo(goodsTemplate);
                MessageBox.Show(result ? "修改成功" : "修改失败");
                FlashForm();
                if (pictureBox.Image != null)
                {
                    result = IOStream.SaveImage(imagePath, pictureBox.Image, goodsTemplate.ImageName);
                }
                MessageBox.Show(result ? "图片保存成功" : "图片保存失败");
            }
        }
    }
}
