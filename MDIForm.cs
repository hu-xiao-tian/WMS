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
    public partial class MDIForm : Form
    {
        protected TLoginUser loginUser = new TLoginUser();
        public MDIForm(TLoginUser loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
        }
        public MDIForm()
        {
            InitializeComponent();
        }
    }
}
