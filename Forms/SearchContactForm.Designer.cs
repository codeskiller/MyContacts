
namespace MyContacts
{
    partial class SearchContactForm
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
            this.lbSearchContacts = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCellPhone = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSearchContacts
            // 
            this.lbSearchContacts.AutoSize = true;
            this.lbSearchContacts.Location = new System.Drawing.Point(401, 27);
            this.lbSearchContacts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchContacts.Name = "lbSearchContacts";
            this.lbSearchContacts.Size = new System.Drawing.Size(112, 17);
            this.lbSearchContacts.TabIndex = 0;
            this.lbSearchContacts.Text = "Search Contacts";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(73, 79);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbCellPhone
            // 
            this.lbCellPhone.AutoSize = true;
            this.lbCellPhone.Location = new System.Drawing.Point(43, 129);
            this.lbCellPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCellPhone.Name = "lbCellPhone";
            this.lbCellPhone.Size = new System.Drawing.Size(76, 17);
            this.lbCellPhone.TabIndex = 2;
            this.lbCellPhone.Text = "Cell Phone";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(64, 182);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 17);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Results";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(167, 79);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(541, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCellPhone.Location = new System.Drawing.Point(167, 126);
            this.tbCellPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(541, 22);
            this.tbCellPhone.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(753, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(167, 182);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(541, 356);
            this.tbResult.TabIndex = 7;
            this.tbResult.Text = "";
            // 
            // SearchContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 554);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCellPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbCellPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSearchContacts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchContactForm";
            this.Text = "SearchContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearchContacts;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCellPhone;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox tbResult;
    }
}