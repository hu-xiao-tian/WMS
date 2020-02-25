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
    public partial class ManageWarehouse : ManageForm
    {
        TWarehouse warehouse = new TWarehouse();
        TWarehouse warehouseBackUp = new TWarehouse();
        DataGridView dataGridView = new DataGridView();
        bool isAlter;//做判断窗体是否是修改打开的
        public ManageWarehouse(TLoginUser loginUser, DataGridView dataGridView,bool isAlter=false) : base(loginUser)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.isAlter = isAlter;
            saveAlterBtn.Enabled = false;
            if (isAlter)
            {
                saveAlterBtn.Enabled = true;
                DataRow dr= MDIAction.GetGridViewCheckedMinRow(dataGridView);
                ModelHandlerA.ModelHandler<TWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TWarehouse>();
                warehouse = modelHandler.FillModel(dr);
                warehouseBackUp = warehouse;
                FillText(warehouse);
            }
        }

        private void FillText(TWarehouse warehouse)
        {
            noTxt.Text = warehouse.Id;
            nameTxt.Text = warehouse.Name;
            addrTxt.Text = warehouse.Address;
            areaTxt.Text = warehouse.Area.ToString();
            telTxt.Text = warehouse.Tel;
            contactsTxt.Text = warehouse.Contacts;
            isUseCheckBox.Checked = warehouse.IsUse;
            isDefaultCheckBox.Checked = warehouse.IsDefault;
            descriptionTxt.Text = warehouse.Description;
        }

        private void NoTxt_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(noTxt.Text.Trim()) || noTxt.Text.Trim().Length >10)
            //{
            //    warnLab.Text = "仓库编号不可为空，且长度必须小于10个字符";
            //    warehouse.Id = "";
            //}
            //else if (MDIQuery.NoCheck(noTxt.Text.Trim(),"Warehouse") != 0)
            //{
            //    warnLab.Text = "当前仓库编号已存在";
            //    warehouse.Id = "";
            //}
            //else
            //{
            //    warnLab.Text = "当前仓库编号可以使用";
            //    warehouse.Id = noTxt.Text.Trim();
            //}
            warehouse.Id = MDIAction.TextCheck(noTxt, 10, warnLab, "仓库编号");
        }

        private void NameTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Name = MDIAction.TextCheck(nameTxt, 50, warnLab, "仓库名");
        }

        private void addrTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Address= MDIAction.TextCheck(addrTxt, 100, warnLab, "地址");
        }
        private void telTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Tel= MDIAction.TextCheck(telTxt, 20, warnLab, "联系电话");
        }
        private void contactsTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Contacts = MDIAction.TextCheck(contactsTxt, 20, warnLab, "联系人");
        }

        private void descriptionTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Description = MDIAction.TextLenthCheck(descriptionTxt, 2000, warnLab, "备注");
        }

        private void isUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            warehouse.IsUse=isUseCheckBox.Checked ? true : false;
        }

        private void isDefaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            warehouse.IsDefault = isDefaultCheckBox.Checked ? true : false;
        }

        private void saveAddBtn_Click(object sender, EventArgs e)
        {
            if (MDIAction.WarehouseInfoCheck(warehouse))
            {
                MessageBox.Show(MDIQuery.InsertWarehouseInfo(warehouse) ? "新增成功" : "新增失败");
                MDIAction.SetWarehouseDataGridView(dataGridView, MDIQuery.GetWarehouseInfo());
            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void areaTxt_Leave(object sender, EventArgs e)
        {
            warehouse.Area = Convert.ToDouble(areaTxt.Text);
        }

        private void saveAlterBtn_Click(object sender, EventArgs e)
        {
            if (MDIAction.WarehouseInfoCheck(warehouse, warehouseBackUp))
            {
                MessageBox.Show(MDIQuery.UpdateWarehouseInfo(warehouse, warehouseBackUp) ? "修改成功" : "修改失败");
                MDIAction.SetWarehouseDataGridView(dataGridView, MDIQuery.GetWarehouseInfo());
            }
        }
    }
}
