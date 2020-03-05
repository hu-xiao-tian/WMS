using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    public partial class ManageGoodsTemplate1 : Form
    {
        public DataGridView dataGridView = new DataGridView();
        public TreeView treeView = new TreeView();
        public int index = 0;
        public string imagePath = @"Date/Image/GoodsTemplate/";
        public ModelHandlerA.ModelHandler<TGoodsTemplate> modelHandler = new ModelHandlerA.ModelHandler<TGoodsTemplate>();
        public TGoodsTemplate goodsTemplate = new TGoodsTemplate();
        public ManageGoodsTemplate1()
        {
            InitializeComponent();
        }
        public ManageGoodsTemplate1(DataGridView dataGridView, TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            List<int> indexs = MDIAction.GetGridViewCheckedIndexs(dataGridView);
            if (indexs.Count > 0)
            {
                this.index = indexs.Min();
            }
            InitializeComponent();
        }
        public ManageGoodsTemplate1(TGoodsTemplate goodsTemplate,DataGridView dataGridView, TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            InitializeComponent();
            upBtn.Enabled = false;
            downBtn.Enabled = false;
            saveBtn.Enabled = false;
            this.goodsTemplate = goodsTemplate;
            FillText(goodsTemplate);
        }
        private void ManageGoodsTemplate1_Load(object sender, EventArgs e)
        {

        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = IOStream.OpenImage();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string imgName = goodsTemplate.ImageName;
            string imgPath = $"{imagePath}{imgName}";
            if (pictureBox.Image != null && !File.Exists(imgPath))
            {
                pictureBox.ImageLocation = "";

            }
            else if (IOStream.DeleteFile(imgPath))
            {
                pictureBox.ImageLocation = "";
            }
        }

        private void goodsNameTxt_TextChanged(object sender, EventArgs e)
        {
            pinyinCodeTxt.Text = PinyinHelper.GetPinyin(goodsNameTxt.Text, false);
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                DataRow dr = (dataGridView.Rows[--index].DataBoundItem as DataRowView).Row;
                goodsTemplate = modelHandler.FillModel(dr);
                FillText(goodsTemplate);
            }
            else
            {
                MessageBox.Show("已是第一条记录");
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (index < dataGridView.RowCount - 1)
            {
                DataRow dr = (dataGridView.Rows[++index].DataBoundItem as DataRowView).Row;
                goodsTemplate = modelHandler.FillModel(dr);
                FillText(goodsTemplate);
            }
            else
            {
                MessageBox.Show("已是最后条记录");
            }
        }

        public void FillText(TGoodsTemplate goodsTemplate)
        {
            goodsNameTxt.Text = goodsTemplate.Name;
            pinyinCodeTxt.Text = goodsTemplate.PinyinCode;
            barCodeTxt.Text = goodsTemplate.BarCode;
            tIdTxt.Text = goodsTemplate.TId.ToString();
            tNameTxt.Text = goodsTemplate.TName;
            sIdTxt.Text = goodsTemplate.SId.ToString();
            sNameTxt.Text = goodsTemplate.SName;
            descriptionTxt.Text = goodsTemplate.Description;
            pictureBox.ImageLocation = $"{imagePath}{goodsTemplate.ImageName}";

        }

        private void tIdTxt_TextChanged(object sender, EventArgs e)
        {
            TGoodsType goodsType = TypeControlQuery.GetGoodsTypesById(tIdTxt.Text);
            if (goodsType != null)
            {
                tNameTxt.Text = goodsType.Name;
            }
            else
            {
                tNameTxt.Text = string.Empty;
            }
        }

        private void tNameTxt_TextChanged(object sender, EventArgs e)
        {
            TGoodsType goodsType = TypeControlQuery.GetGoodsTypesByName(tNameTxt.Text);
            if (goodsType != null)
            {
                tIdTxt.Text = goodsType.AutoId.ToString();
            }
            else
            {
                tIdTxt.Text = string.Empty;
            }
        }

        private void sIdTxt_TextChanged(object sender, EventArgs e)
        {
            TSupplier supplier = MDIQuery.GetSupplierById(sIdTxt.Text.Trim());
            if (supplier != null)
            {
                sNameTxt.Text = supplier.CompanyName;
            }
            else
            {
                sNameTxt.Text = string.Empty;
            }
        }

        private void sNameTxt_TextChanged(object sender, EventArgs e)
        {
            TSupplier supplier = MDIQuery.GetSupplierByCompanyName(sNameTxt.Text.Trim());
            if (supplier != null)
            {
                sIdTxt.Text = supplier.AutoId.ToString();
            }
            else
            {
                sIdTxt.Text = string.Empty;
            }
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {
            SaveGoodsTemplateInfo();
        }

        private void SaveGoodsTemplateInfo()
        {
            bool result = false;
            TGoodsTemplate goodsTemplate = FillGoodsTemplate();
            if (goodsTemplate != null)
            {
                result = MDIQuery.InsertGoodsTemplateInfo(goodsTemplate);
                MessageBox.Show(result ? "新增成功" : "新增失败");
                FlashForm();
                if (pictureBox.Image != null)
                {
                    result = IOStream.SaveImage(imagePath, pictureBox.Image, goodsTemplate.ImageName);
                }
                MessageBox.Show(result ? "图片保存成功" : "图片保存失败");
            }
        }

        public void FlashForm()
        {
            MDIAction.SetGoodsTemplateDataGridView(dataGridView, MDIQuery.GetGoodsTemplate());
            MDIAction.AutoSetDGVCol(dataGridView);
            List<TGoodsType> goodsTypes = TypeControlQuery.GetGoodsTypes();
            TypeControlAction.InitGoodsTypeTree(treeView, goodsTypes);
        }
        public TGoodsTemplate FillGoodsTemplate()
        {
            if (!string.IsNullOrEmpty(goodsNameTxt.Text) && !string.IsNullOrEmpty(pinyinCodeTxt.Text))
            {
                goodsTemplate.Name = goodsNameTxt.Text;
                goodsTemplate.PinyinCode = pinyinCodeTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("商品名称和拼音码不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(barCodeTxt.Text))
            {
                goodsTemplate.BarCode = barCodeTxt.Text;
            }
            else
            {
                MessageBox.Show("条形码不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(tIdTxt.Text))
            {
                goodsTemplate.TId = Convert.ToInt32(tIdTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("商品类型id不可为空");
                return null;
            }
            if (string.IsNullOrEmpty(tNameTxt.Text.Trim()))
            {
                MessageBox.Show("类型不存在");
                return null;
            }
            if (!string.IsNullOrEmpty(sIdTxt.Text))
            {
                goodsTemplate.SId = Convert.ToInt32(sIdTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("供货商id不可为空");
                return null;
            }
            if (string.IsNullOrEmpty(tNameTxt.Text.Trim()))
            {
                MessageBox.Show("供货商不存在");
                return null;
            }
            if (pictureBox.Image != null)
            {
                goodsTemplate.ImageName = $"{goodsTemplate.Name}.jpg";
            }
            else
            {
                goodsTemplate.ImageName = "";
            }
            goodsTemplate.Description = descriptionTxt.Text;
            return goodsTemplate;
        }

        public virtual void saveCloseBtn_Click(object sender, EventArgs e)
        {
            SaveGoodsTemplateInfo();
            Close();
        }
    }
}
