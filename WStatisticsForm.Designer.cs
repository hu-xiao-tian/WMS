namespace 仓库管理系统
{
    partial class WStatisticsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.outPutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Size = new System.Drawing.Size(800, 46);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Size = new System.Drawing.Size(0, 404);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outPutBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.selectTxt);
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(393, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 44);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "日期编号：";
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(154, 14);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 15;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(322, 13);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // outPutBtn
            // 
            this.outPutBtn.Location = new System.Drawing.Point(3, 11);
            this.outPutBtn.Name = "outPutBtn";
            this.outPutBtn.Size = new System.Drawing.Size(75, 23);
            this.outPutBtn.TabIndex = 23;
            this.outPutBtn.Text = "导出到表格";
            this.outPutBtn.UseVisualStyleBackColor = true;
            this.outPutBtn.Click += new System.EventHandler(this.outPutBtn_Click);
            // 
            // WStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "WStatisticsForm";
            this.Text = "WStatisticsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button outPutBtn;
    }
}