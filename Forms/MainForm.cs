using MyContacts.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
      
            AllContactForm allContactForm = new AllContactForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            allContactForm.FormBorderStyle = (FormBorderStyle)0;
            this.MainPanel.Controls.Add(allContactForm);
            allContactForm.Show();
        }

        private void ContactDetailForm_Load(object sender, EventArgs e)
        {
            ContactDetails contact = new ContactDetails(this);

        }

        private void btn_AllContact_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            AllContactForm allContactForm = new AllContactForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            allContactForm.FormBorderStyle = (FormBorderStyle) 0;
            this.MainPanel.Controls.Add(allContactForm);
            allContactForm.Show();
        }

        private void btn_SearchContact_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            SearchContactForm searchContactForm = new SearchContactForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            searchContactForm.FormBorderStyle = (FormBorderStyle)0;
            this.MainPanel.Controls.Add(searchContactForm);
            searchContactForm.Show();
        }

        private void btn_NewContact_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            AddNewContactForm addNewContactForm = new AddNewContactForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            addNewContactForm.FormBorderStyle = (FormBorderStyle)0;
            this.MainPanel.Controls.Add(addNewContactForm);
            addNewContactForm.Show();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            SettingsForm settingsForm = new SettingsForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            settingsForm.FormBorderStyle = (FormBorderStyle)0;
            this.MainPanel.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            Forms.InfoForm infoForm = new Forms.InfoForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            infoForm.FormBorderStyle = (FormBorderStyle)0;
            this.MainPanel.Controls.Add(infoForm);
            infoForm.Show();
        }
    }
}
