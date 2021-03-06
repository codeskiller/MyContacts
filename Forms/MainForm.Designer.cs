﻿
namespace MyContacts
{
    partial class MainForm
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
            this.btn_AllContact = new System.Windows.Forms.Button();
            this.btn_NewContact = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_ContactBook = new System.Windows.Forms.Label();
            this.btn_SearchContact = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AllContact
            // 
            this.btn_AllContact.BackColor = System.Drawing.Color.Transparent;
            this.btn_AllContact.FlatAppearance.BorderSize = 0;
            this.btn_AllContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AllContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AllContact.Location = new System.Drawing.Point(13, 138);
            this.btn_AllContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AllContact.Name = "btn_AllContact";
            this.btn_AllContact.Size = new System.Drawing.Size(202, 60);
            this.btn_AllContact.TabIndex = 0;
            this.btn_AllContact.Text = "All Contacts";
            this.btn_AllContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AllContact.UseVisualStyleBackColor = false;
            this.btn_AllContact.Click += new System.EventHandler(this.btn_AllContact_Click);
            // 
            // btn_NewContact
            // 
            this.btn_NewContact.FlatAppearance.BorderSize = 0;
            this.btn_NewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewContact.ForeColor = System.Drawing.Color.White;
            this.btn_NewContact.Location = new System.Drawing.Point(13, 303);
            this.btn_NewContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NewContact.Name = "btn_NewContact";
            this.btn_NewContact.Size = new System.Drawing.Size(202, 47);
            this.btn_NewContact.TabIndex = 2;
            this.btn_NewContact.Text = "New Contact";
            this.btn_NewContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewContact.UseVisualStyleBackColor = true;
            this.btn_NewContact.Click += new System.EventHandler(this.btn_NewContact_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(13, 382);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(202, 46);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "Settings";
            this.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.ForeColor = System.Drawing.Color.White;
            this.btn_Info.Location = new System.Drawing.Point(13, 456);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(202, 38);
            this.btn_Info.TabIndex = 4;
            this.btn_Info.Text = "Info";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainPanel.Location = new System.Drawing.Point(251, 2);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(812, 551);
            this.MainPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.lb_ContactBook);
            this.panel2.Controls.Add(this.btn_AllContact);
            this.panel2.Controls.Add(this.btn_SearchContact);
            this.panel2.Controls.Add(this.btn_Info);
            this.panel2.Controls.Add(this.btn_NewContact);
            this.panel2.Controls.Add(this.btn_Setting);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 550);
            this.panel2.TabIndex = 6;
            // 
            // lb_ContactBook
            // 
            this.lb_ContactBook.AutoSize = true;
            this.lb_ContactBook.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ContactBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ContactBook.Location = new System.Drawing.Point(13, 63);
            this.lb_ContactBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ContactBook.Name = "lb_ContactBook";
            this.lb_ContactBook.Size = new System.Drawing.Size(230, 33);
            this.lb_ContactBook.TabIndex = 0;
            this.lb_ContactBook.Text = "Contact Book";
            // 
            // btn_SearchContact
            // 
            this.btn_SearchContact.FlatAppearance.BorderSize = 0;
            this.btn_SearchContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchContact.ForeColor = System.Drawing.Color.White;
            this.btn_SearchContact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchContact.Location = new System.Drawing.Point(13, 215);
            this.btn_SearchContact.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchContact.Name = "btn_SearchContact";
            this.btn_SearchContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SearchContact.Size = new System.Drawing.Size(202, 62);
            this.btn_SearchContact.TabIndex = 1;
            this.btn_SearchContact.Text = "Search Contact";
            this.btn_SearchContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchContact.UseVisualStyleBackColor = true;
            this.btn_SearchContact.Click += new System.EventHandler(this.btn_SearchContact_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Contact Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AllContact;
        private System.Windows.Forms.Button btn_SearchContact;
        private System.Windows.Forms.Button btn_NewContact;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_ContactBook;
    }
}

