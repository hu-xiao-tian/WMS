namespace 仓库管理系统
{
    partial class FindPasswordForm
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
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailCodeTxt = new System.Windows.Forms.TextBox();
            this.sendEmailCode = new System.Windows.Forms.Button();
            this.userPWTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userPWTxt2 = new System.Windows.Forms.TextBox();
            this.alterPWBtn = new System.Windows.Forms.Button();
            this.userPWLab = new System.Windows.Forms.Label();
            this.emailLab = new System.Windows.Forms.Label();
            this.codeLab = new System.Windows.Forms.Label();
            this.userPWLab2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(168, 36);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(181, 21);
            this.emailTxt.TabIndex = 0;
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // emailCodeTxt
            // 
            this.emailCodeTxt.Location = new System.Drawing.Point(168, 81);
            this.emailCodeTxt.Name = "emailCodeTxt";
            this.emailCodeTxt.Size = new System.Drawing.Size(100, 21);
            this.emailCodeTxt.TabIndex = 1;
            // 
            // sendEmailCode
            // 
            this.sendEmailCode.Location = new System.Drawing.Point(274, 79);
            this.sendEmailCode.Name = "sendEmailCode";
            this.sendEmailCode.Size = new System.Drawing.Size(75, 23);
            this.sendEmailCode.TabIndex = 2;
            this.sendEmailCode.Text = "发送";
            this.sendEmailCode.UseVisualStyleBackColor = true;
            this.sendEmailCode.Click += new System.EventHandler(this.sendEmailCode_Click);
            // 
            // userPWTxt
            // 
            this.userPWTxt.Location = new System.Drawing.Point(168, 135);
            this.userPWTxt.Name = "userPWTxt";
            this.userPWTxt.Size = new System.Drawing.Size(181, 21);
            this.userPWTxt.TabIndex = 3;
            this.userPWTxt.Leave += new System.EventHandler(this.userPWTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "注册邮箱：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "验证码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码验证：";
            // 
            // userPWTxt2
            // 
            this.userPWTxt2.Location = new System.Drawing.Point(168, 181);
            this.userPWTxt2.Name = "userPWTxt2";
            this.userPWTxt2.Size = new System.Drawing.Size(181, 21);
            this.userPWTxt2.TabIndex = 5;
            this.userPWTxt2.TextChanged += new System.EventHandler(this.userPWTxt2_TextChanged);
            // 
            // alterPWBtn
            // 
            this.alterPWBtn.Location = new System.Drawing.Point(168, 225);
            this.alterPWBtn.Name = "alterPWBtn";
            this.alterPWBtn.Size = new System.Drawing.Size(181, 23);
            this.alterPWBtn.TabIndex = 7;
            this.alterPWBtn.Text = "改密";
            this.alterPWBtn.UseVisualStyleBackColor = true;
            this.alterPWBtn.Click += new System.EventHandler(this.alterPWBtn_Click);
            // 
            // userPWLab
            // 
            this.userPWLab.AutoSize = true;
            this.userPWLab.Location = new System.Drawing.Point(166, 159);
            this.userPWLab.Name = "userPWLab";
            this.userPWLab.Size = new System.Drawing.Size(41, 12);
            this.userPWLab.TabIndex = 8;
            this.userPWLab.Text = "label2";
            // 
            // emailLab
            // 
            this.emailLab.AutoSize = true;
            this.emailLab.Location = new System.Drawing.Point(166, 60);
            this.emailLab.Name = "emailLab";
            this.emailLab.Size = new System.Drawing.Size(41, 12);
            this.emailLab.TabIndex = 9;
            this.emailLab.Text = "label2";
            // 
            // codeLab
            // 
            this.codeLab.AutoSize = true;
            this.codeLab.Location = new System.Drawing.Point(166, 105);
            this.codeLab.Name = "codeLab";
            this.codeLab.Size = new System.Drawing.Size(41, 12);
            this.codeLab.TabIndex = 8;
            this.codeLab.Text = "label2";
            // 
            // userPWLab2
            // 
            this.userPWLab2.AutoSize = true;
            this.userPWLab2.Location = new System.Drawing.Point(166, 210);
            this.userPWLab2.Name = "userPWLab2";
            this.userPWLab2.Size = new System.Drawing.Size(41, 12);
            this.userPWLab2.TabIndex = 8;
            this.userPWLab2.Text = "label2";
            // 
            // FindPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.codeLab);
            this.Controls.Add(this.userPWLab2);
            this.Controls.Add(this.userPWLab);
            this.Controls.Add(this.emailLab);
            this.Controls.Add(this.alterPWBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPWTxt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPWTxt);
            this.Controls.Add(this.sendEmailCode);
            this.Controls.Add(this.emailCodeTxt);
            this.Controls.Add(this.emailTxt);
            this.Name = "FindPasswordForm";
            this.Text = "FindPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox emailCodeTxt;
        private System.Windows.Forms.Button sendEmailCode;
        private System.Windows.Forms.TextBox userPWTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userPWTxt2;
        private System.Windows.Forms.Button alterPWBtn;
        private System.Windows.Forms.Label userPWLab;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.Label codeLab;
        private System.Windows.Forms.Label userPWLab2;
    }
}