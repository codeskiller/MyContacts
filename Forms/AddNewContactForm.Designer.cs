
using System.Drawing;
using System.Windows.Forms;

namespace MyContacts
{
    partial class AddNewContactForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcellPhone = new System.Windows.Forms.Label();
            this.lbHomePhone = new System.Windows.Forms.Label();
            this.fbEmail = new System.Windows.Forms.Label();
            this.lbWebsite = new System.Windows.Forms.Label();
            this.lbFacebook = new System.Windows.Forms.Label();
            this.lbTwitter = new System.Windows.Forms.Label();
            this.lbLinked = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.tbHomePhone = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLinked = new System.Windows.Forms.TextBox();
            this.tbTwitter = new System.Windows.Forms.TextBox();
            this.tbFacebook = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nick Name";
            // 
            // lbcellPhone
            // 
            this.lbcellPhone.AutoSize = true;
            this.lbcellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcellPhone.Location = new System.Drawing.Point(4, 135);
            this.lbcellPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcellPhone.Name = "lbcellPhone";
            this.lbcellPhone.Size = new System.Drawing.Size(132, 29);
            this.lbcellPhone.TabIndex = 2;
            this.lbcellPhone.Text = "Cell Phone";
            // 
            // lbHomePhone
            // 
            this.lbHomePhone.AutoSize = true;
            this.lbHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomePhone.Location = new System.Drawing.Point(4, 180);
            this.lbHomePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHomePhone.Name = "lbHomePhone";
            this.lbHomePhone.Size = new System.Drawing.Size(154, 29);
            this.lbHomePhone.TabIndex = 3;
            this.lbHomePhone.Text = "Home Phone";
            // 
            // fbEmail
            // 
            this.fbEmail.AutoSize = true;
            this.fbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbEmail.Location = new System.Drawing.Point(4, 225);
            this.fbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(74, 29);
            this.fbEmail.TabIndex = 4;
            this.fbEmail.Text = "Email";
            // 
            // lbWebsite
            // 
            this.lbWebsite.AutoSize = true;
            this.lbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWebsite.Location = new System.Drawing.Point(4, 270);
            this.lbWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWebsite.Name = "lbWebsite";
            this.lbWebsite.Size = new System.Drawing.Size(101, 29);
            this.lbWebsite.TabIndex = 5;
            this.lbWebsite.Text = "Website";
            // 
            // lbFacebook
            // 
            this.lbFacebook.AutoSize = true;
            this.lbFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacebook.Location = new System.Drawing.Point(4, 315);
            this.lbFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFacebook.Name = "lbFacebook";
            this.lbFacebook.Size = new System.Drawing.Size(121, 29);
            this.lbFacebook.TabIndex = 6;
            this.lbFacebook.Text = "Facebook";
            // 
            // lbTwitter
            // 
            this.lbTwitter.AutoSize = true;
            this.lbTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTwitter.Location = new System.Drawing.Point(4, 360);
            this.lbTwitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTwitter.Name = "lbTwitter";
            this.lbTwitter.Size = new System.Drawing.Size(137, 29);
            this.lbTwitter.TabIndex = 7;
            this.lbTwitter.Text = "Twitter Link";
            // 
            // lbLinked
            // 
            this.lbLinked.AutoSize = true;
            this.lbLinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinked.Location = new System.Drawing.Point(4, 405);
            this.lbLinked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLinked.Name = "lbLinked";
            this.lbLinked.Size = new System.Drawing.Size(154, 29);
            this.lbLinked.TabIndex = 8;
            this.lbLinked.Text = "Linkedin Link";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(4, 90);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(102, 29);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(206, 4);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(748, 22);
            this.tbName.TabIndex = 10;
            // 
            // tbNickName
            // 
            this.tbNickName.Location = new System.Drawing.Point(206, 49);
            this.tbNickName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.Size = new System.Drawing.Size(748, 22);
            this.tbNickName.TabIndex = 11;
            // 
            // tbHomePhone
            // 
            this.tbHomePhone.Location = new System.Drawing.Point(206, 184);
            this.tbHomePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHomePhone.Name = "tbHomePhone";
            this.tbHomePhone.Size = new System.Drawing.Size(748, 22);
            this.tbHomePhone.TabIndex = 13;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.Location = new System.Drawing.Point(206, 139);
            this.tbCellPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(748, 22);
            this.tbCellPhone.TabIndex = 14;
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(206, 274);
            this.tbWebsite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(748, 22);
            this.tbWebsite.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(206, 229);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(748, 22);
            this.tbEmail.TabIndex = 16;
            // 
            // tbLinked
            // 
            this.tbLinked.Location = new System.Drawing.Point(206, 409);
            this.tbLinked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLinked.Name = "tbLinked";
            this.tbLinked.Size = new System.Drawing.Size(748, 22);
            this.tbLinked.TabIndex = 17;
            // 
            // tbTwitter
            // 
            this.tbTwitter.Location = new System.Drawing.Point(206, 364);
            this.tbTwitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTwitter.Name = "tbTwitter";
            this.tbTwitter.Size = new System.Drawing.Size(748, 22);
            this.tbTwitter.TabIndex = 18;
            // 
            // tbFacebook
            // 
            this.tbFacebook.Location = new System.Drawing.Point(206, 319);
            this.tbFacebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFacebook.Name = "tbFacebook";
            this.tbFacebook.Size = new System.Drawing.Size(748, 22);
            this.tbFacebook.TabIndex = 19;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(206, 94);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(748, 36);
            this.tbAddress.TabIndex = 20;
            this.tbAddress.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 516);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tbLinked, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbLinked, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbTwitter, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tbTwitter, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lbFacebook, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbWebsite, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tbFacebook, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.fbEmail, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbHomePhone, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbWebsite, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbcellPhone, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbEmail, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbHomePhone, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbNickName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbAddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbCellPhone, 1, 3);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(45, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 457);
            this.tableLayoutPanel2.TabIndex = 23;

            // 
            // AddNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 578);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewContactForm";
            this.Text = "AddNewContactForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcellPhone;
        private System.Windows.Forms.Label lbHomePhone;
        private System.Windows.Forms.Label fbEmail;
        private System.Windows.Forms.Label lbWebsite;
        private System.Windows.Forms.Label lbFacebook;
        private System.Windows.Forms.Label lbTwitter;
        private System.Windows.Forms.Label lbLinked;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.TextBox tbHomePhone;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLinked;
        private System.Windows.Forms.TextBox tbTwitter;
        private System.Windows.Forms.TextBox tbFacebook;
        private System.Windows.Forms.RichTextBox tbAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}