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
                saveAddBtn.Enabled = false;
                saveAlterBtn.Enabled = true;
                noTxt.Enabled = false;
                DataRow dr= MDIAction.GetGridViewCheckedMinRow(dataGridView);
                ModelHandlerA.ModelHandler<TWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TWarehouse>();
                warehouse = modelHandler.FillModel(dr);
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
        
        private void saveAddBtn_Click(object sender, EventArgs e)
        {
            SetWarehouse();
            if (ObjCheck.WarehouseInfoCheck(warehouse))
            {
                MessageBox.Show(MDIQuery.InsertWarehouseInfo(warehouse) ? "新增成功" : "新增失败");
                MDIAction.SetWarehouseDataGridView(dataGridView, MDIQuery.GetWarehouseInfo());
            }
        }
        
        private void saveAlterBtn_Click(object sender, EventArgs e)
        {
            SetWarehouse();
            if (ObjCheck.WarehouseInfoCheck(warehouse,true))
            {
                MessageBox.Show(MDIQuery.UpdateWarehouseInfo(warehouse) ? "修改成功" : "修改失败");
                MDIAction.SetWarehouseDataGridView(dataGridView, MDIQuery.GetWarehouseInfo());
            }
        }
        private void SetWarehouse(bool isAlter=false)
        {
            warehouse.Id = noTxt.Text.Trim();
            warehouse.Name = nameTxt.Text.Trim();
            warehouse.Address = addrTxt.Text.Trim();
            warehouse.Tel = telTxt.Text.Trim();
            warehouse.Contacts = contactsTxt.Text.Trim();
            if (RegexCheck.IsFloat(areaTxt.Text.Trim())||RegexCheck.IsInterger(areaTxt.Text.Trim()))
            {
                warehouse.Area = Convert.ToDouble(areaTxt.Text.Trim());
            }
            warehouse.Description = descriptionTxt.Text.Trim();
            warehouse.IsUse = isUseCheckBox.Checked ? true : false;
            warehouse.IsDefault = isDefaultCheckBox.Checked ? true : false;
        }

        private void isUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isUseCheckBox.Checked)
            {
                isDefaultCheckBox.Checked = false;
            }
        }

        private void isDefaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDefaultCheckBox.Checked)
            {
                isUseCheckBox.Checked = true;
            }
        }
    }
}
