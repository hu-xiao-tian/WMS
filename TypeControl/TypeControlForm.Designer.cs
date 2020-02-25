namespace 仓库管理系统
{
    partial class TypeControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeControlForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomGBox = new System.Windows.Forms.GroupBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftgBox = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.leftTStrip = new System.Windows.Forms.ToolStrip();
            this.addTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.alterTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.delTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightgBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rightTStrip = new System.Windows.Forms.ToolStrip();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.typeNameLab = new System.Windows.Forms.ToolStripLabel();
            this.typeNameTxt = new System.Windows.Forms.ToolStripTextBox();
            this.typeRankLab = new System.Windows.Forms.ToolStripLabel();
            this.typeRankTxt = new System.Windows.Forms.ToolStripTextBox();
            this.insertBtn = new System.Windows.Forms.ToolStripButton();
            this.alterBtn = new System.Windows.Forms.ToolStripButton();
            this.idLab = new System.Windows.Forms.ToolStripLabel();
            this.treeCMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftgBox.SuspendLayout();
            this.leftTStrip.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightgBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rightTStrip.SuspendLayout();
            this.treeCMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.bottomGBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 382);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(784, 80);
            this.bottomPanel.TabIndex = 0;
            // 
            // bottomGBox
            // 
            this.bottomGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomGBox.Location = new System.Drawing.Point(0, 0);
            this.bottomGBox.Name = "bottomGBox";
            this.bottomGBox.Size = new System.Drawing.Size(784, 80);
            this.bottomGBox.TabIndex = 1;
            this.bottomGBox.TabStop = false;
            this.bottomGBox.Text = "帮助说明";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftgBox);
            this.leftPanel.Controls.Add(this.leftTStrip);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 382);
            this.leftPanel.TabIndex = 1;
            // 
            // leftgBox
            // 
            this.leftgBox.Controls.Add(this.treeView);
            this.leftgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftgBox.Location = new System.Drawing.Point(0, 0);
            this.leftgBox.Name = "leftgBox";
            this.leftgBox.Size = new System.Drawing.Size(200, 357);
            this.leftgBox.TabIndex = 3;
            this.leftgBox.TabStop = false;
            this.leftgBox.Text = "类型展示";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 17);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(194, 337);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // leftTStrip
            // 
            this.leftTStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftTStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTypeBtn,
            this.alterTypeBtn,
            this.delTypeBtn});
            this.leftTStrip.Location = new System.Drawing.Point(0, 357);
            this.leftTStrip.Name = "leftTStrip";
            this.leftTStrip.Size = new System.Drawing.Size(200, 25);
            this.leftTStrip.TabIndex = 2;
            this.leftTStrip.Text = "toolStrip1";
            // 
            // addTypeBtn
            // 
            this.addTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("addTypeBtn.Image")));
            this.addTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTypeBtn.Name = "addTypeBtn";
            this.addTypeBtn.Size = new System.Drawing.Size(52, 22);
            this.addTypeBtn.Text = "新增";
            this.addTypeBtn.Click += new System.EventHandler(this.addTypeBtn_Click);
            // 
            // alterTypeBtn
            // 
            this.alterTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("alterTypeBtn.Image")));
            this.alterTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterTypeBtn.Name = "alterTypeBtn";
            this.alterTypeBtn.Size = new System.Drawing.Size(52, 22);
            this.alterTypeBtn.Text = "修改";
            this.alterTypeBtn.Click += new System.EventHandler(this.alterTypeBtn_Click);
            // 
            // delTypeBtn
            // 
            this.delTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("delTypeBtn.Image")));
            this.delTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delTypeBtn.Name = "delTypeBtn";
            this.delTypeBtn.Size = new System.Drawing.Size(52, 22);
            this.delTypeBtn.Text = "删除";
            this.delTypeBtn.Click += new System.EventHandler(this.delTypeBtn_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightgBox);
            this.rightPanel.Controls.Add(this.rightTStrip);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(584, 382);
            this.rightPanel.TabIndex = 2;
            // 
            // rightgBox
            // 
            this.rightgBox.Controls.Add(this.dataGridView1);
            this.rightgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightgBox.Location = new System.Drawing.Point(0, 0);
            this.rightgBox.Name = "rightgBox";
            this.rightgBox.Size = new System.Drawing.Size(584, 357);
            this.rightgBox.TabIndex = 4;
            this.rightgBox.TabStop = false;
            this.rightgBox.Text = "类型数据";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(578, 337);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // rightTStrip
            // 
            this.rightTStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightTStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBtn,
            this.typeNameLab,
            this.typeNameTxt,
            this.typeRankLab,
            this.typeRankTxt,
            this.insertBtn,
            this.alterBtn,
            this.idLab});
            this.rightTStrip.Location = new System.Drawing.Point(0, 357);
            this.rightTStrip.Name = "rightTStrip";
            this.rightTStrip.Size = new System.Drawing.Size(584, 25);
            this.rightTStrip.TabIndex = 3;
            this.rightTStrip.Text = "toolStrip2";
            // 
            // saveBtn
            // 
            this.saveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(52, 22);
            this.saveBtn.Text = "保存";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // typeNameLab
            // 
            this.typeNameLab.Name = "typeNameLab";
            this.typeNameLab.Size = new System.Drawing.Size(68, 22);
            this.typeNameLab.Text = "类型名称：";
            // 
            // typeNameTxt
            // 
            this.typeNameTxt.Name = "typeNameTxt";
            this.typeNameTxt.Size = new System.Drawing.Size(100, 25);
            // 
            // typeRankLab
            // 
            this.typeRankLab.Name = "typeRankLab";
            this.typeRankLab.Size = new System.Drawing.Size(68, 22);
            this.typeRankLab.Text = "类型排序：";
            // 
            // typeRankTxt
            // 
            this.typeRankTxt.Name = "typeRankTxt";
            this.typeRankTxt.Size = new System.Drawing.Size(100, 25);
            // 
            // insertBtn
            // 
            this.insertBtn.Image = ((System.Drawing.Image)(resources.GetObject("insertBtn.Image")));
            this.insertBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(52, 22);
            this.insertBtn.Text = "插入";
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // alterBtn
            // 
            this.alterBtn.Image = ((System.Drawing.Image)(resources.GetObject("alterBtn.Image")));
            this.alterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterBtn.Name = "alterBtn";
            this.alterBtn.Size = new System.Drawing.Size(52, 22);
            this.alterBtn.Text = "修改";
            this.alterBtn.Click += new System.EventHandler(this.alterBtn_Click);
            // 
            // idLab
            // 
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(40, 22);
            this.idLab.Text = "idLab";
            // 
            // treeCMStrip
            // 
            this.treeCMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.treeCMStrip.Name = "treeCMStrip";
            this.treeCMStrip.Size = new System.Drawing.Size(101, 70);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // TypeControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "TypeControlForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.bottomPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftgBox.ResumeLayout(false);
            this.leftTStrip.ResumeLayout(false);
            this.leftTStrip.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.rightgBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rightTStrip.ResumeLayout(false);
            this.rightTStrip.PerformLayout();
            this.treeCMStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.GroupBox bottomGBox;
        public System.Windows.Forms.ToolStrip leftTStrip;
        private System.Windows.Forms.ToolStripButton alterTypeBtn;
        private System.Windows.Forms.ToolStripButton delTypeBtn;
        public System.Windows.Forms.ToolStrip rightTStrip;
        public System.Windows.Forms.GroupBox leftgBox;
        public System.Windows.Forms.GroupBox rightgBox;
        public System.Windows.Forms.ContextMenuStrip treeCMStrip;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TreeView treeView;
        public System.Windows.Forms.ToolStripButton addTypeBtn;
        public System.Windows.Forms.ToolStripLabel typeNameLab;
        public System.Windows.Forms.ToolStripTextBox typeNameTxt;
        public System.Windows.Forms.ToolStripLabel typeRankLab;
        public System.Windows.Forms.ToolStripTextBox typeRankTxt;
        public System.Windows.Forms.ToolStripButton insertBtn;
        public System.Windows.Forms.ToolStripButton alterBtn;
        public System.Windows.Forms.ToolStripButton saveBtn;
        public System.Windows.Forms.ToolStripLabel idLab;
    }
}