using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;
using System.Threading;

namespace 仓库管理系统
{
    class InputFormAction
    {
        /// <summary>
        /// 子线程新建窗体委托
        /// </summary>
        /// <param name="myform">要创建的子窗体</param>
        /// <param name="fatherForm">当前父窗体</param>
        public delegate void SetShowInputFormInvoke(Form myform, Form fatherForm);
        public static void SetShowInputForm(Form myForm,Form fatherForm)
        {
            if (fatherForm.InvokeRequired)
            {
                SetShowInputFormInvoke setShowInputFormInvoke = new SetShowInputFormInvoke(SetShowInputForm);
                fatherForm.Invoke(setShowInputFormInvoke, new object[] { myForm, fatherForm });
            }
            else
            {
                myForm.Show();
            }
        }
        /// <summary>
        /// 供应商导入
        /// </summary>
        /// <param name="suppliers"></param>
        /// <param name="fatherForm"></param>
        /// <param name="dataGridView"></param>
        /// <param name="treeView"></param>
        public static void InputSupplier(List<TSupplier> suppliers, Form fatherForm,DataGridView dataGridView,TreeView treeView)
        {
            var multi = new MultiThreadWork();
            multi.DoMultiWork((s) =>
            {
                for (int i = 0; i < s.Count; i++)
                {
                    ManageSupplier1 manageSupplier1 = new ManageSupplier1(s[i], dataGridView, treeView);
                    manageSupplier1.StartPosition = FormStartPosition.CenterScreen;
                    manageSupplier1.Text = "供应商导入检查窗口";
                    SetShowInputForm(manageSupplier1,fatherForm);
                    while (true)
                    {
                        if (manageSupplier1.IsDisposed)
                        {
                            break;
                        }
                        Thread.Sleep(200);
                    }
                } 
            }, suppliers);
        }
        /// <summary>
        /// 客户导入
        /// </summary>
        /// <param name="suppliers"></param>
        /// <param name="fatherForm"></param>
        /// <param name="dataGridView"></param>
        /// <param name="treeView"></param>
        public static void InputClient(List<TClient> clients, Form fatherForm, DataGridView dataGridView, TreeView treeView)
        {
            var multi = new MultiThreadWork();
            multi.DoMultiWork((c) =>
            {
                for (int i = 0; i < c.Count; i++)
                {
                    ManageClient1 manageClient1 = new ManageClient1(c[i], dataGridView, treeView);
                    manageClient1.StartPosition = FormStartPosition.CenterScreen;
                    manageClient1.Text = "客户导入检查窗口";
                    SetShowInputForm(manageClient1, fatherForm);
                    while (true)
                    {
                        if (manageClient1.IsDisposed)
                        {
                            break;
                        }
                        Thread.Sleep(200);
                    }
                }
            }, clients);
        }
        /// <summary>
        /// 商品模板导入
        /// </summary>
        /// <param name="suppliers"></param>
        /// <param name="fatherForm"></param>
        /// <param name="dataGridView"></param>
        /// <param name="treeView"></param>
        public static void InputGoodsTemplate(List<TGoodsTemplate> goodsTemplates, Form fatherForm, DataGridView dataGridView, TreeView treeView)
        {
            var multi = new MultiThreadWork();
            multi.DoMultiWork((g) =>
            {
                for (int i = 0; i < g.Count; i++)
                {
                    ManageGoodsTemplate1 manageGoodsTemplate1 = new ManageGoodsTemplate1(g[i], dataGridView, treeView);
                    manageGoodsTemplate1.StartPosition = FormStartPosition.CenterScreen;
                    manageGoodsTemplate1.Text = "商品模板导入检查窗口";

                    SetShowInputForm(manageGoodsTemplate1, fatherForm);
                    while (true)
                    {
                        if (manageGoodsTemplate1.IsDisposed)
                        {
                            break;
                        }
                        Thread.Sleep(200);
                    }
                }
            }, goodsTemplates);
        }
        /// <summary>
        /// 商品导入
        /// </summary>
        /// <param name="suppliers"></param>
        /// <param name="fatherForm"></param>
        /// <param name="dataGridView"></param>
        /// <param name="treeView"></param>
        public static void InputGoods(List<TGoods> goods, Form fatherForm, DataGridView dataGridView, TreeView treeView)
        {
            var multi = new MultiThreadWork();
            multi.DoMultiWork((g) =>
            {
                for (int i = 0; i < g.Count; i++)
                {
                    ManageGoods1 manageGoods = new ManageGoods1(g[i], dataGridView, treeView);
                    manageGoods.StartPosition = FormStartPosition.CenterScreen;
                    manageGoods.Text = "商品导入检查窗口";

                    SetShowInputForm(manageGoods, fatherForm);
                    while (true)
                    {
                        if (manageGoods.IsDisposed)
                        {
                            break;
                        }
                        Thread.Sleep(200);
                    }
                }
            }, goods);
        }
    }
}
