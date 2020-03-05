using System;
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
    public partial class ImageShowForm : Form
    {
        public ImageShowForm()
        {
            InitializeComponent();
        }
        public ImageShowForm(string imgPath)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = $"Date/Image/Goods/{imgPath}";
        }
    }
}
