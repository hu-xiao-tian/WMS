using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

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
                for (int i = 0; i < suppliers.Count; i++)
                {
                    ManageSupplier1 manageSupplier1 = new ManageSupplier1(suppliers[i], dataGridView, treeView);
                    manageSupplier1.StartPosition = FormStartPosition.CenterScreen;
                    manageSupplier1.Text = "供应商导入检查窗口";
                    SetShowInputForm(manageSupplier1,fatherForm);
                    while (true)
                    {
                        if (manageSupplier1.IsDisposed)
                        {
                            break;
                        }

                    }
                }
            }, suppliers);
        }
    }
}
