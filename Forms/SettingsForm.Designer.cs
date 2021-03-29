
namespace MyContacts
{
    partial class SettingsForm
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
            this.lbContactBookSettings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.rbtnDisableAccount = new System.Windows.Forms.RadioButton();
            this.rbtnEnableAccount = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContactBookSettings
            // 
            this.lbContactBookSettings.AutoSize = true;
            this.lbContactBookSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactBookSettings.Location = new System.Drawing.Point(322, 28);
            this.lbContactBookSettings.Name = "lbContactBookSettings";
            this.lbContactBookSettings.Size = new System.Drawing.Size(192, 24);
            this.lbContactBookSettings.TabIndex = 0;
            this.lbContactBookSettings.Text = "Contact Book Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Options";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(97, 137);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(57, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "UserName";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(111, 195);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // rbtnDisableAccount
            // 
            this.rbtnDisableAccount.AutoSize = true;
            this.rbtnDisableAccount.Location = new System.Drawing.Point(223, 86);
            this.rbtnDisableAccount.Name = "rbtnDisableAccount";
            this.rbtnDisableAccount.Size = new System.Drawing.Size(108, 17);
            this.rbtnDisableAccount.TabIndex = 5;
            this.rbtnDisableAccount.TabStop = true;
            this.rbtnDisableAccount.Text = "Disable Accounts";
            this.rbtnDisableAccount.UseVisualStyleBackColor = true;
            this.rbtnDisableAccount.CheckedChanged += new System.EventHandler(this.rbtnDisableAccount_CheckedChanged);
            // 
            // rbtnEnableAccount
            // 
            this.rbtnEnableAccount.AutoSize = true;
            this.rbtnEnableAccount.Location = new System.Drawing.Point(408, 86);
            this.rbtnEnableAccount.Name = "rbtnEnableAccount";
            this.rbtnEnableAccount.Size = new System.Drawing.Size(106, 17);
            this.rbtnEnableAccount.TabIndex = 6;
            this.rbtnEnableAccount.TabStop = true;
            this.rbtnEnableAccount.Text = "Enable Accounts";
            this.rbtnEnableAccount.UseVisualStyleBackColor = true;
            this.rbtnEnableAccount.CheckedChanged += new System.EventHandler(this.rbtnEnableAccount_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(223, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(493, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(493, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(223, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Settings";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 336);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.rbtnEnableAccount);
            this.Controls.Add(this.rbtnDisableAccount);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbContactBookSettings);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContactBookSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.RadioButton rbtnDisableAccount;
        private System.Windows.Forms.RadioButton rbtnEnableAccount;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdate;
    }
}