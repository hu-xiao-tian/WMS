namespace 仓库管理系统
{
    partial class ManageForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upBtn = new System.Windows.Forms.Button();
            this.typeNameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rankNumTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.typeIdTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.downBtn = new System.Windows.Forms.Button();
            this.saveCloseBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.webSideTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.areaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pinyinCodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(246, 18);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 36);
            this.upBtn.TabIndex = 14;
            this.upBtn.Text = "上条记录";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // typeNameTxt
            // 
            this.typeNameTxt.Location = new System.Drawing.Point(84, 253);
            this.typeNameTxt.Name = "typeNameTxt";
            this.typeNameTxt.Size = new System.Drawing.Size(361, 21);
            this.typeNameTxt.TabIndex = 10;
            this.typeNameTxt.TextChanged += new System.EventHandler(this.typeNameTxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "类型名称：";
            // 
            // rankNumTxt
            // 
            this.rankNumTxt.Location = new System.Drawing.Point(84, 280);
            this.rankNumTxt.Name = "rankNumTxt";
            this.rankNumTxt.Size = new System.Drawing.Size(361, 21);
            this.rankNumTxt.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "排序码：";
            // 
            // typeIdTxt
            // 
            this.typeIdTxt.Location = new System.Drawing.Point(84, 226);
            this.typeIdTxt.Name = "typeIdTxt";
            this.typeIdTxt.Size = new System.Drawing.Size(361, 21);
            this.typeIdTxt.TabIndex = 9;
            this.typeIdTxt.TextChanged += new System.EventHandler(this.typeIdTxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "类型id：";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(84, 199);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(361, 21);
            this.emailTxt.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(84, 18);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 36);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "保存新增";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.downBtn);
            this.bottomPanel.Controls.Add(this.upBtn);
            this.bottomPanel.Controls.Add(this.saveCloseBtn);
            this.bottomPanel.Controls.Add(this.saveBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 327);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(480, 80);
            this.bottomPanel.TabIndex = 4;
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(327, 18);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 36);
            this.downBtn.TabIndex = 15;
            this.downBtn.Text = "下条记录";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // saveCloseBtn
            // 
            this.saveCloseBtn.Location = new System.Drawing.Point(165, 18);
            this.saveCloseBtn.Name = "saveCloseBtn";
            this.saveCloseBtn.Size = new System.Drawing.Size(75, 36);
            this.saveCloseBtn.TabIndex = 13;
            this.saveCloseBtn.Text = "保存关闭";
            this.saveCloseBtn.UseVisualStyleBackColor = true;
            this.saveCloseBtn.Click += new System.EventHandler(this.saveCloseBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "邮箱：";
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(84, 172);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(361, 21);
            this.telTxt.TabIndex = 7;
            // 
            // webSideTxt
            // 
            this.webSideTxt.Location = new System.Drawing.Point(84, 145);
            this.webSideTxt.Name = "webSideTxt";
            this.webSideTxt.Size = new System.Drawing.Size(361, 21);
            this.webSideTxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "官网：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "电话：";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.typeNameTxt);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.rankNumTxt);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.typeIdTxt);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.emailTxt);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.telTxt);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.webSideTxt);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.addressTxt);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.areaTxt);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.contactNameTxt);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.pinyinCodeTxt);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.companyNameTxt);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(480, 407);
            this.mainPanel.TabIndex = 5;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(84, 118);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(361, 21);
            this.addressTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "地址：";
            // 
            // areaTxt
            // 
            this.areaTxt.Location = new System.Drawing.Point(84, 91);
            this.areaTxt.Name = "areaTxt";
            this.areaTxt.Size = new System.Drawing.Size(361, 21);
            this.areaTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "所在区域：";
            // 
            // contactNameTxt
            // 
            this.contactNameTxt.Location = new System.Drawing.Point(84, 64);
            this.contactNameTxt.Name = "contactNameTxt";
            this.contactNameTxt.Size = new System.Drawing.Size(361, 21);
            this.contactNameTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "联系人：";
            // 
            // pinyinCodeTxt
            // 
            this.pinyinCodeTxt.Location = new System.Drawing.Point(84, 37);
            this.pinyinCodeTxt.Name = "pinyinCodeTxt";
            this.pinyinCodeTxt.Size = new System.Drawing.Size(361, 21);
            this.pinyinCodeTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "拼音码：";
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Location = new System.Drawing.Point(84, 10);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(361, 21);
            this.companyNameTxt.TabIndex = 1;
            this.companyNameTxt.TextChanged += new System.EventHandler(this.companyNameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称：";
            // 
            // ManageForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 407);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "ManageForm2";
            this.Text = "ManageForm2";
            this.bottomPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox companyNameTxt;
        public System.Windows.Forms.TextBox pinyinCodeTxt;
        public System.Windows.Forms.TextBox typeNameTxt;
        public System.Windows.Forms.TextBox rankNumTxt;
        public System.Windows.Forms.TextBox typeIdTxt;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox telTxt;
        public System.Windows.Forms.TextBox webSideTxt;
        public System.Windows.Forms.TextBox addressTxt;
        public System.Windows.Forms.TextBox areaTxt;
        public System.Windows.Forms.TextBox contactNameTxt;
        public System.Windows.Forms.Button upBtn;
        public System.Windows.Forms.Button downBtn;
        public System.Windows.Forms.Button saveCloseBtn;
    }
}