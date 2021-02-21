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
        XmlSerializer xs;
        List<Forms.Contacts> ls;

        public AllContactForm()
        {
            InitializeComponent();
            
            try
            {
                Forms.Contacts newContact = new Forms.Contacts();
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\Family\\source\\repos\\MyContacts\\Contacts.xml");
                dataGridViewAllContact.DataSource = ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

    }
}
