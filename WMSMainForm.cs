﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public partial class WMSMainForm : Form
    {
        LoginUser userName = new LoginUser();
        public WMSMainForm(LoginUser userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

    }
}
