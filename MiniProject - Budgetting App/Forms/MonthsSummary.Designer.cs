﻿namespace MiniProject___Budgetting_App
{
    partial class MonthsSummary
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
            label1 = new Label();
            label7 = new Label();
            buttonBackHome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 19;
            label1.Text = "💸";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(105, 62);
            label7.Name = "label7";
            label7.Size = new Size(337, 45);
            label7.TabIndex = 17;
            label7.Text = "Month's Summary";
            // 
            // buttonBackHome
            // 
            buttonBackHome.BackColor = SystemColors.ActiveCaption;
            buttonBackHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackHome.ForeColor = Color.SeaShell;
            buttonBackHome.Location = new Point(12, 12);
            buttonBackHome.Name = "buttonBackHome";
            buttonBackHome.Size = new Size(49, 49);
            buttonBackHome.TabIndex = 20;
            buttonBackHome.Text = "↩️";
            buttonBackHome.UseVisualStyleBackColor = false;
            buttonBackHome.Click += buttonBackHome_Click_1;
            // 
            // MonthsSummary
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 553);
            Controls.Add(buttonBackHome);
            Controls.Add(label1);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MonthsSummary";
            Text = "Month's Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button buttonBackHome;
    }
}