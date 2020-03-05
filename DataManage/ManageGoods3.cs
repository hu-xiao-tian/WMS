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
    public partial class ManageGoods3 : ManageGoods1
    {
        public ManageGoods3()
        {
            InitializeComponent();
        }
        public ManageGoods3(DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                DataRow dr = (dataGridView.Rows[index].DataBoundItem as DataRowView).Row;
                this.goods = modelHandler.FillModel(dr);
                FillText(goods);
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
            TGoods goods = FillGoods();
            if (goods != null)
            {
                result = MDIQuery.AlterGoods(goods);
                MessageBox.Show(result ? "修改成功" : "修改失败");
                FlashForm();
                if (pictureBox.Image != null)
                {
                    result = IOStream.SaveImage(imagePath, pictureBox.Image, goods.ImageName);
                }
                MessageBox.Show(result ? "图片保存成功" : "图片保存失败");
            }
        }
    }
}
