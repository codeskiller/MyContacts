﻿
namespace MyContacts
{
    partial class AllContactForm
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
            this.dataGridViewAllContact = new System.Windows.Forms.DataGridView();
            this.lbAllContacts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllContact
            // 
            this.dataGridViewAllContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllContact.Location = new System.Drawing.Point(28, 60);
            this.dataGridViewAllContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAllContact.Name = "dataGridViewAllContact";
            this.dataGridViewAllContact.Size = new System.Drawing.Size(1000, 479);
            this.dataGridViewAllContact.TabIndex = 0;
            this.dataGridViewAllContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllContact_CellContentClick);
            // 
            // lbAllContacts
            // 
            this.lbAllContacts.AutoSize = true;
            this.lbAllContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllContacts.Location = new System.Drawing.Point(471, 16);
            this.lbAllContacts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAllContacts.Name = "lbAllContacts";
            this.lbAllContacts.Size = new System.Drawing.Size(160, 31);
            this.lbAllContacts.TabIndex = 1;
            this.lbAllContacts.Text = "All Contacts";
            // 
            // AllContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbAllContacts);
            this.Controls.Add(this.dataGridViewAllContact);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllContactForm";
            this.Text = "AllContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllContact;
        private System.Windows.Forms.Label lbAllContacts;
    }
}