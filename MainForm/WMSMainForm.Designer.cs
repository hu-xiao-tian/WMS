namespace 仓库管理系统
{
    partial class WMSMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMSMainForm));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.商品库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供货商类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供货商资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutTool = new System.Windows.Forms.ToolStrip();
            this.商品资料TSB = new System.Windows.Forms.ToolStripButton();
            this.客户资料TSB = new System.Windows.Forms.ToolStripButton();
            this.供应商资料TSB = new System.Windows.Forms.ToolStripButton();
            this.仓库资料TSB = new System.Windows.Forms.ToolStripButton();
            this.商品库存TSB = new System.Windows.Forms.ToolStripButton();
            this.统计报表TSB = new System.Windows.Forms.ToolStripButton();
            this.workPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.bottomTool = new System.Windows.Forms.ToolStrip();
            this.portraitPictureBox = new System.Windows.Forms.ToolStripButton();
            this.lvLab = new System.Windows.Forms.ToolStripLabel();
            this.userIdLab = new System.Windows.Forms.ToolStripLabel();
            this.nicknameLab = new System.Windows.Forms.ToolStripLabel();
            this.onLineTime = new System.Windows.Forms.ToolStripLabel();
            this.topMenu.SuspendLayout();
            this.shortcutTool.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.bottomTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem,
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.统计报表ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topMenu.Size = new System.Drawing.Size(1006, 25);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公司信息ToolStripMenuItem,
            this.仓库设置ToolStripMenuItem});
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            // 
            // 公司信息ToolStripMenuItem
            // 
            this.公司信息ToolStripMenuItem.Name = "公司信息ToolStripMenuItem";
            this.公司信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.公司信息ToolStripMenuItem.Text = "公司信息";
            this.公司信息ToolStripMenuItem.Click += new System.EventHandler(this.公司信息ToolStripMenuItem_Click);
            // 
            // 仓库设置ToolStripMenuItem
            // 
            this.仓库设置ToolStripMenuItem.Name = "仓库设置ToolStripMenuItem";
            this.仓库设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.仓库设置ToolStripMenuItem.Text = "仓库设置";
            this.仓库设置ToolStripMenuItem.Click += new System.EventHandler(this.仓库设置ToolStripMenuItem_Click);
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品类型ToolStripMenuItem,
            this.商品资料ToolStripMenuItem,
            this.toolStripSeparator4,
            this.商品库存ToolStripMenuItem,
            this.商品模板ToolStripMenuItem});
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.入库管理ToolStripMenuItem.Text = "商品管理";
            // 
            // 商品类型ToolStripMenuItem
            // 
            this.商品类型ToolStripMenuItem.Name = "商品类型ToolStripMenuItem";
            this.商品类型ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.商品类型ToolStripMenuItem.Text = "商品类型";
            this.商品类型ToolStripMenuItem.Click += new System.EventHandler(this.商品类型ToolStripMenuItem_Click);
            // 
            // 商品资料ToolStripMenuItem
            // 
            this.商品资料ToolStripMenuItem.Name = "商品资料ToolStripMenuItem";
            this.商品资料ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.商品资料ToolStripMenuItem.Text = "商品资料";
            this.商品资料ToolStripMenuItem.Click += new System.EventHandler(this.商品资料ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // 商品库存ToolStripMenuItem
            // 
            this.商品库存ToolStripMenuItem.Name = "商品库存ToolStripMenuItem";
            this.商品库存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.商品库存ToolStripMenuItem.Text = "商品库存";
            this.商品库存ToolStripMenuItem.Click += new System.EventHandler(this.商品库存ToolStripMenuItem_Click);
            // 
            // 商品模板ToolStripMenuItem
            // 
            this.商品模板ToolStripMenuItem.Name = "商品模板ToolStripMenuItem";
            this.商品模板ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.商品模板ToolStripMenuItem.Text = "商品模板";
            this.商品模板ToolStripMenuItem.Click += new System.EventHandler(this.商品模板ToolStripMenuItem_Click);
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.供货商类型ToolStripMenuItem,
            this.供货商资料ToolStripMenuItem});
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.出库管理ToolStripMenuItem.Text = "供货商管理";
            // 
            // 供货商类型ToolStripMenuItem
            // 
            this.供货商类型ToolStripMenuItem.Name = "供货商类型ToolStripMenuItem";
            this.供货商类型ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.供货商类型ToolStripMenuItem.Text = "供货商类型";
            this.供货商类型ToolStripMenuItem.Click += new System.EventHandler(this.供应商类型ToolStripMenuItem_Click);
            // 
            // 供货商资料ToolStripMenuItem
            // 
            this.供货商资料ToolStripMenuItem.Name = "供货商资料ToolStripMenuItem";
            this.供货商资料ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.供货商资料ToolStripMenuItem.Text = "供货商资料";
            this.供货商资料ToolStripMenuItem.Click += new System.EventHandler(this.供应商资料ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户类型ToolStripMenuItem,
            this.客户资料ToolStripMenuItem});
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存管理ToolStripMenuItem.Text = "客户管理";
            // 
            // 客户类型ToolStripMenuItem
            // 
            this.客户类型ToolStripMenuItem.Name = "客户类型ToolStripMenuItem";
            this.客户类型ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.客户类型ToolStripMenuItem.Text = "客户类型";
            this.客户类型ToolStripMenuItem.Click += new System.EventHandler(this.客户类型ToolStripMenuItem_Click);
            // 
            // 客户资料ToolStripMenuItem
            // 
            this.客户资料ToolStripMenuItem.Name = "客户资料ToolStripMenuItem";
            this.客户资料ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.客户资料ToolStripMenuItem.Text = "客户资料";
            this.客户资料ToolStripMenuItem.Click += new System.EventHandler(this.客户资料ToolStripMenuItem_Click);
            // 
            // 统计报表ToolStripMenuItem
            // 
            this.统计报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库检查ToolStripMenuItem,
            this.出库检查ToolStripMenuItem,
            this.库存检查ToolStripMenuItem});
            this.统计报表ToolStripMenuItem.Name = "统计报表ToolStripMenuItem";
            this.统计报表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.统计报表ToolStripMenuItem.Text = "出入库";
            // 
            // 入库检查ToolStripMenuItem
            // 
            this.入库检查ToolStripMenuItem.Name = "入库检查ToolStripMenuItem";
            this.入库检查ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.入库检查ToolStripMenuItem.Text = "入库检查";
            this.入库检查ToolStripMenuItem.Click += new System.EventHandler(this.入库检查ToolStripMenuItem_Click);
            // 
            // 出库检查ToolStripMenuItem
            // 
            this.出库检查ToolStripMenuItem.Name = "出库检查ToolStripMenuItem";
            this.出库检查ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.出库检查ToolStripMenuItem.Text = "出库检查";
            this.出库检查ToolStripMenuItem.Click += new System.EventHandler(this.出库检查ToolStripMenuItem_Click);
            // 
            // 库存检查ToolStripMenuItem
            // 
            this.库存检查ToolStripMenuItem.Name = "库存检查ToolStripMenuItem";
            this.库存检查ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.库存检查ToolStripMenuItem.Text = "统计报表";
            this.库存检查ToolStripMenuItem.Click += new System.EventHandler(this.库存检查ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 操作员设置ToolStripMenuItem
            // 
            this.操作员设置ToolStripMenuItem.Name = "操作员设置ToolStripMenuItem";
            this.操作员设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.操作员设置ToolStripMenuItem.Text = "操作员设置";
            this.操作员设置ToolStripMenuItem.Click += new System.EventHandler(this.操作员设置ToolStripMenuItem_Click);
            // 
            // shortcutTool
            // 
            this.shortcutTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品资料TSB,
            this.客户资料TSB,
            this.供应商资料TSB,
            this.仓库资料TSB,
            this.商品库存TSB,
            this.统计报表TSB});
            this.shortcutTool.Location = new System.Drawing.Point(0, 25);
            this.shortcutTool.Name = "shortcutTool";
            this.shortcutTool.Size = new System.Drawing.Size(1006, 40);
            this.shortcutTool.TabIndex = 1;
            this.shortcutTool.Text = "shortcutTool";
            // 
            // 商品资料TSB
            // 
            this.商品资料TSB.Image = ((System.Drawing.Image)(resources.GetObject("商品资料TSB.Image")));
            this.商品资料TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.商品资料TSB.Name = "商品资料TSB";
            this.商品资料TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.商品资料TSB.Size = new System.Drawing.Size(60, 37);
            this.商品资料TSB.Text = "商品资料";
            this.商品资料TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.商品资料TSB.Click += new System.EventHandler(this.商品资料TSB_Click);
            // 
            // 客户资料TSB
            // 
            this.客户资料TSB.Image = ((System.Drawing.Image)(resources.GetObject("客户资料TSB.Image")));
            this.客户资料TSB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.客户资料TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.客户资料TSB.Name = "客户资料TSB";
            this.客户资料TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.客户资料TSB.Size = new System.Drawing.Size(60, 37);
            this.客户资料TSB.Text = "客户资料";
            this.客户资料TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.客户资料TSB.Click += new System.EventHandler(this.客户资料TSB_Click);
            // 
            // 供应商资料TSB
            // 
            this.供应商资料TSB.Image = ((System.Drawing.Image)(resources.GetObject("供应商资料TSB.Image")));
            this.供应商资料TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.供应商资料TSB.Name = "供应商资料TSB";
            this.供应商资料TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.供应商资料TSB.Size = new System.Drawing.Size(72, 37);
            this.供应商资料TSB.Text = "供应商资料";
            this.供应商资料TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.供应商资料TSB.Click += new System.EventHandler(this.供应商资料TSB_Click);
            // 
            // 仓库资料TSB
            // 
            this.仓库资料TSB.Image = ((System.Drawing.Image)(resources.GetObject("仓库资料TSB.Image")));
            this.仓库资料TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.仓库资料TSB.Name = "仓库资料TSB";
            this.仓库资料TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.仓库资料TSB.Size = new System.Drawing.Size(60, 37);
            this.仓库资料TSB.Text = "仓库设置";
            this.仓库资料TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.仓库资料TSB.Click += new System.EventHandler(this.仓库资料TSB_Click);
            // 
            // 商品库存TSB
            // 
            this.商品库存TSB.Image = ((System.Drawing.Image)(resources.GetObject("商品库存TSB.Image")));
            this.商品库存TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.商品库存TSB.Name = "商品库存TSB";
            this.商品库存TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.商品库存TSB.Size = new System.Drawing.Size(60, 37);
            this.商品库存TSB.Text = "商品库存";
            this.商品库存TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.商品库存TSB.Click += new System.EventHandler(this.商品库存TSB_Click);
            // 
            // 统计报表TSB
            // 
            this.统计报表TSB.Image = ((System.Drawing.Image)(resources.GetObject("统计报表TSB.Image")));
            this.统计报表TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.统计报表TSB.Name = "统计报表TSB";
            this.统计报表TSB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.统计报表TSB.Size = new System.Drawing.Size(60, 37);
            this.统计报表TSB.Text = "统计报表";
            this.统计报表TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.统计报表TSB.Click += new System.EventHandler(this.统计报表TSB_Click);
            // 
            // workPanel
            // 
            this.workPanel.Controls.Add(this.mainTabControl);
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 65);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(1006, 474);
            this.workPanel.TabIndex = 4;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(15, 3);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1006, 474);
            this.mainTabControl.TabIndex = 4;
            // 
            // bottomTool
            // 
            this.bottomTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portraitPictureBox,
            this.lvLab,
            this.userIdLab,
            this.nicknameLab,
            this.onLineTime});
            this.bottomTool.Location = new System.Drawing.Point(0, 539);
            this.bottomTool.Name = "bottomTool";
            this.bottomTool.Size = new System.Drawing.Size(1006, 25);
            this.bottomTool.TabIndex = 5;
            this.bottomTool.Text = "toolStrip1";
            // 
            // portraitPictureBox
            // 
            this.portraitPictureBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.portraitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("portraitPictureBox.Image")));
            this.portraitPictureBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.portraitPictureBox.Name = "portraitPictureBox";
            this.portraitPictureBox.Size = new System.Drawing.Size(23, 22);
            this.portraitPictureBox.Text = "头像";
            // 
            // lvLab
            // 
            this.lvLab.Name = "lvLab";
            this.lvLab.Size = new System.Drawing.Size(96, 22);
            this.lvLab.Text = "toolStripLabel1";
            // 
            // userIdLab
            // 
            this.userIdLab.Name = "userIdLab";
            this.userIdLab.Size = new System.Drawing.Size(96, 22);
            this.userIdLab.Text = "toolStripLabel2";
            // 
            // nicknameLab
            // 
            this.nicknameLab.Name = "nicknameLab";
            this.nicknameLab.Size = new System.Drawing.Size(96, 22);
            this.nicknameLab.Text = "toolStripLabel3";
            // 
            // onLineTime
            // 
            this.onLineTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.onLineTime.Name = "onLineTime";
            this.onLineTime.Size = new System.Drawing.Size(96, 22);
            this.onLineTime.Text = "toolStripLabel1";
            // 
            // WMSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 564);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.shortcutTool);
            this.Controls.Add(this.bottomTool);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "WMSMainForm";
            this.Text = "WMSMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WMSMainForm_FormClosed);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.shortcutTool.ResumeLayout(false);
            this.shortcutTool.PerformLayout();
            this.workPanel.ResumeLayout(false);
            this.bottomTool.ResumeLayout(false);
            this.bottomTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip shortcutTool;
        private System.Windows.Forms.ToolStripButton 商品资料TSB;
        private System.Windows.Forms.ToolStripButton 客户资料TSB;
        private System.Windows.Forms.ToolStripButton 供应商资料TSB;
        private System.Windows.Forms.ToolStripButton 仓库资料TSB;
        private System.Windows.Forms.ToolStripButton 商品库存TSB;
        private System.Windows.Forms.ToolStripMenuItem 操作员设置ToolStripMenuItem;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStrip bottomTool;
        private System.Windows.Forms.ToolStripLabel lvLab;
        private System.Windows.Forms.ToolStripLabel userIdLab;
        private System.Windows.Forms.ToolStripLabel nicknameLab;
        private System.Windows.Forms.ToolStripButton portraitPictureBox;
        private System.Windows.Forms.ToolStripLabel onLineTime;
        private System.Windows.Forms.ToolStripMenuItem 公司信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 统计报表TSB;
        private System.Windows.Forms.ToolStripMenuItem 入库检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供货商类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供货商资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 商品库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品模板ToolStripMenuItem;
    }
}