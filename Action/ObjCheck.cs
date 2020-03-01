using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    class ObjCheck
    {
        public static bool CheckSupplier(TSupplier supplier)
        {
            bool result = true;
            if (!RegexCheck.EmailCheck(supplier.Email))
            {
                result = false;
                MessageBox.Show("邮箱格式错误");
            }
            if (!RegexCheck.TelCheck(supplier.Tel)&&!RegexCheck.FixTelCheck(supplier.Tel))
            {
                result = false;
                MessageBox.Show("电话或固话格式错误");
            }
            return result;
        }
        public static bool CheckClient(TClient client)
        {
            bool result = true;
            if (!RegexCheck.EmailCheck(client.Email))
            {
                result = false;
                MessageBox.Show("邮箱格式错误");
            }
            if (!RegexCheck.TelCheck(client.Tel) && !RegexCheck.FixTelCheck(client.Tel))
            {
                result = false;
                MessageBox.Show("电话或固话格式错误");
            }
            return result;
        }
    }
}
