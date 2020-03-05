namespace 仓库管理系统
{
    partial class ManageGoods2
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outWarehouseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outWTCBox = new System.Windows.Forms.ComboBox();
            this.clientNameTxt = new System.Windows.Forms.TextBox();
            this.priceLab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceLab);
            this.panel1.Controls.Add(this.clientNameTxt);
            this.panel1.Controls.Add(this.outWTCBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Controls.Add(this.selectTxt);
            this.panel1.Controls.Add(this.label1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeView);
            this.panel3.Size = new System.Drawing.Size(125, 385);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(123, 383);
            this.treeView.TabIndex = 2;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(270, 48);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(112, 23);
            this.selectBtn.TabIndex = 13;
            this.selectBtn.Text = "查询";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(102, 49);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(162, 21);
            this.selectTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "名称/拼音码：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outWarehouseBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(598, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 75);
            this.panel2.TabIndex = 14;
            // 
            // outWarehouseBtn
            // 
            this.outWarehouseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outWarehouseBtn.Location = new System.Drawing.Point(0, 0);
            this.outWarehouseBtn.Name = "outWarehouseBtn";
            this.outWarehouseBtn.Size = new System.Drawing.Size(200, 75);
            this.outWarehouseBtn.TabIndex = 0;
            this.outWarehouseBtn.Text = "出库";
            this.outWarehouseBtn.UseVisualStyleBackColor = true;
            this.outWarehouseBtn.Click += new System.EventHandler(this.outWarehouseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "出库类型：";
            // 
            // outWTCBox
            // 
            this.outWTCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outWTCBox.FormattingEnabled = true;
            this.outWTCBox.Items.AddRange(new object[] {
            "销售",
            "损坏"});
            this.outWTCBox.Location = new System.Drawing.Point(103, 8);
            this.outWTCBox.Name = "outWTCBox";
            this.outWTCBox.Size = new System.Drawing.Size(161, 20);
            this.outWTCBox.TabIndex = 16;
            this.outWTCBox.TextChanged += new System.EventHandler(this.outWTCBox_TextChanged);
            // 
            // clientNameTxt
            // 
            this.clientNameTxt.Location = new System.Drawing.Point(271, 8);
            this.clientNameTxt.Name = "clientNameTxt";
            this.clientNameTxt.ReadOnly = true;
            this.clientNameTxt.Size = new System.Drawing.Size(111, 21);
            this.clientNameTxt.TabIndex = 17;
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(400, 12);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(65, 12);
            this.priceLab.TabIndex = 18;
            this.priceLab.Text = "销售总价：";
            // 
            // ManageGoods2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Name = "ManageGoods2";
            this.Text = "ManageGoods2";
            this.Load += new System.EventHandler(this.ManageGoods2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button outWarehouseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox outWTCBox;
        private System.Windows.Forms.TextBox clientNameTxt;
        private System.Windows.Forms.Label priceLab;
    }
}