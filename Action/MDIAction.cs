using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Dapper;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using 仓库管理系统.Template;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;

namespace 仓库管理系统
{
    class MDIAction
    {
        public static void AutoSetDGVCol(DataGridView dataGridView1)
        {
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }
        }

        /// <summary>
        /// 初始化仓库列表框
        /// </summary>
        /// <param name="wIdComboBox"></param>
        public static void InitWIdComboBox(ComboBox wIdComboBox)
        {
            List<TWarehouse> warehouses = new List<TWarehouse>();
            warehouses = MDIQuery.GetUsingWarehouseInfo();
            foreach(var warehouse in warehouses)
            {
                wIdComboBox.Items.Add(warehouse.Id);
            }
            wIdComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 初始化用户树
        /// </summary>
        /// <param name="tree"></param>
        public static void InitUserTree(TreeView treeView)
        {
            List<TLvInfo> lvInfos = MDIQuery.GetLvInfos(-1);
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (var lvInfo in lvInfos)
            {
                TreeNode cNode = new TreeNode();
                cNode.Name = lvInfo.UserLV.ToString();
                cNode.Text = lvInfo.LvInstructions;
                treeNodes.Add(cNode);
            }
            TreeNode treeRoot = new TreeNode("全部", treeNodes.ToArray());
            treeView.Nodes.Add(treeRoot);
        }

        /// <summary>
        /// 绑定供应商视图
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="list"></param>
        public static DataGridView SetSupplierDataGridView(DataGridView dataGridView, List<TSupplier> suppliers)
        {
            ModelHandlerA.ModelHandler<TSupplier> modelHandler = new ModelHandlerA.ModelHandler<TSupplier>();
            DataTable dt = modelHandler.FillDataTable(suppliers);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "供应商编号", "供应商名","拼音码","联系人", "地区", "地址", "官网", "电话", "邮箱", "类型id","类型名称", "排序" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }

        

        /// <summary>
        /// 绑定客户视图
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="list"></param>
        public static DataGridView SetClientDataGridView(DataGridView dataGridView, List<TClient> clients)
        {
            ModelHandlerA.ModelHandler<TClient> modelHandler = new ModelHandlerA.ModelHandler<TClient>();
            DataTable dt = modelHandler.FillDataTable(clients);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "客户编号", "客户名", "拼音码", "联系人", "地区", "地址", "官网", "电话", "邮箱", "类型id", "类型名称", "排序" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        

        /// <summary>
        /// 绑定用户数据视图
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="loginUsers"></param>
        /// <returns></returns>
        public static DataGridView SetLoginUserDataGridView(DataGridView dataGridView, List<TLoginUser> loginUsers)
        {
            ModelHandlerA.ModelHandler<TLoginUser> modelHandler = new ModelHandlerA.ModelHandler<TLoginUser>();
            DataTable dt = modelHandler.FillDataTable(loginUsers);
            if (dt != null)
            {
                dt.Columns.Remove("UserPassword");
                dt.Columns.Remove("UserLV");
            }
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "员工编号", "用户名", "邮箱", "昵称", "电话", "个性签名", "头像地址","职位" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        /// <summary>
        /// 绑定商品模板视图
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="list"></param>
        public static DataGridView SetGoodsTemplateDataGridView(DataGridView dataGridView, List<TGoodsTemplate> goodsTemplates)
        {
            ModelHandlerA.ModelHandler<TGoodsTemplate> modelHandler = new ModelHandlerA.ModelHandler<TGoodsTemplate>();
            DataTable dt = modelHandler.FillDataTable(goodsTemplates);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "商品编号", "商品名称", "拼音码","条形码", "图片", "类型Id", "类型名称", "供货商Id", "供货商名称","备注"};
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static DataGridView SetGoodsDataGridView(DataGridView dataGridView, List<TGoods> goods)
        {
            ModelHandlerA.ModelHandler<TGoods> modelHandler = new ModelHandlerA.ModelHandler<TGoods>();
            DataTable dt = modelHandler.FillDataTable(goods);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "商品编号", "商品名称", "拼音码", "条形码", "图片", "生产日期", "有效期", "收购价格", "预售价", "类型id", "类型名称", "供货商Id", "供货商名称", "仓库Id", "仓库名称", "备注" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static DataGridView SetInWarehouseGridView(DataGridView dataGridView, List<TInWarehouse> inWarehouses)
        {
            ModelHandlerA.ModelHandler<TInWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TInWarehouse>();
            DataTable dt = modelHandler.FillDataTable(inWarehouses);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "编号", "商品名称", "拼音码", "条形码", "生产日期", "供货商", "类型", "仓库Id","收购价格", "类型", "数量","时间"};
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static DataGridView SetOutWarehouseGridView(DataGridView dataGridView, List<TOutWarehouse> outWarehouses)
        {
            ModelHandlerA.ModelHandler<TOutWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TOutWarehouse>();
            DataTable dt = modelHandler.FillDataTable(outWarehouses);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "编号", "商品名称", "拼音码", "条形码", "生产日期", "供货商","客户", "类型", "仓库Id", "收购价格","出售价格", "类型","时间" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static DataGridView SetGoodsCountGridView(DataGridView dataGridView, List<TGoodsCount> goodsCounts)
        {
            ModelHandlerA.ModelHandler<TGoodsCount> modelHandler = new ModelHandlerA.ModelHandler<TGoodsCount>();
            DataTable dt = modelHandler.FillDataTable(goodsCounts);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "商品名称", "拼音码", "条形码", "生产日期", "有效期", "剩余数量" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static DataGridView SetWStatisticsGridView(DataGridView dataGridView, List<TWStatistics> statistics)
        {
            ModelHandlerA.ModelHandler<TWStatistics> modelHandler = new ModelHandlerA.ModelHandler<TWStatistics>();
            DataTable dt = modelHandler.FillDataTable(statistics);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "编号", "购入总价", "销售总价", "损坏总价", "净利润", "日期编号" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        public static List<TSupplier> ExcelToSupplierOBJ(string openPath)
        {
            try
            {
                DataTable dt = ExcelHelper.GetDataTable(openPath, 0);
                ModelHandlerA.ModelHandler<TSupplier> modelHandler = new ModelHandlerA.ModelHandler<TSupplier>();
                List<TSupplier> suppliers = modelHandler.FillModel(dt);
                return suppliers;
            }catch(Exception ex)
            {
                MessageBox.Show("导入失败");
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InputExcelError.txt", info);
                return null;
            }
        }
        public static List<TClient> ExcelToClientOBJ(string openPath)
        {
            try
            {
                DataTable dt = ExcelHelper.GetDataTable(openPath, 0);
                ModelHandlerA.ModelHandler<TClient> modelHandler = new ModelHandlerA.ModelHandler<TClient>();
                List<TClient> clients = modelHandler.FillModel(dt);
                return clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败");
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InputExcelError.txt", info);
                return null;
            }
        }
        public static List<TGoodsTemplate> ExcelToGoodsTemplateOBJ(string openPath)
        {
            try
            {
                DataTable dt = ExcelHelper.GetDataTable(openPath,0);
                ModelHandlerA.ModelHandler<TGoodsTemplate> modelHandler = new ModelHandlerA.ModelHandler<TGoodsTemplate>();
                List<TGoodsTemplate> goodsTemplates = modelHandler.FillModel(dt);
                return goodsTemplates;
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败");
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InputExcelError.txt", info);
                return null;
            }
        }
        public static List<TGoods> ExcelToGoodsOBJ(string openPath)
        {
            try
            {
                DataTable dt = ExcelHelper.GetDataTable(openPath, 0);
                ModelHandlerA.ModelHandler<TGoods> modelHandler = new ModelHandlerA.ModelHandler<TGoods>();
                List<TGoods> goods = modelHandler.FillModel(dt);
                return goods;
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败");
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InputExcelError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 修改用户权限
        /// 只能控制低于自己的权限
        /// </summary>
        /// <param name="loginUsers">需要修改权限的用户</param>
        /// <param name="loginUser">当前控制用户</param>
        /// <param name="type">权限修改类型：0删除用户权限（默认）,-1降低用户权限,1增加用户权限</param>
        public static void AlterUserLV(List<TLoginUser> loginUsers, TLoginUser loginUser, int type=0)
        {
            bool isAllow = false;
            foreach (var user in loginUsers)
            {
                if (loginUser.UserLV > user.UserLV)
                {
                    switch (type)
                    {
                        case 0:
                            user.UserLV = 0;
                            isAllow = true;
                            break;
                        case 1:
                            user.UserLV += 1;
                            if (loginUser.UserLV > user.UserLV)
                            {
                                isAllow = true;
                            }
                            else
                            {
                                isAllow = false;
                            }
                            break;
                        case -1:
                            user.UserLV -= 1;
                            if (user.UserLV < 0)
                            {
                                user.UserLV = 0;
                            }
                            isAllow = true;
                            break;
                    }
                    //若给用户增加权限后，权限高于自己就说明自己没有权限修改
                    if (!isAllow)
                    {
                        break;
                    }
                }
                else
                {
                    isAllow = false;
                }
            }
            if (isAllow && MDIQuery.UpdateUserLvInfo(loginUsers))
            {
                MessageBox.Show("权限修改成功");
            }
            else
            {
                MessageBox.Show("权限修改失败");
            }
        }

        /// <summary>
        /// 绑定仓库数据视图
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static DataGridView SetWarehouseDataGridView(DataGridView dataGridView,List<TWarehouse> warehouses)
        {
            ModelHandlerA.ModelHandler<TWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TWarehouse>();
            DataTable dt=modelHandler.FillDataTable(warehouses);
            if (dt != null)
            {
                dt.Columns.Remove("AutoId");
            }
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "仓库编号", "仓库名称", "地址", "面积", "电话", "联系人" , "是否使用", "是否默认" , "备注" };
            for(int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }

        public static void LeftSidebarControl(Panel leftPanel, ToolStripButton sidebarTSBtn)
        {
            if (sidebarTSBtn.Text == "隐藏侧边")
            {
                leftPanel.Hide();
                sidebarTSBtn.Text = "显示侧边";
            }
            else
            {
                leftPanel.Show();
                sidebarTSBtn.Text = "隐藏侧边";
            }
        }
        

        public static DataRow GetGridViewCheckedMinRow(DataGridView dataGridView)
        {
            List<int> indexs = GetGridViewCheckedIndexs(dataGridView);
            if (indexs.Count > 0)
            {
                DataRow dr = (dataGridView.Rows[indexs.Min()].DataBoundItem as DataRowView).Row;
                return dr;
            }
            else
            {
                return null;
            }
        }
        

        public static DataTable DataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dt = (dataGridView.DataSource as DataTable);
            return dt;
        }

        public static List<int> GetGridViewCheckedIndexs(DataGridView dataGridView)
        {
            List<int> indexs = new List<int>();
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                int index = dataGridView.SelectedCells[i].RowIndex;
                indexs.Add(index);
            }
            return indexs.Distinct().ToList();//以单元格作为选中依据，会出现重复现象
        }
        
        public static List<DataRow> GetGridViewCheckedRows(DataGridView dataGridView)
        {
            List<int> indexs = GetGridViewCheckedIndexs(dataGridView);
            List<DataRow> dataRows = new List<DataRow>();
            foreach (var index in indexs)
            {
                DataRow dr = (dataGridView.Rows[index].DataBoundItem as DataRowView).Row;
                dataRows.Add(dr);
            }
            //直接获取选中行的话选中单元格时就无法操作
            //for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
            //{
            //    DataRow dr = (dataGridView.SelectedRows[i].DataBoundItem as DataRowView).Row;
            //    dataRows.Add(dr);
            //}
            return dataRows;
        }
        public static bool GridViewToExcel(string path,DataGridView dataGridView)
        {
            try
            {
                DataTable dt = dataGridView.DataSource as DataTable;
                ExcelHelper.GetExcelByDataTable(dt, path);
                return true;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("OutPutExcelError.txt", info);
                return false;
            }

        }

        public static string SetExcelSaveUrl(string title)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.InitialDirectory = @"C:\";
            //对话框初始路径
            s.FileName = title;
            //默认保存的文件名
            s.Filter = "表格文件(*.xls)|*.xls|表格文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            s.FilterIndex = 1;//默认选择文本文件
            s.DefaultExt = ".xls";
            //默认保存类型，如果过滤条件选所有文件且没写后缀名，则默认补上该默认值
            s.DereferenceLinks = false;
            //返回快捷方式的路径而不是快捷方式映射的文件的路径
            s.Title = title;
            s.RestoreDirectory = true;//没感觉每次都打开都回到了初始路径
            s.ShowHelp = true;//帮助对话框
            s.HelpRequest += new EventHandler(s_HelpRequest);
            //注册帮助按钮事件
            if (s.ShowDialog() == DialogResult.OK)
            {
                return s.FileName;
            }
            return "";
        }
        private static void s_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("若遇到导入导出文件有问题，请选择xls");
        }
        public static string SetExcelOpenUrl(string title)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = @"C:\";
            //对话框初始路径
            o.FileName = "";
            //默认保存的文件名
            o.Filter = "表格文件(*.xls)|*.xls|表格文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            o.FilterIndex = 1;//默认选择文本文件
            o.DefaultExt = ".xls";
            //默认保存类型，如果过滤条件选所有文件且没写后缀名，则默认补上该默认值
            o.DereferenceLinks = false;
            //返回快捷方式的路径而不是快捷方式映射的文件的路径
            o.Title = title;
            o.RestoreDirectory = true;//没感觉每次都打开都回到了初始路径
            o.ShowHelp = true;//帮助对话框
            o.HelpRequest += new EventHandler(s_HelpRequest);
            //注册帮助按钮事件
            if (o.ShowDialog() == DialogResult.OK)
            {
                return o.FileName;
            }
            return "";
        }
        public static bool FilterIsUse(DataGridView dataGridView)
        {
            try
            {
                DataTable dt = dataGridView.DataSource as DataTable;
                DataTable dtNew = dt.Clone();
                DataRow[] drsT = dt.Select("IsUse = true ");
                dtNew.Clear();
                foreach (var row in drsT)
                {
                    dtNew.ImportRow(row);
                }
                dataGridView.DataSource = dtNew;
                return true;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("FilterIsUseError.txt", info);
                return false;
            }

        }

        public static List<TLoginUser> DataRowToLoginUser(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TLoginUser> modelHandler = new ModelHandlerA.ModelHandler<TLoginUser>();
            List<TLoginUser> loginUsers = new List<TLoginUser>();
            foreach (var dataRow in dataRows)
            {
                TLoginUser loginUser = modelHandler.FillModel(dataRow);
                loginUsers.Add(loginUser);
            }
            return loginUsers;
        }
        public static List<TWarehouse> DataRowToWarehouse(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TWarehouse>();
            List<TWarehouse> warehouses = new List<TWarehouse>();
            foreach (var dataRow in dataRows)
            {
                TWarehouse warehouse = modelHandler.FillModel(dataRow);
                warehouses.Add(warehouse);
            }
            return warehouses;
        }
        public static List<TSupplier> DataRowToSupplier(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TSupplier> modelHandler = new ModelHandlerA.ModelHandler<TSupplier>();
            List<TSupplier> suppliers = new List<TSupplier>();
            foreach (var dataRow in dataRows)
            {
                TSupplier supplier = modelHandler.FillModel(dataRow);
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public static List<TClient> DataRowToClient(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TClient> modelHandler = new ModelHandlerA.ModelHandler<TClient>();
            List<TClient> clients = new List<TClient>();
            foreach (var dataRow in dataRows)
            {
                TClient client = modelHandler.FillModel(dataRow);
                clients.Add(client);
            }
            return clients;
        }
        public static List<TGoodsTemplate> DataRowToGoodsTemplate(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TGoodsTemplate> modelHandler = new ModelHandlerA.ModelHandler<TGoodsTemplate>();
            List<TGoodsTemplate> goodsTemplates = new List<TGoodsTemplate>();
            foreach (var dataRow in dataRows)
            {
                TGoodsTemplate goodsTemplate = modelHandler.FillModel(dataRow);
                goodsTemplates.Add(goodsTemplate);
            }
            return goodsTemplates;
        }
        public static List<TGoods> DataRowToGoods(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TGoods> modelHandler = new ModelHandlerA.ModelHandler<TGoods>();
            List<TGoods> goods = new List<TGoods>();
            foreach (var dataRow in dataRows)
            {
                TGoods good = modelHandler.FillModel(dataRow);
                goods.Add(good);
            }
            return goods;
        }
        public static bool CheckIsAllowDelSupplierType(List<TSupplierType> supplierTypes)
        {
            bool isAllow = true;
            List<int> types = new List<int>();
            foreach (var supplierType in supplierTypes)
            {
                types.Add(supplierType.AutoId);
            }
            int count = MDIQuery.GetCountInfoByTypeId(types, "Supplier");
            if (count > 0)
            {
                isAllow = false;
            }
            return isAllow;
        }
        public static bool CheckIsAllowDelClientType(List<TClientType> clientTypes)
        {
            bool isAllow = true;
            List<int> types = new List<int>();
            foreach (var clientType in clientTypes)
            {
                types.Add(clientType.AutoId);
            }
            int count = MDIQuery.GetCountInfoByTypeId(types, "Client");
            if (count > 0)
            {
                isAllow = false;
            }
            return isAllow;
        }
        public static bool CheckIsAllowDelGoodsType(List<TGoodsType> goodsTypes)
        {
            bool isAllow = true;
            List<int> types = new List<int>();
            foreach (var goodType in goodsTypes)
            {
                types.Add(goodType.AutoId);
            }
            int count = MDIQuery.GetCountInfoByTypeId(types, "GoodsTemplate","Tid");
            if (count > 0)
            {
                isAllow = false;
                return isAllow;
            }
            count = MDIQuery.GetCountInfoByTypeId(types, "Goods", "Tid");
            if (count > 0)
            {
                isAllow = false;
                return isAllow;
            }
            return isAllow;
        }

        public static bool CheckIsAllowDelSupplier(List<TSupplier> suppliers)
        {
            bool isAllow = true;
            List<int> types = new List<int>();
            foreach (var supplier in suppliers)
            {
                types.Add(supplier.AutoId);
            }
            int count = MDIQuery.GetCountInfoByTypeId(types, "GoodsTemplate", "Sid");
            if (count > 0)
            {
                isAllow = false;
                return isAllow;
            }
            count = MDIQuery.GetCountInfoByTypeId(types, "Goods", "Sid");
            if (count > 0)
            {
                isAllow = false;
                return isAllow;
            }
            return isAllow;
        }
        public static bool CheckIsAllowDelWarehouses(List<TWarehouse> warehouses)
        {
            bool isAllow = true;
            List<string> ids = new List<string>();
            foreach (var warehouse in warehouses)
            {
                ids.Add(warehouse.Id);
            }
            int count = MDIQuery.GetCountInfoByWId(ids, "Goods","WId");
            if (count > 0)
            {
                isAllow = false;
            }
            return isAllow;
        }
        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);
        /// <summary>
        /// 初始化图片展示窗体
        /// </summary>
        /// <param name="hWndChild">父窗体</param>
        /// <param name="hWndNewParent">子窗体（引用传递）</param>
        /// <returns></returns>
        public static void InitImageShowForm(Form fatherForm, ref ImageShowForm imageShowForm, string imageName)
        {
            imageShowForm = new ImageShowForm(imageName);
            imageShowForm.Show();
            SetParent((int)imageShowForm.Handle, (int)fatherForm.Handle);
            imageShowForm.Location = new Point(fatherForm.Width - imageShowForm.Width - 20, fatherForm.Height - imageShowForm.Height - 50);
        }
    }
}
