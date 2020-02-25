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
    public partial class ManageForm : Form
    {
        TLoginUser loginUser = new TLoginUser();
        public ManageForm(TLoginUser loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
        }
        public ManageForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
