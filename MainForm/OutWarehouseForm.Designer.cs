namespace 仓库管理系统
{
    partial class OutWarehouseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.outPutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Size = new System.Drawing.Size(800, 35);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Size = new System.Drawing.Size(0, 415);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.selectBtn);
            this.panel2.Controls.Add(this.selectTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(398, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 33);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "名称/拼音/条形码：";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(319, 5);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(129, 7);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(184, 21);
            this.selectTxt.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.outPutBtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.endDTP);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.startDTP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 33);
            this.panel4.TabIndex = 2;
            // 
            // outPutBtn
            // 
            this.outPutBtn.Location = new System.Drawing.Point(317, 3);
            this.outPutBtn.Name = "outPutBtn";
            this.outPutBtn.Size = new System.Drawing.Size(75, 23);
            this.outPutBtn.TabIndex = 22;
            this.outPutBtn.Text = "导出到表格";
            this.outPutBtn.UseVisualStyleBackColor = true;
            this.outPutBtn.Click += new System.EventHandler(this.outPutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "到：";
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(203, 4);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(108, 21);
            this.endDTP.TabIndex = 2;
            this.endDTP.ValueChanged += new System.EventHandler(this.endDTP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "从：";
            // 
            // startDTP
            // 
            this.startDTP.Location = new System.Drawing.Point(46, 4);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(108, 21);
            this.startDTP.TabIndex = 0;
            this.startDTP.ValueChanged += new System.EventHandler(this.startDTP_ValueChanged);
            // 
            // OutWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "OutWarehouseForm";
            this.Text = "OutWarehouseForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button outPutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDTP;
    }
}