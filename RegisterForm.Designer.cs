namespace 仓库管理系统
{
    partial class RegisterForm
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.emailLab = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLab = new System.Windows.Forms.Label();
            this.userPWLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userNicknameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.codeLab = new System.Windows.Forms.Label();
            this.userPWTxt = new System.Windows.Forms.TextBox();
            this.userTelTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userTelLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(159, 243);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(182, 21);
            this.emailTxt.TabIndex = 0;
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // emailCodeTxt
            // 
            this.emailCodeTxt.Location = new System.Drawing.Point(159, 303);
            this.emailCodeTxt.MaxLength = 6;
            this.emailCodeTxt.Name = "emailCodeTxt";
            this.emailCodeTxt.Size = new System.Drawing.Size(100, 21);
            this.emailCodeTxt.TabIndex = 1;
            // 
            // sendEmailCode
            // 
            this.sendEmailCode.Location = new System.Drawing.Point(266, 300);
            this.sendEmailCode.Name = "sendEmailCode";
            this.sendEmailCode.Size = new System.Drawing.Size(75, 23);
            this.sendEmailCode.TabIndex = 2;
            this.sendEmailCode.Text = "发送";
            this.sendEmailCode.UseVisualStyleBackColor = true;
            this.sendEmailCode.Click += new System.EventHandler(this.sendEmailCode_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(159, 369);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "注册";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // emailLab
            // 
            this.emailLab.AutoSize = true;
            this.emailLab.Location = new System.Drawing.Point(157, 279);
            this.emailLab.Name = "emailLab";
            this.emailLab.Size = new System.Drawing.Size(41, 12);
            this.emailLab.TabIndex = 4;
            this.emailLab.Text = "label1";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(159, 22);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(182, 21);
            this.userNameTxt.TabIndex = 5;
            this.userNameTxt.Leave += new System.EventHandler(this.userNameTxt_Leave);
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Location = new System.Drawing.Point(157, 58);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(41, 12);
            this.userNameLab.TabIndex = 6;
            this.userNameLab.Text = "label2";
            // 
            // userPWLab
            // 
            this.userPWLab.AutoSize = true;
            this.userPWLab.Location = new System.Drawing.Point(157, 122);
            this.userPWLab.Name = "userPWLab";
            this.userPWLab.Size = new System.Drawing.Size(41, 12);
            this.userPWLab.TabIndex = 6;
            this.userPWLab.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "昵称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Code";
            // 
            // userNicknameTxt
            // 
            this.userNicknameTxt.Location = new System.Drawing.Point(159, 153);
            this.userNicknameTxt.Name = "userNicknameTxt";
            this.userNicknameTxt.Size = new System.Drawing.Size(182, 21);
            this.userNicknameTxt.TabIndex = 7;
            this.userNicknameTxt.TextChanged += new System.EventHandler(this.userNicknameTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "密码：";
            // 
            // codeLab
            // 
            this.codeLab.AutoSize = true;
            this.codeLab.Location = new System.Drawing.Point(157, 340);
            this.codeLab.Name = "codeLab";
            this.codeLab.Size = new System.Drawing.Size(41, 12);
            this.codeLab.TabIndex = 4;
            this.codeLab.Text = "label1";
            // 
            // userPWTxt
            // 
            this.userPWTxt.Location = new System.Drawing.Point(159, 86);
            this.userPWTxt.Name = "userPWTxt";
            this.userPWTxt.Size = new System.Drawing.Size(182, 21);
            this.userPWTxt.TabIndex = 8;
            this.userPWTxt.Leave += new System.EventHandler(this.userPWTxt_Leave);
            // 
            // userTelTxt
            // 
            this.userTelTxt.Location = new System.Drawing.Point(159, 197);
            this.userTelTxt.MaxLength = 11;
            this.userTelTxt.Name = "userTelTxt";
            this.userTelTxt.Size = new System.Drawing.Size(182, 21);
            this.userTelTxt.TabIndex = 10;
            this.userTelTxt.TextChanged += new System.EventHandler(this.userTelTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "电话：";
            // 
            // userTelLab
            // 
            this.userTelLab.AutoSize = true;
            this.userTelLab.Location = new System.Drawing.Point(157, 221);
            this.userTelLab.Name = "userTelLab";
            this.userTelLab.Size = new System.Drawing.Size(41, 12);
            this.userTelLab.TabIndex = 6;
            this.userTelLab.Text = "label2";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 420);
            this.Controls.Add(this.userTelTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPWTxt);
            this.Controls.Add(this.userNicknameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userTelLab);
            this.Controls.Add(this.userPWLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userNameLab);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.codeLab);
            this.Controls.Add(this.emailLab);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.sendEmailCode);
            this.Controls.Add(this.emailCodeTxt);
            this.Controls.Add(this.emailTxt);
            this.Name = "RegisterForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox emailCodeTxt;
        private System.Windows.Forms.Button sendEmailCode;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label userNameLab;
        private System.Windows.Forms.Label userPWLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userNicknameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label codeLab;
        private System.Windows.Forms.TextBox userPWTxt;
        private System.Windows.Forms.TextBox userTelTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userTelLab;
    }
}