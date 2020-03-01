namespace 仓库管理系统
{
    partial class ManageWarehouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addrTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.contactsTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.isUseCheckBox = new System.Windows.Forms.CheckBox();
            this.isDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.areaTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.isDefaultCheckBox);
            this.panel1.Controls.Add(this.isUseCheckBox);
            this.panel1.Controls.Add(this.contactsTxt);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.areaTxt);
            this.panel1.Controls.Add(this.addrTxt);
            this.panel1.Controls.Add(this.descriptionTxt);
            this.panel1.Controls.Add(this.telTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.noTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(520, 334);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(296, 367);
            // 
            // saveAlterBtn
            // 
            this.saveAlterBtn.Location = new System.Drawing.Point(205, 367);
            this.saveAlterBtn.Click += new System.EventHandler(this.saveAlterBtn_Click);
            // 
            // saveAddBtn
            // 
            this.saveAddBtn.Location = new System.Drawing.Point(124, 367);
            this.saveAddBtn.Click += new System.EventHandler(this.saveAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "仓库名称：";
            // 
            // noTxt
            // 
            this.noTxt.Location = new System.Drawing.Point(123, 25);
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(136, 21);
            this.noTxt.TabIndex = 1;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(349, 25);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(130, 21);
            this.nameTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "地址：";
            // 
            // addrTxt
            // 
            this.addrTxt.Location = new System.Drawing.Point(123, 74);
            this.addrTxt.Name = "addrTxt";
            this.addrTxt.Size = new System.Drawing.Size(356, 21);
            this.addrTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "联系人：";
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(123, 120);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(136, 21);
            this.telTxt.TabIndex = 1;
            // 
            // contactsTxt
            // 
            this.contactsTxt.Location = new System.Drawing.Point(349, 120);
            this.contactsTxt.Name = "contactsTxt";
            this.contactsTxt.Size = new System.Drawing.Size(130, 21);
            this.contactsTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "启用：";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(123, 209);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(356, 63);
            this.descriptionTxt.TabIndex = 1;
            // 
            // isUseCheckBox
            // 
            this.isUseCheckBox.AutoSize = true;
            this.isUseCheckBox.Location = new System.Drawing.Point(123, 297);
            this.isUseCheckBox.Name = "isUseCheckBox";
            this.isUseCheckBox.Size = new System.Drawing.Size(156, 16);
            this.isUseCheckBox.TabIndex = 2;
            this.isUseCheckBox.Text = "停用后不会出现在单据中";
            this.isUseCheckBox.UseVisualStyleBackColor = true;
            this.isUseCheckBox.CheckedChanged += new System.EventHandler(this.isUseCheckBox_CheckedChanged);
            // 
            // isDefaultCheckBox
            // 
            this.isDefaultCheckBox.AutoSize = true;
            this.isDefaultCheckBox.Location = new System.Drawing.Point(312, 297);
            this.isDefaultCheckBox.Name = "isDefaultCheckBox";
            this.isDefaultCheckBox.Size = new System.Drawing.Size(48, 16);
            this.isDefaultCheckBox.TabIndex = 2;
            this.isDefaultCheckBox.Text = "默认";
            this.isDefaultCheckBox.UseVisualStyleBackColor = true;
            this.isDefaultCheckBox.CheckedChanged += new System.EventHandler(this.isDefaultCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "面积：";
            // 
            // areaTxt
            // 
            this.areaTxt.Location = new System.Drawing.Point(123, 166);
            this.areaTxt.Name = "areaTxt";
            this.areaTxt.Size = new System.Drawing.Size(356, 21);
            this.areaTxt.TabIndex = 1;
            // 
            // ManageWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 414);
            this.Name = "ManageWarehouse";
            this.Text = "ManageWarehouse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isDefaultCheckBox;
        private System.Windows.Forms.CheckBox isUseCheckBox;
        private System.Windows.Forms.TextBox contactsTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox addrTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areaTxt;
        private System.Windows.Forms.Label label8;
    }
}