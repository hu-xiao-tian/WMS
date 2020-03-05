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
    public partial class ManageGoods2 : MDIForm
    {
        DataGridView dataGridView;
        List<TGoods> goods = new List<TGoods>();
        TClient client = new TClient();
        int today=Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
        string outType = "销售";
        public ManageGoods2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            outWTCBox.SelectedIndex= 0;
        }
        public ManageGoods2(DataGridView dataGridView)
        {
            InitializeComponent();
            outWTCBox.SelectedIndex = 0;
            this.dataGridView = dataGridView;
        }
        private void ManageGoods2_Load(object sender, EventArgs e)
        {
            SetOutWarehouseObJ();
            FlashForm();
        }
        public void FlashForm()
        {
            MDIAction.SetClientDataGridView(dataGridView1, MDIQuery.GetClients());
            MDIAction.AutoSetDGVCol(dataGridView1);
            List<TClientType> clientTypes = TypeControlQuery.GetClientTypes();
            TypeControlAction.InitClientTypeTree(treeView, clientTypes);
        }
        public void FlashForm2()
        {
            MDIAction.SetGoodsDataGridView(dataGridView, MDIQuery.GetGoods());
            //MDIAction.AutoSetDGVCol(dataGridView1);
        }
        private void selectBtn_Click(object sender, EventArgs e)
        {
            List<TClient> clients = MDIQuery.GetClientByName(selectTxt.Text.Trim());
            MDIAction.SetClientDataGridView(dataGridView1, clients);
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            List<TClient> clients = MDIQuery.GetClientByName(selectTxt.Text.Trim());
            MDIAction.SetClientDataGridView(dataGridView1, clients);
        }

        private void outWTCBox_TextChanged(object sender, EventArgs e)
        {
            if (outWTCBox.Text.Equals("销售"))
            {
                panel1.Height = 80;
                panel3.Show();
                dataGridView1.Show();
                clientNameTxt.Show();
                priceLab.Text = "销售总价：" + goods.Sum(s => s.OutPrice).ToString();
                this.Height = 500;
                outType = outWTCBox.Text.Trim();
            }
            else
            {
                clientNameTxt.Hide();
                panel1.Height = 40;
                panel3.Hide();
                dataGridView1.Hide();
                priceLab.Text = "损坏总价：" + goods.Sum(s => s.InPrice).ToString();
                this.Height = 80;
                outType = outWTCBox.Text.Trim();
            }
        }
        private void SetOutWarehouseObJ()
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView);
            if (dataRows.Count > 0)
            {
                goods = MDIAction.DataRowToGoods(dataRows);
                priceLab.Text ="销售总价："+ goods.Sum(s => s.OutPrice).ToString();
            }
            else
            {
                Close();
                MessageBox.Show("请选择要出库的商品");
            }
        }
        private void SetClientObJ()
        {
            List<DataRow> dataRows = MDIAction.GetGridViewCheckedRows(dataGridView1);
            if (dataRows.Count > 0)
            {
                client = MDIAction.DataRowToClient(dataRows).FirstOrDefault();
                clientNameTxt.Text = client.CompanyName;
            }
            else
            {
                Close();
                MessageBox.Show("请选择客户");
            }
        }
        public override void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetClientObJ();
        }

        private void outWarehouseBtn_Click(object sender, EventArgs e)
        {
            if (outWTCBox.Text.Equals("销售"))
            {
                if (string.IsNullOrEmpty(clientNameTxt.Text))
                {
                    MessageBox.Show("请选择供货商");
                    return;
                }
                OutWarehouse();
                FillSellWStatistics();
            }
            else
            {
                OutWarehouse();
                FillBadWStatistics();
            }
            Close();
        }
        
        private void FillSellWStatistics()
        {
            List<TWStatistics> statisticsList = MDIQuery.GetWStatistics().Where(w=>w.DateCode==today).ToList();
            if (statisticsList.Count > 0)
            {
                double inPrice = goods.Sum(s => s.InPrice);
                double outPrice = goods.Sum(s => s.InPrice);
                TWStatistics statistics = statisticsList.FirstOrDefault();
                statistics.InPrice += inPrice;
                statistics.OutPrice += inPrice;
                statistics.ProfitPrice += outPrice - inPrice;
                //更新表
                MDIQuery.UpdateWStatisticsInfo(statistics);
            }
            else
            {
                double inPrice = goods.Sum(s => s.InPrice);
                double outPrice = goods.Sum(s => s.InPrice);
                TWStatistics statistics = new TWStatistics();
                statistics.InPrice = inPrice;
                statistics.OutPrice = outPrice;
                statistics.ProfitPrice = outPrice - inPrice;
                statistics.DateCode = today;
                //插入表
                MDIQuery.InsertWStatisticsInfo(statistics);
            }
        }
        private void FillBadWStatistics()
        {
            List<TWStatistics> statisticsList = MDIQuery.GetWStatistics().Where(w => w.DateCode == today).ToList();
            if (statisticsList.Count > 0)
            {
                double inPrice = goods.Sum(s => s.InPrice);
                TWStatistics statistics = statisticsList.FirstOrDefault();
                statistics.InPrice += inPrice;
                statistics.BadPrice += inPrice;
                statistics.ProfitPrice -= inPrice;
                //更新表
                MDIQuery.UpdateWStatisticsInfo(statistics);
            }
            else
            {
                double inPrice = goods.Sum(s => s.InPrice);
                TWStatistics statistics = new TWStatistics();
                statistics.InPrice += inPrice;
                statistics.BadPrice += inPrice;
                statistics.ProfitPrice -= inPrice;
                statistics.DateCode = today;
                //插入表
                MDIQuery.InsertWStatisticsInfo(statistics);
            }

        }
        private void OutWarehouse()
        {
            bool result = false;
            if (goods != null&&goods.Count>0)
            {
                MultiThreadWork multi = new MultiThreadWork(1);
                multi.DoMultiWork((g) =>
                {
                    for (int i = 0; i < g.Count; i++)
                    {
                        TOutWarehouse outWarehouse = new TOutWarehouse();
                        outWarehouse = FillOutWarehouse(outWarehouse, g[i]);
                        result = MDIQuery.InsertOutWarehouseInfo(outWarehouse);
                    }
                }, goods);
                multi.WaitingFinish();
                if (result)
                {
                    DelGoodsInfo();
                }
                FlashForm2();
            }
        }

        private void DelGoodsInfo()
        {
            int rows = MDIQuery.DeleteGoods(goods);
            MessageBox.Show($"成功出库{rows}件");
            FlashForm();
        }

        private TOutWarehouse FillOutWarehouse(TOutWarehouse outWarehouse, TGoods goods)
        {
            outWarehouse.Name = goods.Name;
            outWarehouse.PinyinCode = goods.PinyinCode;
            outWarehouse.BarCode = goods.BarCode;
            outWarehouse.ProducedDate = goods.ProducedDate;
            outWarehouse.SName = goods.SName;
            outWarehouse.TName = goods.TName;
            outWarehouse.WId = goods.WId;
            outWarehouse.InPrice = goods.InPrice;
            if (outType.Equals("销售"))
            {
                outWarehouse.CName = clientNameTxt.Text.Trim();
                outWarehouse.OutPrice = goods.OutPrice;
            }
            else
            {
                outWarehouse.CName = string.Empty;
                outWarehouse.OutPrice = 0;
            }
            outWarehouse.OutType = outType;
            return outWarehouse;
        }
    }
}
