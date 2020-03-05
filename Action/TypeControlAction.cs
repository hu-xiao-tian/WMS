using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    class TypeControlAction
    {
        public static void SetPanelBothSize(int fWidth, Panel leftPanel, Panel rightPanel, int leftBlock = 3, int block = 10)
        {
            leftPanel.Width = (fWidth / block) * leftBlock;
            rightPanel.Width = (fWidth / block) * (block - leftBlock);
        }
        
        public static void SetPanelBothSize(int fWidth, Panel leftPanel,int leftBlock = 3, int block = 10)
        {
            leftPanel.Width = (fWidth / block) * leftBlock;
        }


        /// <summary>
        /// 调用树视图右键菜单
        /// </summary>
        /// <param name="e">节点单机对象参数e</param>
        /// <param name="treeView">树视图对象</param>
        /// <param name="treeCMStrip">需要调用的菜单对象</param>
        public static void CallTreeViewRightMenu(TreeNodeMouseClickEventArgs e, TreeView treeView,ContextMenuStrip treeCMStrip)
        {
            
            Point ClickPoint = new Point(e.X, e.Y);
            TreeNode CurrentNode = treeView.GetNodeAt(ClickPoint);
            Point pos = new Point(e.Node.Bounds.X + e.Node.Bounds.Width, e.Node.Bounds.Y + e.Node.Bounds.Height / 2);
            treeCMStrip.Show(treeView, pos);
            treeView.SelectedNode = CurrentNode;
            
        }

        public static TSupplierType SetSupplierType(string typeName, string typeRank,int autoId = -1)
        {
            int count=TypeControlQuery.TypeNameCheck(typeName, "SupplierType",autoId);
            if (count > 0)
            {
                MessageBox.Show($"{typeName}类型已存在");
            }
            else if (!RegexCheck.IsInterger(typeRank))
            {
                MessageBox.Show("排序码只能为整数");
            }
            else
            {
                TSupplierType supplierType = new TSupplierType()
                {
                    Name = typeName,
                    RankNum = Convert.ToInt32(typeRank)

                };
                if (autoId>0)
                {
                    supplierType.AutoId = autoId;
                }
                return supplierType;
            }
            return null;
        }
        public static TClientType SetClientType(string typeName, string typeRank, int autoId = -1)
        {
            int count = TypeControlQuery.TypeNameCheck(typeName, "ClientType", autoId);
            if (count > 0)
            {
                MessageBox.Show($"{typeName}类型已存在");
            }
            else if (!RegexCheck.IsInterger(typeRank))
            {
                MessageBox.Show("排序码只能为整数");
            }
            else
            {
                TClientType clientType = new TClientType()
                {
                    Name = typeName,
                    RankNum = Convert.ToInt32(typeRank)

                };
                if (autoId > 0)
                {
                    clientType.AutoId = autoId;
                }
                return clientType;
            }
            return null;
        }
        public static TGoodsType SetGoodsType(string typeName, string typeRank, int autoId = -1)
        {
            int count = TypeControlQuery.TypeNameCheck(typeName, "GoodsType", autoId);
            if (count > 0)
            {
                MessageBox.Show($"{typeName}类型已存在");
            }
            else if (!RegexCheck.IsInterger(typeRank))
            {
                MessageBox.Show("排序码只能为整数");
            }
            else
            {
                TGoodsType goodsType = new TGoodsType()
                {
                    Name = typeName,
                    RankNum = Convert.ToInt32(typeRank)

                };
                if (autoId > 0)
                {
                    goodsType.AutoId = autoId;
                }
                return goodsType;
            }
            return null;
        }
        public static void ChangeTypeBtnClick(ToolStripLabel typeNameLab = null, ToolStripTextBox typeNameTxt = null, ToolStripLabel typeRankLab = null, ToolStripTextBox typeRankTxt = null, ToolStripButton btn1 = null, ToolStripButton btn2 = null, ToolStripButton btn3 = null)
        {
            if (btn1.Visible == true && btn2.Visible == false)
            {
                TypeControlAction.HideLabTxtBtn(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, btn1);
                btn2.Visible = true;
            }
            else
            {
                typeNameTxt.Text = "";
                typeRankTxt.Text = "";
                TypeControlAction.ShowLabTxtBtn(typeNameLab, typeNameTxt, typeRankLab, typeRankTxt, btn1);
                TypeControlAction.HideLabTxtBtn(null, null, null, null, btn3, btn2);
            }
        }

        public static void UpdateDataGridViewRankValue(DataGridView dataGridView1)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[2].EditedFormattedValue;
            }
        }

        public static List<TSupplierType> DataRowToSupplierType(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TSupplierType> modelHandler = new ModelHandlerA.ModelHandler<TSupplierType>();
            List<TSupplierType> supplierTypes = new List<TSupplierType>();
            foreach (var dataRow in dataRows)
            {
                TSupplierType supplierType = modelHandler.FillModel(dataRow);
                supplierTypes.Add(supplierType);
            }
            return supplierTypes;
        }
        public static List<TClientType> DataRowToClientType(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TClientType> modelHandler = new ModelHandlerA.ModelHandler<TClientType>();
            List<TClientType> clientTypes = new List<TClientType>();
            foreach (var dataRow in dataRows)
            {
                TClientType clientType = modelHandler.FillModel(dataRow);
                clientTypes.Add(clientType);
            }
            return clientTypes;
        }
        public static List<TGoodsType> DataRowToGoodsType(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TGoodsType> modelHandler = new ModelHandlerA.ModelHandler<TGoodsType>();
            List<TGoodsType> goodsTypes = new List<TGoodsType>();
            foreach (var dataRow in dataRows)
            {
                TGoodsType goodsType = modelHandler.FillModel(dataRow);
                goodsTypes.Add(goodsType);
            }
            return goodsTypes;
        }
        public static void ShowLabTxtBtn(ToolStripLabel typeNameLab, ToolStripTextBox typeNameTxt, ToolStripLabel typeRankLab, ToolStripTextBox typeRankTxt, ToolStripButton btn1 = null, ToolStripButton btn2 = null)
        {
            typeNameLab.Visible = true;
            typeNameTxt.Visible = true;
            typeRankLab.Visible = true;
            typeRankTxt.Visible = true;
            if (btn1 != null)
            {
                btn1.Visible = true;
            }
            if (btn2 != null)
            {
                btn2.Visible = true;
            }
        }

        public static void HideLabTxtBtn(ToolStripLabel typeNameLab=null, ToolStripTextBox typeNameTxt = null, ToolStripLabel typeRankLab = null, ToolStripTextBox typeRankTxt = null, ToolStripButton btn1=null, ToolStripButton btn2=null)
        {

            if (typeNameLab != null)
            {
                typeNameLab.Visible = false;
            }
            if (typeNameTxt != null)
            {
                typeNameTxt.Text = "";
                typeNameTxt.Visible = false;
            }
            if (typeRankLab != null)
            {
                typeRankLab.Visible = false;
            }
            if (typeRankTxt != null)
            {
                typeRankTxt.Text = "";
                typeRankTxt.Visible = false;
            }
            if (btn1 != null)
            {
                btn1.Visible = false;
            }
            if (btn2 != null)
            {
                btn2.Visible = false;
            }
        }
        /// <summary>
        /// 设置货物类型视图
        /// </summary>
        /// <param name="dataGridView">视图对象</param>
        /// <param name="clientTypes">实体对象列表</param>
        /// <returns></returns>
        public static DataGridView SetClientTypeDataGridView(DataGridView dataGridView, List<TGoodsType> goodsTypes)
        {
            ModelHandlerA.ModelHandler<TGoodsType> modelHandler = new ModelHandlerA.ModelHandler<TGoodsType>();
            DataTable dt = modelHandler.FillDataTable(goodsTypes);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "类型编号", "类型名称", "类型排序" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = colText[i];
            }
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            return dataGridView;
        }
        /// <summary>
        /// 设置客户类型视图
        /// </summary>
        /// <param name="dataGridView">视图对象</param>
        /// <param name="clientTypes">实体对象列表</param>
        /// <returns></returns>
        public static DataGridView SetClientTypeDataGridView(DataGridView dataGridView, List<TClientType> clientTypes)
        {
            ModelHandlerA.ModelHandler<TClientType> modelHandler = new ModelHandlerA.ModelHandler<TClientType>();
            DataTable dt = modelHandler.FillDataTable(clientTypes);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "类型编号", "类型名称", "类型排序" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = colText[i];
            }
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            return dataGridView;
        }
        /// <summary>
        /// 设置供应商类型视图
        /// </summary>
        /// <param name="dataGridView">视图对象</param>
        /// <param name="supplierTypes">实体对象列表</param>
        /// <returns></returns>
        public static DataGridView SetSupplierTypeDataGridView(DataGridView dataGridView, List<TSupplierType> supplierTypes)
        {
            ModelHandlerA.ModelHandler<TSupplierType> modelHandler = new ModelHandlerA.ModelHandler<TSupplierType>();
            DataTable dt = modelHandler.FillDataTable(supplierTypes);
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersVisible = true;
            string[] colText = { "类型编号", "类型名称", "类型排序" };
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = colText[i];
            }
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            return dataGridView;
        }
        /// <summary>
        /// 树视图联动表格视图
        /// </summary>
        /// <param name="id">选中对象id(Node.Name)</param>
        /// <param name="dataGridView1">联动网格对象</param>
        public static void TreeViewLinkDataGridView(string id, DataGridView dataGridView1)
        {
            IEnumerable<DataGridViewRow> enumerableList = dataGridView1.Rows.Cast<DataGridViewRow>();
            //linq查出对应id
            List<DataGridViewRow> list = (from item in enumerableList
                                          where item.Cells[0].Value.ToString().Equals(id)
                                          select item).ToList();
            //查询存在，取索引对视图进行选中
            if (list.Count > 0)
            {
                int matchedRowIndex = list[0].Index;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
                dataGridView1.Rows[matchedRowIndex].Selected = true;
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

        /// <summary>
        /// 初始化供应商类型树视图
        /// </summary>
        /// <param name="tree"></param>
        public static void InitSupplierTypeTree(TreeView treeView,List<TSupplierType> supplierTypes)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (var supplierInfo in supplierTypes)
            {
                TreeNode cNode = new TreeNode();
                cNode.Name = supplierInfo.AutoId.ToString();
                cNode.Text = supplierInfo.Name;
                treeNodes.Add(cNode);
            }
            TreeNode treeRoot = new TreeNode("全部", treeNodes.ToArray());
            treeView.Nodes.Clear();
            treeView.Nodes.Add(treeRoot);
            treeView.ExpandAll();
        }
        /// <summary>
        /// 初始化客户类型树视图
        /// </summary>
        /// <param name="tree"></param>
        public static void InitClientTypeTree(TreeView treeView, List<TClientType> clientTypes)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (var clientInfo in clientTypes)
            {
                TreeNode cNode = new TreeNode();
                cNode.Name = clientInfo.AutoId.ToString();
                cNode.Text = clientInfo.Name;
                treeNodes.Add(cNode);
            }
            TreeNode treeRoot = new TreeNode("全部", treeNodes.ToArray());
            treeView.Nodes.Clear();
            treeView.Nodes.Add(treeRoot);
            treeView.ExpandAll();
        }
        /// <summary>
        /// 初始化货物类型树视图
        /// </summary>
        /// <param name="tree"></param>
        public static void InitGoodsTypeTree(TreeView treeView, List<TGoodsType> goodsTypes)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (var goodsInfo in goodsTypes)
            {
                TreeNode cNode = new TreeNode();
                cNode.Name = goodsInfo.AutoId.ToString();
                cNode.Text = goodsInfo.Name;
                treeNodes.Add(cNode);
            }
            TreeNode treeRoot = new TreeNode("全部", treeNodes.ToArray());
            treeView.Nodes.Clear();
            treeView.Nodes.Add(treeRoot);
            treeView.ExpandAll();
        }
    }
}
