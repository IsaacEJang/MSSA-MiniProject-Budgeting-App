﻿namespace MiniProject___Budgetting_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxUserPassword = new RichTextBox();
            buttonLogin = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            linkLabelCreateAccount = new LinkLabel();
            linkLabelForgotPassword = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            TitleLabel1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxUserPassword
            // 
            richTextBoxUserPassword.Location = new Point(28, 146);
            richTextBoxUserPassword.Name = "richTextBoxUserPassword";
            richTextBoxUserPassword.Size = new Size(450, 38);
            richTextBoxUserPassword.TabIndex = 4;
            richTextBoxUserPassword.Text = "";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.SeaShell;
            buttonLogin.Location = new Point(158, 217);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(175, 46);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Sign In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(linkLabelCreateAccount);
            groupBox1.Controls.Add(richTextBoxUserPassword);
            groupBox1.Controls.Add(linkLabelForgotPassword);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 353);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 121);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 38);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelCreateAccount.Location = new Point(28, 303);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(207, 23);
            linkLabelCreateAccount.TabIndex = 7;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Don't have an account?";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelForgotPassword.Location = new Point(317, 303);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(161, 23);
            linkLabelForgotPassword.TabIndex = 6;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(57, 91);
            label3.Name = "label3";
            label3.Size = new Size(424, 68);
            label3.TabIndex = 7;
            label3.Text = "Welcome Back!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaShell;
            label4.Location = new Point(195, 51);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 8;
            label4.Text = "PennyPal";
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.SeaShell;
            TitleLabel1.Location = new Point(235, 9);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(57, 42);
            TitleLabel1.TabIndex = 0;
            TitleLabel1.Text = "💰";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 553);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TitleLabel1);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBoxUserPassword;
        private Button buttonLogin;
        private GroupBox groupBox1;
        private LinkLabel linkLabelForgotPassword;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabelCreateAccount;
        private Label label3;
        private Label label4;
        private Label TitleLabel1;
    }
}
