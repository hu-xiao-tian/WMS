using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仓库管理系统.Template;

namespace 仓库管理系统
{
    public partial class CompanyInfo : Form
    {
        TLoginUser loginUser =new TLoginUser();
        public CompanyInfo(TLoginUser loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
            if (loginUser.UserLV < 4)
            {
                saveBtn.Enabled = false;
                uploadBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = IOStream.OpenImage();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool isSaveImage = true;
            if (pictureBox.Image!=null)
            {
                isSaveImage = IOStream.SaveImage("Date/Image/", pictureBox.Image, "CompanyPicture.jpg");
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(nameTxt.Text);
            sb.AppendLine(contactTxt.Text);
            sb.AppendLine(provinceTxt.Text);
            sb.AppendLine(cityTxt.Text);
            sb.AppendLine(townTxt.Text);
            sb.AppendLine(telTxt.Text);
            sb.AppendLine(addrTxt.Text);
            bool isSaveText = IOStream.SaveText("Date/Text/", sb.ToString(), "公司信息.txt");
            if(isSaveImage&&isSaveText)
            {
                MessageBox.Show("保存成功");
            }
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            string imgPath = "Date/Image/CompanyPicture.jpg";
            string companyInfoPath = "Date/Text/公司信息.txt";
            if (File.Exists(imgPath))
            {
                pictureBox.ImageLocation= imgPath;
            }
            if (File.Exists(companyInfoPath))
            {
                string[] companyInfo=File.ReadAllLines(companyInfoPath);
                nameTxt.Text = companyInfo[0];
                contactTxt.Text= companyInfo[1];
                provinceTxt.Text= companyInfo[2];
                cityTxt.Text= companyInfo[3];
                townTxt.Text= companyInfo[4];
                telTxt.Text= companyInfo[5];
                addrTxt.Text= companyInfo[6];
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string imgPath = "Date/Image/CompanyPicture.jpg";
            if (pictureBox.Image != null && !File.Exists(imgPath))
            {
                pictureBox.ImageLocation = "";

            }else if (IOStream.DeleteFile(imgPath))
            {
                pictureBox.ImageLocation = "";
            }
        }
    }
}
