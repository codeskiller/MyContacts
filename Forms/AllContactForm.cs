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
                    //Read all XML files and records to datagrid
                    DataSet ds = new DataSet();
                    ds.ReadXml("Contacts.xml");
                    DataTable dt = new DataTable();

                    dataGridViewAllContact.DataSource = ds.Tables[0];

                    //hide columns
                    dataGridViewAllContact.Columns["Facebook"].Visible = false;
                    dataGridViewAllContact.Columns["LinkedIn"].Visible = false;
                    dataGridViewAllContact.Columns["Twitter"].Visible = false;
                    dataGridViewAllContact.Columns["NickName"].Visible = false;

                    dataGridViewAllContact.FirstDisplayedScrollingRowIndex = dataGridViewAllContact.Rows.Count - 1;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }          
        }

        private void dataGridViewAllContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          if( dataGridViewAllContact.SelectedCells.Count > 0) { 
                int selectedRowIndex = dataGridViewAllContact.SelectedCells[0].RowIndex;

                var name = dataGridViewAllContact.Rows[selectedRowIndex].Cells[0].Value.ToString();
                var nickname = dataGridViewAllContact.Rows[selectedRowIndex].Cells[1].Value.ToString();
                var address = dataGridViewAllContact.Rows[selectedRowIndex].Cells[2].Value.ToString();
                var cellPhone = dataGridViewAllContact.Rows[selectedRowIndex].Cells[3].Value.ToString();
                var homePhone = dataGridViewAllContact.Rows[selectedRowIndex].Cells[4].Value.ToString();
                var website = dataGridViewAllContact.Rows[selectedRowIndex].Cells[5].Value.ToString();
                var facebook = dataGridViewAllContact.Rows[selectedRowIndex].Cells[6].Value.ToString();
                var twitter = dataGridViewAllContact.Rows[selectedRowIndex].Cells[7].Value.ToString();
                var linkedIn = dataGridViewAllContact.Rows[selectedRowIndex].Cells[8].Value.ToString();

                //pass values to ContactDetail form
                ContactDetails contactDetail = new ContactDetails();
                contactDetail.formObject = this;
                contactDetail.getContactDetails(name, nickname, address, cellPhone, homePhone, website, facebook, twitter, linkedIn);
                contactDetail.Show();
            }       
        }
    }
}
