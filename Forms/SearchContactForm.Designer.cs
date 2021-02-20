
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSearchContacts
            // 
            this.lbSearchContacts.AutoSize = true;
            this.lbSearchContacts.Location = new System.Drawing.Point(379, 21);
            this.lbSearchContacts.Name = "lbSearchContacts";
            this.lbSearchContacts.Size = new System.Drawing.Size(86, 13);
            this.lbSearchContacts.TabIndex = 0;
            this.lbSearchContacts.Text = "Search Contacts";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(55, 64);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbCellPhone
            // 
            this.lbCellPhone.AutoSize = true;
            this.lbCellPhone.Location = new System.Drawing.Point(32, 105);
            this.lbCellPhone.Name = "lbCellPhone";
            this.lbCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lbCellPhone.TabIndex = 2;
            this.lbCellPhone.Text = "Cell Phone";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(48, 148);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(42, 13);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Results";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(553, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(699, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(125, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(553, 290);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // SearchContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbCellPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSearchContacts);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}