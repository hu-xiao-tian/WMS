namespace 仓库管理系统
{
    partial class GoodsTemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsTemplateForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTSBtn = new System.Windows.Forms.ToolStripButton();
            this.alterTSBtn = new System.Windows.Forms.ToolStripButton();
            this.delTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.outputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sidebarTSBtn = new System.Windows.Forms.ToolStripButton();
            this.imageTSBtn = new System.Windows.Forms.ToolStripButton();
            this.selectTSBtn = new System.Windows.Forms.ToolStripButton();
            this.selectTSTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Size = new System.Drawing.Size(800, 42);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editBtn);
            this.panel3.Controls.Add(this.treeView);
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Size = new System.Drawing.Size(125, 408);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSBtn,
            this.alterTSBtn,
            this.delTSBtn,
            this.toolStripSeparator1,
            this.inputTSBtn,
            this.outputTSBtn,
            this.toolStripSeparator2,
            this.sidebarTSBtn,
            this.imageTSBtn,
            this.selectTSBtn,
            this.selectTSTxt,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTSBtn
            // 
            this.addTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("addTSBtn.Image")));
            this.addTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTSBtn.Name = "addTSBtn";
            this.addTSBtn.Size = new System.Drawing.Size(52, 37);
            this.addTSBtn.Text = "新增";
            this.addTSBtn.Click += new System.EventHandler(this.addTSBtn_Click);
            // 
            // alterTSBtn
            // 
            this.alterTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("alterTSBtn.Image")));
            this.alterTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterTSBtn.Name = "alterTSBtn";
            this.alterTSBtn.Size = new System.Drawing.Size(52, 37);
            this.alterTSBtn.Text = "修改";
            this.alterTSBtn.Click += new System.EventHandler(this.alterTSBtn_Click);
            // 
            // delTSBtn
            // 
            this.delTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("delTSBtn.Image")));
            this.delTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delTSBtn.Name = "delTSBtn";
            this.delTSBtn.Size = new System.Drawing.Size(52, 37);
            this.delTSBtn.Text = "删除";
            this.delTSBtn.Click += new System.EventHandler(this.delTSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // inputTSBtn
            // 
            this.inputTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("inputTSBtn.Image")));
            this.inputTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inputTSBtn.Name = "inputTSBtn";
            this.inputTSBtn.Size = new System.Drawing.Size(52, 37);
            this.inputTSBtn.Text = "导入";
            this.inputTSBtn.Click += new System.EventHandler(this.inputTSBtn_Click);
            // 
            // outputTSBtn
            // 
            this.outputTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("outputTSBtn.Image")));
            this.outputTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outputTSBtn.Name = "outputTSBtn";
            this.outputTSBtn.Size = new System.Drawing.Size(52, 37);
            this.outputTSBtn.Text = "导出";
            this.outputTSBtn.Click += new System.EventHandler(this.outputTSBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // sidebarTSBtn
            // 
            this.sidebarTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("sidebarTSBtn.Image")));
            this.sidebarTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sidebarTSBtn.Name = "sidebarTSBtn";
            this.sidebarTSBtn.Size = new System.Drawing.Size(76, 37);
            this.sidebarTSBtn.Text = "隐藏侧边";
            this.sidebarTSBtn.Click += new System.EventHandler(this.sidebarTSBtn_Click);
            // 
            // imageTSBtn
            // 
            this.imageTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("imageTSBtn.Image")));
            this.imageTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageTSBtn.Name = "imageTSBtn";
            this.imageTSBtn.Size = new System.Drawing.Size(76, 37);
            this.imageTSBtn.Text = "显示图片";
            this.imageTSBtn.Click += new System.EventHandler(this.imageTSBtn_Click);
            // 
            // selectTSBtn
            // 
            this.selectTSBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectTSBtn.Image")));
            this.selectTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectTSBtn.Name = "selectTSBtn";
            this.selectTSBtn.Size = new System.Drawing.Size(52, 37);
            this.selectTSBtn.Text = "查询";
            this.selectTSBtn.Click += new System.EventHandler(this.selectTSBtn_Click);
            // 
            // selectTSTxt
            // 
            this.selectTSTxt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectTSTxt.Name = "selectTSTxt";
            this.selectTSTxt.Size = new System.Drawing.Size(150, 40);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripLabel1.Text = "商品名称/拼音码/条形码：";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(123, 406);
            this.treeView.TabIndex = 2;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editBtn.Location = new System.Drawing.Point(0, 383);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "编辑类型";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // GoodsTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GoodsTemplateForm";
            this.Text = "GoodsTemplateForm";
            this.Load += new System.EventHandler(this.GoodsTemplateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTSBtn;
        private System.Windows.Forms.ToolStripButton alterTSBtn;
        private System.Windows.Forms.ToolStripButton delTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton inputTSBtn;
        private System.Windows.Forms.ToolStripButton outputTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton sidebarTSBtn;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripButton selectTSBtn;
        private System.Windows.Forms.ToolStripTextBox selectTSTxt;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton imageTSBtn;
    }
}