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
    public partial class ManageClient1 : ManageForm2
    {
        public ModelHandlerA.ModelHandler<TClient> modelHandler = new ModelHandlerA.ModelHandler<TClient>();
        public TClient client = new TClient();
        public ManageClient1()
        {
            InitializeComponent();
        }
        public ManageClient1(DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            InitializeComponent();
        }
        public ManageClient1(TClient client, DataGridView dataGridView, TreeView treeView) : base(dataGridView, treeView)
        {
            InitializeComponent();
            upBtn.Enabled = false;
            downBtn.Enabled = false;
            saveBtn.Enabled = false;
            this.client = client;
            FillText(client);
        }
        public override void typeIdTxt_TextChanged(object sender, EventArgs e)
        {
            TClientType clientType = TypeControlQuery.GetClientTypesById(typeIdTxt.Text);
            if (clientType != null)
            {
                typeNameTxt.Text = clientType.Name;
            }
            else
            {
                typeNameTxt.Text = string.Empty;
            }
        }
        public override void typeNameTxt_TextChanged(object sender, EventArgs e)
        {
            TClientType clientType = TypeControlQuery.GetClientTypesByName(typeNameTxt.Text);
            if (clientType != null)
            {
                typeIdTxt.Text = clientType.AutoId.ToString();
            }
            else
            {
                typeIdTxt.Text = string.Empty;
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            SaveSupplierInfo();
        }
        private void SaveSupplierInfo()
        {
            bool result = false;
            TClient client = SetClient(this.client);
            if (client != null)
            {
                result = ObjCheck.CheckClient(client);
            }
            if (result)
            {
                result = MDIQuery.InsertClientInfo(client);
                MessageBox.Show(result ? "新增成功" : "新增失败");
                FlashForm();
            }
        }
        public TClient SetClient(TClient Client)
        {
            if (!string.IsNullOrEmpty(companyNameTxt.Text) && !string.IsNullOrEmpty(pinyinCodeTxt.Text))
            {
                Client.CompanyName = companyNameTxt.Text.Trim();
                Client.PinyinCode = pinyinCodeTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("供应商名称和拼音码不可为空");
                return null;
            }
            Client.ContactName = contactNameTxt.Text.Trim();
            Client.Area = areaTxt.Text.Trim();
            if (!string.IsNullOrEmpty(addressTxt.Text))
            {
                Client.Address = addressTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("地址不可为空");
                return null;
            }

            Client.WebSite = webSideTxt.Text.Trim();
            if (!string.IsNullOrEmpty(telTxt.Text) && !string.IsNullOrEmpty(emailTxt.Text))
            {
                Client.Tel = telTxt.Text.Trim();
                Client.Email = emailTxt.Text.Trim();
            }
            else
            {
                MessageBox.Show("电话和邮箱不可为空");
                return null;
            }
            if (!string.IsNullOrEmpty(typeIdTxt.Text))
            {
                Client.TypeId = Convert.ToInt32(typeIdTxt.Text.Trim());
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
                Client.RankNum = Convert.ToInt32(rankNumTxt.Text.Trim());
            }
            else
            {
                Client.RankNum = MDIQuery.GetMaxRankNum("Client");
            }
            return Client;
        }
        public void FlashForm()
        {
            MDIAction.SetClientDataGridView(dataGridView, MDIQuery.GetClients());
            MDIAction.AutoSetDGVCol(dataGridView);
            List<TClientType> clientTypes = TypeControlQuery.GetClientTypes();
            TypeControlAction.InitClientTypeTree(treeView, clientTypes);
        }

        public override void upBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                DataRow dr = (dataGridView.Rows[--index].DataBoundItem as DataRowView).Row;
                client = modelHandler.FillModel(dr);
                FillText(client);
            }
            else
            {
                MessageBox.Show("已是第一条记录");
            }
        }
        public void FillText(TClient Client)
        {
            companyNameTxt.Text = Client.CompanyName;
            pinyinCodeTxt.Text = Client.PinyinCode;
            contactNameTxt.Text = Client.ContactName;
            areaTxt.Text = Client.Area;
            addressTxt.Text = Client.Address;
            webSideTxt.Text = Client.WebSite;
            telTxt.Text = Client.Tel;
            emailTxt.Text = Client.Email;
            typeIdTxt.Text = Client.TypeId.ToString();
            typeNameTxt.Text = Client.TypeName;
            rankNumTxt.Text = Client.RankNum.ToString();
        }
        public override void downBtn_Click(object sender, EventArgs e)
        {
            if (index < dataGridView.RowCount - 1)
            {
                DataRow dr = (dataGridView.Rows[++index].DataBoundItem as DataRowView).Row;
                client = modelHandler.FillModel(dr);
                FillText(client);
            }
            else
            {
                MessageBox.Show("已是最后条记录");
            }
        }
        public override void saveCloseBtn_Click(object sender, EventArgs e)
        {
            SaveSupplierInfo();
            Close();
        }
    }
}
