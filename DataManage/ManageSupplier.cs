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
    public partial class ManageSupplier : Form
    {
        DataGridView dataGridView = new DataGridView();
        TreeView treeView = new TreeView();
        ModelHandlerA.ModelHandler<TSupplier> modelHandler = new ModelHandlerA.ModelHandler<TSupplier>();
        int index = 0;
        public ManageSupplier()
        {
            InitializeComponent();
        }
        public ManageSupplier(DataGridView dataGridView,TreeView treeView)
        {
            this.dataGridView = dataGridView;
            this.treeView = treeView;
            this.index = MDIAction.GetGridViewCheckedIndexs(dataGridView).Min();
            InitializeComponent();
        }

        private void companyNameTxt_TextChanged(object sender, EventArgs e)
        {
            pinyinCodeTxt.Text = PinyinHelper.GetPinyin(companyNameTxt.Text,false);
        }

        private void typeIdTxt_TextChanged(object sender, EventArgs e)
        {
            TSupplierType supplierType = TypeControlQuery.GetSupplierTypesById(typeIdTxt.Text);
            if (supplierType != null)
            {
                typeNameTxt.Text = supplierType.Name;
            }
            else
            {
                typeNameTxt.Text = string.Empty;
            }
        }
        

        private void typeNameTxt_TextChanged(object sender, EventArgs e)
        {
            TSupplierType supplierType = TypeControlQuery.GetSupplierTypesByName(typeNameTxt.Text);
            if (supplierType != null)
            {
                typeIdTxt.Text = supplierType.AutoId.ToString();
            }
            else
            {
                typeIdTxt.Text = string.Empty;
            }
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {
            SaveSupplierInfo();
        }

        private void SaveSupplierInfo()
        {
            bool result = false;
            TSupplier supplier = SetSupplier();
            if (supplier != null)
            {
                result = ObjCheck.CheckSupplier(supplier);
            }
            if (result)
            {
                result = MDIQuery.InsertSupplierInfo(supplier);
                MessageBox.Show(result ? "新增成功" : "新增失败");
                FlashForm();
            }
        }

        private TSupplier SetSupplier()
        {
            TSupplier supplier = new TSupplier();
            if (!string.IsNullOrEmpty(companyNameTxt.Text)&& !string.IsNullOrEmpty(pinyinCodeTxt.Text))
            {
                supplier.CompanyName = companyNameTxt.Text.Trim();
                supplier.PinyinCode = pinyinCodeTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("供应商名称和拼音码不可为空");
                return null;
            }
            supplier.ContactName = contactNameTxt.Text.Trim();
            supplier.Area = areaTxt.Text.Trim();
            if (!string.IsNullOrEmpty(addressTxt.Text))
            {
                supplier.Address = addressTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("地址不可为空");
                return null;
            }
            
            supplier.WebSite = webSideTxt.Text.Trim();
            if (!string.IsNullOrEmpty(telTxt.Text)&& !string.IsNullOrEmpty(emailTxt.Text))
            {
                supplier.Tel = telTxt.Text.Trim();
                supplier.Email = emailTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("电话和邮箱不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(typeIdTxt.Text))
            {
                supplier.TypeId = Convert.ToInt32(typeIdTxt.Text.Trim());
            }
            else
            {
                MessageBox.Show("商品类型id不可为空");
                return null;
            }
            if (string.IsNullOrEmpty(typeNameTxt.Text.Trim()))
            {
                MessageBox.Show("类型不存在");
                return null;
            }
            if (!string.IsNullOrEmpty(rankNumTxt.Text))
            {
                supplier.RankNum = Convert.ToInt32(rankNumTxt.Text.Trim());
            }
            else
            {
                supplier.RankNum = MDIQuery.GetMaxRankNum("Supplier");
            }
            return supplier;
        }
        private void FlashForm()
        {
            MDIAction.SetSupplierDataGridView(dataGridView, MDIQuery.GetSuppliers());
            MDIAction.AutoSetDGVCol(dataGridView);
            List<TSupplierType> supplierTypes = TypeControlQuery.GetSupplierTypes();
            TypeControlAction.InitSupplierTypeTree(treeView, supplierTypes);
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                DataRow dr = (dataGridView.Rows[--index].DataBoundItem as DataRowView).Row;
                TSupplier supplier = modelHandler.FillModel(dr);
                FillText(supplier);
            }
            else
            {
                MessageBox.Show("已是第一条记录");
            }
        }

        private void FillText(TSupplier supplier)
        {
            companyNameTxt.Text = supplier.CompanyName;
            pinyinCodeTxt.Text = supplier.PinyinCode;
            contactNameTxt.Text = supplier.ContactName;
            areaTxt.Text = supplier.Area;
            addressTxt.Text = supplier.Address;
            webSideTxt.Text = supplier.WebSite;
            telTxt.Text = supplier.Tel;
            emailTxt.Text = supplier.Email;
            typeIdTxt.Text = supplier.TypeId.ToString();
            typeNameTxt.Text = supplier.TypeName;
            rankNumTxt.Text = supplier.RankNum.ToString();
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (index < dataGridView.RowCount-1)
            {
                DataRow dr = (dataGridView.Rows[++index].DataBoundItem as DataRowView).Row;
                TSupplier supplier = modelHandler.FillModel(dr);
                FillText(supplier);
            }
            else
            {
                MessageBox.Show("已是最后条记录");
            }
        }

        private void saveCloseBtn_Click(object sender, EventArgs e)
        {
            SaveSupplierInfo();
            Close();
        }
    }
}
