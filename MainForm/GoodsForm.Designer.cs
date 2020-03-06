namespace 仓库管理系统
{
    partial class GoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.inWarehouseTSBtn = new System.Windows.Forms.ToolStripButton();
            this.alterTSBtn = new System.Windows.Forms.ToolStripButton();
            this.outWarehouseTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.outputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sidebarTSBtn = new System.Windows.Forms.ToolStripButton();
            this.imageTSBtn = new System.Windows.Forms.ToolStripButton();
            this.treeView = new System.Windows.Forms.TreeView();
            this.editBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Controls.Add(this.selectTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editBtn);
            this.panel3.Controls.Add(this.treeView);
            this.panel3.Size = new System.Drawing.Size(125, 373);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inWarehouseTSBtn,
            this.alterTSBtn,
            this.outWarehouseTSBtn,
            this.toolStripSeparator1,
            this.inputTSBtn,
            this.outputTSBtn,
            this.toolStripSeparator2,
            this.sidebarTSBtn,
            this.imageTSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // inWarehouseTSBtn
            // 
            this.inWarehouseTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("inWarehouseTSBtn.Image")));
            this.inWarehouseTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inWarehouseTSBtn.Name = "inWarehouseTSBtn";
            this.inWarehouseTSBtn.Size = new System.Drawing.Size(52, 22);
            this.inWarehouseTSBtn.Text = "入库";
            this.inWarehouseTSBtn.Click += new System.EventHandler(this.inWarehouseTSBtn_Click);
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
            // outWarehouseTSBtn
            // 
            this.outWarehouseTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("outWarehouseTSBtn.Image")));
            this.outWarehouseTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outWarehouseTSBtn.Name = "outWarehouseTSBtn";
            this.outWarehouseTSBtn.Size = new System.Drawing.Size(52, 22);
            this.outWarehouseTSBtn.Text = "出库";
            this.outWarehouseTSBtn.Click += new System.EventHandler(this.outWarehouseTSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // inputTSBtn
            // 
            this.inputTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("inputTSBtn.Image")));
            this.inputTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inputTSBtn.Name = "inputTSBtn";
            this.inputTSBtn.Size = new System.Drawing.Size(52, 22);
            this.inputTSBtn.Text = "导入";
            this.inputTSBtn.Click += new System.EventHandler(this.inputTSBtn_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sidebarTSBtn
            // 
            this.sidebarTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("sidebarTSBtn.Image")));
            this.sidebarTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sidebarTSBtn.Name = "sidebarTSBtn";
            this.sidebarTSBtn.Size = new System.Drawing.Size(76, 22);
            this.sidebarTSBtn.Text = "隐藏侧边";
            this.sidebarTSBtn.Click += new System.EventHandler(this.sidebarTSBtn_Click);
            // 
            // imageTSBtn
            // 
            this.imageTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("imageTSBtn.Image")));
            this.imageTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageTSBtn.Name = "imageTSBtn";
            this.imageTSBtn.Size = new System.Drawing.Size(76, 22);
            this.imageTSBtn.Text = "显示图片";
            this.imageTSBtn.Click += new System.EventHandler(this.imageTSBtn_Click);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(123, 371);
            this.treeView.TabIndex = 3;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editBtn.Location = new System.Drawing.Point(0, 348);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "编辑类型";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(334, 41);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 13;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(166, 42);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "商品名称/拼音码/条形码：";
            // 
            // GoodsForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton inWarehouseTSBtn;
        private System.Windows.Forms.ToolStripButton outWarehouseTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton inputTSBtn;
        private System.Windows.Forms.ToolStripButton outputTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton sidebarTSBtn;
        private System.Windows.Forms.ToolStripButton imageTSBtn;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton alterTSBtn;
    }
}