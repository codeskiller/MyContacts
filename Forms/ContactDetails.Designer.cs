
namespace MyContacts.Forms
{
    partial class ContactDetails
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLinked = new System.Windows.Forms.TextBox();
            this.tbTwitter = new System.Windows.Forms.TextBox();
            this.tbFacebook = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.RichTextBox();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHomePhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbLinked = new System.Windows.Forms.Label();
            this.lbTwitter = new System.Windows.Forms.Label();
            this.lbFacebook = new System.Windows.Forms.Label();
            this.lbWebsite = new System.Windows.Forms.Label();
            this.fbEmail = new System.Windows.Forms.Label();
            this.lbHomePhone = new System.Windows.Forms.Label();
            this.lbcellPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(188, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbTwitter, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbFacebook, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNickName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCellPhone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbWebsite, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbEmail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbHomePhone, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLinked, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 377);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // tbLinked
            // 
            this.tbLinked.Location = new System.Drawing.Point(3, 336);
            this.tbLinked.Name = "tbLinked";
            this.tbLinked.Size = new System.Drawing.Size(562, 20);
            this.tbLinked.TabIndex = 17;
            // 
            // tbTwitter
            // 
            this.tbTwitter.Location = new System.Drawing.Point(3, 299);
            this.tbTwitter.Name = "tbTwitter";
            this.tbTwitter.Size = new System.Drawing.Size(562, 20);
            this.tbTwitter.TabIndex = 18;
            // 
            // tbFacebook
            // 
            this.tbFacebook.Location = new System.Drawing.Point(3, 262);
            this.tbFacebook.Name = "tbFacebook";
            this.tbFacebook.Size = new System.Drawing.Size(562, 20);
            this.tbFacebook.TabIndex = 19;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(3, 77);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(562, 24);
            this.tbAddress.TabIndex = 20;
            this.tbAddress.Text = "";
            // 
            // tbNickName
            // 
            this.tbNickName.Location = new System.Drawing.Point(3, 40);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.Size = new System.Drawing.Size(562, 20);
            this.tbNickName.TabIndex = 11;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.Location = new System.Drawing.Point(3, 114);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(562, 20);
            this.tbCellPhone.TabIndex = 14;
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(3, 225);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(562, 20);
            this.tbWebsite.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(3, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(562, 20);
            this.tbEmail.TabIndex = 16;
            // 
            // tbHomePhone
            // 
            this.tbHomePhone.Location = new System.Drawing.Point(3, 151);
            this.tbHomePhone.Name = "tbHomePhone";
            this.tbHomePhone.Size = new System.Drawing.Size(562, 20);
            this.tbHomePhone.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(562, 20);
            this.tbName.TabIndex = 10;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(58, 74);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(80, 24);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "Address";
            // 
            // lbLinked
            // 
            this.lbLinked.AutoSize = true;
            this.lbLinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinked.Location = new System.Drawing.Point(18, 333);
            this.lbLinked.Name = "lbLinked";
            this.lbLinked.Size = new System.Drawing.Size(120, 24);
            this.lbLinked.TabIndex = 31;
            this.lbLinked.Text = "Linkedin Link";
            // 
            // lbTwitter
            // 
            this.lbTwitter.AutoSize = true;
            this.lbTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTwitter.Location = new System.Drawing.Point(34, 296);
            this.lbTwitter.Name = "lbTwitter";
            this.lbTwitter.Size = new System.Drawing.Size(104, 24);
            this.lbTwitter.TabIndex = 30;
            this.lbTwitter.Text = "Twitter Link";
            // 
            // lbFacebook
            // 
            this.lbFacebook.AutoSize = true;
            this.lbFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacebook.Location = new System.Drawing.Point(43, 259);
            this.lbFacebook.Name = "lbFacebook";
            this.lbFacebook.Size = new System.Drawing.Size(95, 24);
            this.lbFacebook.TabIndex = 29;
            this.lbFacebook.Text = "Facebook";
            // 
            // lbWebsite
            // 
            this.lbWebsite.AutoSize = true;
            this.lbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWebsite.Location = new System.Drawing.Point(60, 222);
            this.lbWebsite.Name = "lbWebsite";
            this.lbWebsite.Size = new System.Drawing.Size(78, 24);
            this.lbWebsite.TabIndex = 28;
            this.lbWebsite.Text = "Website";
            // 
            // fbEmail
            // 
            this.fbEmail.AutoSize = true;
            this.fbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbEmail.Location = new System.Drawing.Point(81, 185);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(57, 24);
            this.fbEmail.TabIndex = 27;
            this.fbEmail.Text = "Email";
            // 
            // lbHomePhone
            // 
            this.lbHomePhone.AutoSize = true;
            this.lbHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomePhone.Location = new System.Drawing.Point(15, 148);
            this.lbHomePhone.Name = "lbHomePhone";
            this.lbHomePhone.Size = new System.Drawing.Size(123, 24);
            this.lbHomePhone.TabIndex = 26;
            this.lbHomePhone.Text = "Home Phone";
            // 
            // lbcellPhone
            // 
            this.lbcellPhone.AutoSize = true;
            this.lbcellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcellPhone.Location = new System.Drawing.Point(35, 111);
            this.lbcellPhone.Name = "lbcellPhone";
            this.lbcellPhone.Size = new System.Drawing.Size(103, 24);
            this.lbcellPhone.TabIndex = 25;
            this.lbcellPhone.Text = "Cell Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nick Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(284, 432);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbcellPhone, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbLinked, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbHomePhone, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbTwitter, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.fbEmail, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbFacebook, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbWebsite, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 377);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ContactDetails";
            this.Text = "Contact Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbLinked;
        private System.Windows.Forms.TextBox tbTwitter;
        private System.Windows.Forms.TextBox tbFacebook;
        private System.Windows.Forms.RichTextBox tbAddress;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbHomePhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbLinked;
        private System.Windows.Forms.Label lbTwitter;
        private System.Windows.Forms.Label lbFacebook;
        private System.Windows.Forms.Label lbWebsite;
        private System.Windows.Forms.Label fbEmail;
        private System.Windows.Forms.Label lbHomePhone;
        private System.Windows.Forms.Label lbcellPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}