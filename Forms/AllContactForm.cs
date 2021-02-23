using MyContacts.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyContacts
{
    public partial class AllContactForm : Form
    {
        public AllContactForm()
        {
            InitializeComponent();
           if (File.Exists("Contacts.xml"))
           {
                try
                {
                    Contacts newContact = new Contacts();
                    DataSet ds = new DataSet();
                    ds.ReadXml("Contacts.xml");
                    dataGridViewAllContact.DataSource = ds.Tables["Contacts"];
                    
                    dataGridViewAllContact.Columns["NickName"].Visible = false;
                    dataGridViewAllContact.Columns["Website"].Visible = false;
                    dataGridViewAllContact.Columns["Facebook"].Visible = false;
                    dataGridViewAllContact.Columns["LinkedIn"].Visible = false;
                    dataGridViewAllContact.Columns["Twitter"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }          
        }

        private void dataGridViewAllContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dataGridViewAllContact.Rows[e.RowIndex].Cells[0].Value.ToString();
            var nickname = dataGridViewAllContact.Rows[e.RowIndex].Cells[1].Value.ToString();
            var address = dataGridViewAllContact.Rows[e.RowIndex].Cells[2].Value.ToString();
            var cellPhone = dataGridViewAllContact.Rows[e.RowIndex].Cells[3].Value.ToString();
            var homePhone = dataGridViewAllContact.Rows[e.RowIndex].Cells[4].Value.ToString();
            var website = dataGridViewAllContact.Rows[e.RowIndex].Cells[5].Value.ToString();
            var facebook = dataGridViewAllContact.Rows[e.RowIndex].Cells[6].Value.ToString();
            var twitter = dataGridViewAllContact.Rows[e.RowIndex].Cells[7].Value.ToString();
            var linkedIn = dataGridViewAllContact.Rows[e.RowIndex].Cells[8].Value.ToString();

            ContactDetails contactDetail = new ContactDetails(name,nickname,address,cellPhone,homePhone,website,facebook,twitter,linkedIn);
            contactDetail.Show();
        }
    }
}
