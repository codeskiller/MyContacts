﻿namespace MyContacts.Forms
{
    partial class Login
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbCreateAccountLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Navy;
            this.lbUsername.Location = new System.Drawing.Point(114, 130);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(124, 29);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Navy;
            this.lbPassword.Location = new System.Drawing.Point(114, 223);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(120, 29);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignIn.Location = new System.Drawing.Point(269, 327);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(149, 42);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(269, 137);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(397, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(269, 230);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(397, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // lbCreateAccountLink
            // 
            this.lbCreateAccountLink.AutoSize = true;
            this.lbCreateAccountLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAccountLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbCreateAccountLink.Location = new System.Drawing.Point(511, 337);
            this.lbCreateAccountLink.Name = "lbCreateAccountLink";
            this.lbCreateAccountLink.Size = new System.Drawing.Size(155, 20);
            this.lbCreateAccountLink.TabIndex = 6;
            this.lbCreateAccountLink.TabStop = true;
            this.lbCreateAccountLink.Text = "Create an account?";
            this.lbCreateAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCreateAccountLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCreateAccountLink);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.LinkLabel lbCreateAccountLink;
    }
}