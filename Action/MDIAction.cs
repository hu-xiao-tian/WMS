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

namespace 仓库管理系统
{
    class MDIAction
    {
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
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "仓库编号", "仓库名称", "地址", "面积", "电话", "联系人" , "是否使用", "是否默认" , "备注" };
            for(int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderText = colText[i];
            }
            return dataGridView;
        }
        /// <summary>
        /// 文本非空限长检测
        /// 返回值：正确为文本框中字符串，错误为空值
        /// </summary>
        /// <param name="textBox">要检查的文本框</param>
        /// <param name="lenth">限制的长度</param>
        /// <param name="warnLab">警告标签</param>
        /// <param name="property">检查的属性名称</param>
        /// <returns></returns>
        public static string TextCheck(TextBox textBox,int lenth,Label warnLab,string property)
        {
            if (string.IsNullOrEmpty(textBox.Text.Trim()) || textBox.Text.Trim().Length > lenth)
            {
                warnLab.Text = $"{property}不可为空，且长度必须小于{lenth}个字符";
                return "";
            }
            else
            {
                //warnLab.Text = $"当前{property}可以使用";
                warnLab.Text = "";
                return textBox.Text.Trim();
            }
        }
        /// <summary>
        /// 文本限长检测
        /// 返回值：正确为文本框中字符串，错误为空值
        /// </summary>
        /// <param name="textBox">要检查的文本框</param>
        /// <param name="lenth">限制的长度</param>
        /// <param name="warnLab">警告标签</param>
        /// <param name="property">检查的属性名称</param>
        /// <returns></returns>
        public static string TextLenthCheck(TextBox textBox, int lenth, Label warnLab, string property)
        {
            if (textBox.Text.Trim().Length > lenth)
            {
                warnLab.Text = $"{property}长度必须小于{lenth}个字符";
                return "";
            }
            else
            {
                warnLab.Text = "";
                return textBox.Text.Trim();
            }
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


        /// <summary>
        /// 仓库信息检查
        /// </summary>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        public static bool WarehouseInfoCheck(TWarehouse warehouse, TWarehouse warehouseOld=null)
        {
            //若修改时老id和新id是一样的，就不做id检查了 
            bool isCheckId = true;
            if (warehouseOld != null&& warehouse.Id == warehouseOld.Id)
            {
                isCheckId = false;
            }

            if (string.IsNullOrEmpty(warehouse.Id))
            {
                MessageBox.Show("请更正仓库编号");
                return false;
            }
            else if (isCheckId? MDIQuery.NoCheck(warehouse.Id,"Warehouse")>0:false)
            {
                MessageBox.Show("仓库编号已经存在，请更正仓库编号");
                return false;
            }
            else if (string.IsNullOrEmpty(warehouse.Name))
            {
                MessageBox.Show("请更正仓库名");
                return false;
            }
            else if (string.IsNullOrEmpty(warehouse.Address))
            {
                MessageBox.Show("请更正仓库地址");
                return false;
            }
            else if (string.IsNullOrEmpty(warehouse.Tel))
            {
                MessageBox.Show("请更正仓库联系电话");
                return false;
            }
            else if (string.IsNullOrEmpty(warehouse.Contacts))
            {
                MessageBox.Show("请更正仓库联系人");
                return false;
            }
            else if (!string.IsNullOrEmpty(warehouse.Description)&&warehouse.Description.Length > 2000)
            {
                MessageBox.Show("请更正仓库备注");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DataRow GetGridViewCheckedMinRow(DataGridView dataGridView)
        {
            List<int> indexs = GetGridViewCheckedIndexs(dataGridView);
            DataRow dr = (dataGridView.Rows[indexs.Min()].DataBoundItem as DataRowView).Row;
            return dr;
        }

        public static List<int> GetGridViewCheckedIndexs(DataGridView dataGridView)
        {
            List<int> indexs = new List<int>();
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                int index = dataGridView.SelectedCells[i].RowIndex;
                indexs.Add(index);
            }
            return indexs;
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
            s.RestoreDirectory = true;//没感觉每次都打开都回到了初始路径，你可以试一下
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
            MessageBox.Show("若遇到导出文件有问题，请选择xls");
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
    }
}
