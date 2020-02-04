namespace 仓库管理系统
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTSBtn = new System.Windows.Forms.ToolStripButton();
            this.subTSBtn = new System.Windows.Forms.ToolStripButton();
            this.delTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sidebarTSBtn = new System.Windows.Forms.ToolStripButton();
            this.selectTSBtn = new System.Windows.Forms.ToolStripButton();
            this.selectTSTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Size = new System.Drawing.Size(800, 32);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Size = new System.Drawing.Size(118, 418);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSBtn,
            this.subTSBtn,
            this.delTSBtn,
            this.toolStripSeparator1,
            this.sidebarTSBtn,
            this.selectTSBtn,
            this.selectTSTxt,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTSBtn
            // 
            this.addTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("addTSBtn.Image")));
            this.addTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTSBtn.Name = "addTSBtn";
            this.addTSBtn.Size = new System.Drawing.Size(76, 22);
            this.addTSBtn.Text = "提升权限";
            this.addTSBtn.Click += new System.EventHandler(this.addTSBtn_Click);
            // 
            // subTSBtn
            // 
            this.subTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("subTSBtn.Image")));
            this.subTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.subTSBtn.Name = "subTSBtn";
            this.subTSBtn.Size = new System.Drawing.Size(76, 22);
            this.subTSBtn.Text = "降低权限";
            this.subTSBtn.Click += new System.EventHandler(this.subTSBtn_Click);
            // 
            // delTSBtn
            // 
            this.delTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("delTSBtn.Image")));
            this.delTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delTSBtn.Name = "delTSBtn";
            this.delTSBtn.Size = new System.Drawing.Size(76, 22);
            this.delTSBtn.Text = "删除权限";
            this.delTSBtn.Click += new System.EventHandler(this.delTSBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // selectTSBtn
            // 
            this.selectTSBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectTSBtn.Image")));
            this.selectTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectTSBtn.Name = "selectTSBtn";
            this.selectTSBtn.Size = new System.Drawing.Size(52, 22);
            this.selectTSBtn.Text = "查询";
            this.selectTSBtn.Click += new System.EventHandler(this.selectTSBtn_Click);
            // 
            // selectTSTxt
            // 
            this.selectTSTxt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectTSTxt.Name = "selectTSTxt";
            this.selectTSTxt.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "用户名/邮箱/电话：";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(116, 416);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
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
        private System.Windows.Forms.ToolStripButton subTSBtn;
        private System.Windows.Forms.ToolStripButton delTSBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sidebarTSBtn;
        private System.Windows.Forms.ToolStripTextBox selectTSTxt;
        private System.Windows.Forms.ToolStripButton selectTSBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}