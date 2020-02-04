namespace 仓库管理系统
{
    partial class WarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            this.addTSBtn = new System.Windows.Forms.ToolStripButton();
            this.alterTSBtn = new System.Windows.Forms.ToolStripButton();
            this.delTSBtn = new System.Windows.Forms.ToolStripButton();
            this.outputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.FilterCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilterCheckBox);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Controls.Add(this.selectTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Size = new System.Drawing.Size(800, 63);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Size = new System.Drawing.Size(0, 387);
            // 
            // addTSBtn
            // 
            this.addTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("addTSBtn.Image")));
            this.addTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTSBtn.Name = "addTSBtn";
            this.addTSBtn.Size = new System.Drawing.Size(52, 22);
            this.addTSBtn.Text = "新增";
            this.addTSBtn.Click += new System.EventHandler(this.addTSBtn_Click);
            // 
            // alterTSBtn
            // 
            this.alterTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("alterTSBtn.Image")));
            this.alterTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterTSBtn.Name = "alterTSBtn";
            this.alterTSBtn.Size = new System.Drawing.Size(52, 22);
            this.alterTSBtn.Text = "修改";
            this.alterTSBtn.Click += new System.EventHandler(this.alterTSBtn_Click);
            // 
            // delTSBtn
            // 
            this.delTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("delTSBtn.Image")));
            this.delTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delTSBtn.Name = "delTSBtn";
            this.delTSBtn.Size = new System.Drawing.Size(52, 22);
            this.delTSBtn.Text = "删除";
            this.delTSBtn.ToolTipText = "删除";
            this.delTSBtn.Click += new System.EventHandler(this.delTSBtn_Click);
            // 
            // outputTSBtn
            // 
            this.outputTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("outputTSBtn.Image")));
            this.outputTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outputTSBtn.Name = "outputTSBtn";
            this.outputTSBtn.Size = new System.Drawing.Size(52, 22);
            this.outputTSBtn.Text = "导出";
            this.outputTSBtn.Click += new System.EventHandler(this.outputTSBtn_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "帮助";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSBtn,
            this.alterTSBtn,
            this.delTSBtn,
            this.outputTSBtn,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "仓库名称：";
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(65, 37);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 2;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(233, 36);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // FilterCheckBox
            // 
            this.FilterCheckBox.AutoSize = true;
            this.FilterCheckBox.Location = new System.Drawing.Point(323, 39);
            this.FilterCheckBox.Name = "FilterCheckBox";
            this.FilterCheckBox.Size = new System.Drawing.Size(72, 16);
            this.FilterCheckBox.TabIndex = 4;
            this.FilterCheckBox.Text = "筛选停用";
            this.FilterCheckBox.UseVisualStyleBackColor = true;
            this.FilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTSBtn;
        private System.Windows.Forms.ToolStripButton alterTSBtn;
        private System.Windows.Forms.ToolStripButton delTSBtn;
        private System.Windows.Forms.ToolStripButton outputTSBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.CheckBox FilterCheckBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Label label1;
    }
}