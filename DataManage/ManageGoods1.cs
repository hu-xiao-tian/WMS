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
    public partial class ManageGoods1 : Form
    {
        public DataGridView dataGridView = new DataGridView();
        public TreeView treeView = new TreeView();
        public int index = 0;
        public string imagePath = @"Date/Image/Goods/";
        public ModelHandlerA.ModelHandler<TGoods> modelHandler = new ModelHandlerA.ModelHandler<TGoods>();
        public TGoods goods = new TGoods();
        public TInWarehouse inWarehouse = new TInWarehouse();
        public ManageGoods1()
        {
            InitializeComponent();
            producedDateDTP.Value = DateTime.Now;
            inTypecomboBox.SelectedIndex = 0;
            //MDIAction.InitWIdComboBox(wIdComboBox);
        }
        public ManageGoods1(DataGridView dataGridView, TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            List<int> indexs = MDIAction.GetGridViewCheckedIndexs(dataGridView);
            if (indexs.Count > 0)
            {
                this.index = indexs.Min();
            }
            InitializeComponent();
            InitControl();
        }
        public ManageGoods1(TGoods goods,DataGridView dataGridView, TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            InitializeComponent();
            upBtn.Enabled = false;
            downBtn.Enabled = false;
            saveBtn.Enabled = false;
            this.goods = goods;
            FillText(goods);
            InitControl();
        }

        public void InitControl()
        {
            producedDateDTP.Value = DateTime.Now;
            inTypecomboBox.SelectedIndex = 0;
            MDIAction.InitWIdComboBox(wIdComboBox);
            effectiveTimeTxt.KeyPress += RegexCheck.CheckCellIsInteger;
            inCountTxt.KeyPress += RegexCheck.CheckCellIsInteger;
            inPriceTxt.KeyPress += RegexCheck.CheckCellIsFloat;
            outPriceTxt.KeyPress += RegexCheck.CheckCellIsFloat;
        }

        private void inputForTemplateLab_Click(object sender, EventArgs e)
        {
            GoodsTemplateForm goodsTemplateForm = new GoodsTemplateForm();
            goodsTemplateForm.TransmitEvent += FillTemplateText;
            goodsTemplateForm.ShowDialog();
        }
        private void FillTemplateText(TGoodsTemplate goodsTemplate)
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

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = IOStream.OpenImage();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string imgName = goods.ImageName;
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
                goods = modelHandler.FillModel(dr);
                FillText(goods);
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
                goods = modelHandler.FillModel(dr);
                FillText(goods);
            }
            else
            {
                MessageBox.Show("已是最后条记录");
            }
        }
        public void FillText(TGoods goods)
        {
            goodsNameTxt.Text = goods.Name;
            pinyinCodeTxt.Text = goods.PinyinCode;
            barCodeTxt.Text = goods.BarCode;
            tIdTxt.Text = goods.TId.ToString();
            tNameTxt.Text = goods.TName;
            sIdTxt.Text = goods.SId.ToString();
            sNameTxt.Text = goods.SName;
            descriptionTxt.Text = goods.Description;
            pictureBox.ImageLocation = $"{imagePath}{goods.ImageName}";
            inPriceTxt.Text = goods.InPrice.ToString();
            outPriceTxt.Text = goods.OutPrice.ToString();
            producedDateDTP.Value= DateTime.ParseExact(goods.ProducedDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            effectiveTimeTxt.Text = goods.EffectiveTime.ToString();
            wIdComboBox.Text = goods.WId;
            descriptionTxt.Text = goods.Description;
        }
        public void FlashForm()
        {
            MDIAction.SetGoodsDataGridView(dataGridView, MDIQuery.GetGoods());
            //MDIAction.AutoSetDGVCol(dataGridView);
            List<TGoodsType> goodsTypes = TypeControlQuery.GetGoodsTypes();
            TypeControlAction.InitGoodsTypeTree(treeView, goodsTypes);
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
        public TGoods FillGoods()
        {
            if (!string.IsNullOrEmpty(goodsNameTxt.Text) && !string.IsNullOrEmpty(pinyinCodeTxt.Text))
            {
                goods.Name = goodsNameTxt.Text;
                goods.PinyinCode = pinyinCodeTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("商品名称和拼音码不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(barCodeTxt.Text))
            {
                goods.BarCode = barCodeTxt.Text;
            }
            else
            {
                MessageBox.Show("条形码不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(tIdTxt.Text))
            {
                goods.TId = Convert.ToInt32(tIdTxt.Text.Trim());
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
            goods.TName = tNameTxt.Text.Trim();
            if (!string.IsNullOrEmpty(sIdTxt.Text))
            {
                goods.SId = Convert.ToInt32(sIdTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("供货商id不可为空");
                return null;
            }
            if (string.IsNullOrEmpty(sNameTxt.Text.Trim()))
            {
                MessageBox.Show("供货商不存在");
                return null;
            }
            goods.SName = sNameTxt.Text.Trim();
            if (pictureBox.Image != null)
            {
                goods.ImageName = $"{goods.Name}.jpg";
            }
            else
            {
                goods.ImageName = "";
            }
            if (!string.IsNullOrEmpty(inPriceTxt.Text)&& inPriceTxt.Text.Split('.').Count() < 3)
            {
                goods.InPrice = Convert.ToDouble(inPriceTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("购入价格不可为空或格式错误");
                return null;
            }
            if (!string.IsNullOrEmpty(outPriceTxt.Text.Trim()))
            {
                if (outPriceTxt.Text.Split('.').Count() < 3)
                {
                    goods.OutPrice = Convert.ToDouble(outPriceTxt.Text.Trim());
                }
                else
                {
                    MessageBox.Show("预售价格式输入错误");
                    return null;
                }
            }
            goods.ProducedDate=producedDateDTP.Value.ToString("yyyyMMdd");
            if (!string.IsNullOrEmpty(effectiveTimeTxt.Text))
            {
                goods.EffectiveTime = Convert.ToInt32(effectiveTimeTxt.Text.Trim());
            }
            if (string.IsNullOrEmpty(inCountTxt.Text))
            {
                MessageBox.Show("请输入入库数量");
                return null;
            }
            goods.WId = wIdComboBox.Text;
            goods.Description = descriptionTxt.Text;
            return goods;
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {
            SaveGoodsInfo();
        }

        private void SaveGoodsInfo()
        {
            bool result = false;
            TGoods goods = FillGoods();
            if (goods != null)
            {
                int count = Convert.ToInt32(inCountTxt.Text.Trim());
                MultiThreadWork multi = new MultiThreadWork(10);
                multi.DoMultiWork((c) =>
                {
                    for (int i = 0; i < c; i++)
                    {
                        result = MDIQuery.InsertGoodsInfo(goods);
                    }
                }, count);
                multi.WaitingFinish();
                MessageBox.Show(result ? "新增成功" : "新增失败");
                FlashForm();
                if (pictureBox.Image != null)
                {
                    result = IOStream.SaveImage(imagePath, pictureBox.Image, goods.ImageName);
                }
                MessageBox.Show(result ? "图片保存成功" : "图片保存失败");
                FillInWarehouse();
                MDIQuery.InsertInWarehouseInfo(inWarehouse);
            }
        }

        private void FillInWarehouse()
        {
            inWarehouse.Name = goods.Name;
            inWarehouse.PinyinCode = goods.PinyinCode;
            inWarehouse.BarCode = goods.BarCode;
            inWarehouse.ProducedDate = goods.ProducedDate;
            inWarehouse.SName = goods.SName;
            inWarehouse.TName = goods.TName;
            inWarehouse.WId = goods.WId;
            inWarehouse.InPrice = goods.InPrice;
            inWarehouse.InType = inTypecomboBox.Text;
            inWarehouse.InCount = Convert.ToInt32(inCountTxt.Text);
        }

        public virtual void saveCloseBtn_Click(object sender, EventArgs e)
        {
            SaveGoodsInfo();
            Close();
        }
    }
}
