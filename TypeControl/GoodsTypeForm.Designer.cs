namespace 仓库管理系统
{
    partial class GoodsTypeForm
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
            this.leftgBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomGBox
            // 
            this.bottomGBox.Size = new System.Drawing.Size(800, 80);
            // 
            // leftgBox
            // 
            this.leftgBox.Size = new System.Drawing.Size(243, 357);
            // 
            // rightgBox
            // 
            this.rightgBox.Size = new System.Drawing.Size(557, 357);
            // 
            // treeView
            // 
            this.treeView.LineColor = System.Drawing.Color.Black;
            this.treeView.Size = new System.Drawing.Size(237, 337);
            // 
            // GoodsTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Name = "GoodsTypeForm";
            this.Text = "GoodsTypeForm";
            this.Load += new System.EventHandler(this.GoodsTypeForm_Load);
            this.leftgBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}