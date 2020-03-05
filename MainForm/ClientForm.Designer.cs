namespace 仓库管理系统
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTSBtn = new System.Windows.Forms.ToolStripButton();
            this.alterTSBtn = new System.Windows.Forms.ToolStripButton();
            this.delTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.outputTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sidebarTSBtn = new System.Windows.Forms.ToolStripButton();
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
            this.panel1.Size = new System.Drawing.Size(800, 71);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editBtn);
            this.panel3.Controls.Add(this.treeView);
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Size = new System.Drawing.Size(125, 379);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSBtn,
            this.alterTSBtn,
            this.delTSBtn,
            this.toolStripSeparator1,
            this.inputTSBtn,
            this.outputTSBtn,
            this.toolStripSeparator2,
            this.sidebarTSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            this.delTSBtn.Click += new System.EventHandler(this.delTSBtn_Click);
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
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(123, 377);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editBtn.Location = new System.Drawing.Point(0, 354);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(123, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "编辑类型";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(260, 32);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 10;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(92, 33);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "名称/拼音码：";
            // 
            // ClientForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
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
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Label label1;
    }
}