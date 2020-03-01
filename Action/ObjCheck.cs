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


        //重构的仓库检查
        public static bool WarehouseInfoCheck(TWarehouse warehouse,bool isAlter=false)
        {
            if (!RegexCheck.TextCheck(warehouse.Id, 10))
            {
                MessageBox.Show("仓库编号不可为空，且长度必须小于10个字符");
                return false;
            }
            if (MDIQuery.NoCheck(warehouse.Id, "Warehouse") > 0&& !isAlter)
            {
                MessageBox.Show("仓库编号已经存在，请更正仓库编号");
                return false;
            }
            if (!RegexCheck.TextCheck(warehouse.Name, 50))
            {
                MessageBox.Show("仓库名不可为空，且长度必须小于50个字符");
                return false;
            }
            if (!RegexCheck.TextCheck(warehouse.Address, 100))
            {
                MessageBox.Show("仓库地址不可为空，且长度必须小于100个字符");
                return false;
            }
            if (!RegexCheck.TelCheck(warehouse.Tel) && !RegexCheck.FixTelCheck(warehouse.Tel))
            {
                MessageBox.Show("电话或固话格式错误");
                return false;
            }
            if (!RegexCheck.TextCheck(warehouse.Contacts, 20))
            {
                MessageBox.Show("仓库联系人不可为空，且长度必须小于20个字符");
                return false;
            }
            if (!RegexCheck.TextLengthCheck(warehouse.Description, 2000))
            {
                MessageBox.Show("仓库备注长度必须小于2000个字符");
                return false;
            }
            return true;
        }
        
    }
}
