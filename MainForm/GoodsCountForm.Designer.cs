namespace 仓库管理系统
{
    partial class GoodsCountForm
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
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EffectiveTimeCBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.outPutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Size = new System.Drawing.Size(830, 46);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Size = new System.Drawing.Size(0, 404);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(342, 13);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(174, 14);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品名称/拼音码/条形码：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.selectTxt);
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(399, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 44);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "剩余有效期：";
            // 
            // EffectiveTimeCBox
            // 
            this.EffectiveTimeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EffectiveTimeCBox.FormattingEnabled = true;
            this.EffectiveTimeCBox.Items.AddRange(new object[] {
            "全部",
            "90",
            "60",
            "30"});
            this.EffectiveTimeCBox.Location = new System.Drawing.Point(96, 14);
            this.EffectiveTimeCBox.Name = "EffectiveTimeCBox";
            this.EffectiveTimeCBox.Size = new System.Drawing.Size(121, 20);
            this.EffectiveTimeCBox.TabIndex = 19;
            this.EffectiveTimeCBox.TextChanged += new System.EventHandler(this.EffectiveTimeCBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.outPutBtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.EffectiveTimeCBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 44);
            this.panel4.TabIndex = 20;
            // 
            // outPutBtn
            // 
            this.outPutBtn.Location = new System.Drawing.Point(234, 13);
            this.outPutBtn.Name = "outPutBtn";
            this.outPutBtn.Size = new System.Drawing.Size(75, 23);
            this.outPutBtn.TabIndex = 21;
            this.outPutBtn.Text = "导出到表格";
            this.outPutBtn.UseVisualStyleBackColor = true;
            this.outPutBtn.Click += new System.EventHandler(this.outPutBtn_Click);
            // 
            // GoodsCountForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Name = "GoodsCountForm";
            this.Text = "GoodsCountForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EffectiveTimeCBox;
        private System.Windows.Forms.Button outPutBtn;
    }
}