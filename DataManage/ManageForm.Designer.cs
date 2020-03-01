namespace 仓库管理系统
{
    partial class ManageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveAddBtn = new System.Windows.Forms.Button();
            this.saveAlterBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(808, 294);
            this.panel1.TabIndex = 0;
            // 
            // saveAddBtn
            // 
            this.saveAddBtn.Location = new System.Drawing.Point(24, 361);
            this.saveAddBtn.Name = "saveAddBtn";
            this.saveAddBtn.Size = new System.Drawing.Size(75, 23);
            this.saveAddBtn.TabIndex = 1;
            this.saveAddBtn.Text = "保存新增";
            this.saveAddBtn.UseVisualStyleBackColor = true;
            // 
            // saveAlterBtn
            // 
            this.saveAlterBtn.Location = new System.Drawing.Point(105, 361);
            this.saveAlterBtn.Name = "saveAlterBtn";
            this.saveAlterBtn.Size = new System.Drawing.Size(75, 23);
            this.saveAlterBtn.TabIndex = 1;
            this.saveAlterBtn.Text = "保存修改";
            this.saveAlterBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(196, 361);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 412);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveAlterBtn);
            this.Controls.Add(this.saveAddBtn);
            this.Controls.Add(this.panel1);
            this.Name = "ManageForm";
            this.Text = "dataForm";
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button closeBtn;
        protected System.Windows.Forms.Button saveAlterBtn;
        protected System.Windows.Forms.Button saveAddBtn;
    }
}