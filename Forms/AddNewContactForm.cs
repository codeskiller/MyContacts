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
    public partial class AddNewContactForm : Form
    {
        XmlSerializer xs;
        List<Forms.Contacts> ls;
        public AddNewContactForm()
        {
            InitializeComponent();
            ls = new List<Forms.Contacts>();
            xs = new XmlSerializer(typeof(List<Forms.Contacts>));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Contacts.xml", FileMode.Create, FileAccess.Write);
            Forms.Contacts newContact = new Forms.Contacts();
            newContact.Name = tbName.Text;
            newContact.NickName = tbNickName.Text;
            newContact.Address = tbAddress.Text;
            newContact.CellPhone = tbCellPhone.Text;
            newContact.HomePhone = tbHomePhone.Text;
            newContact.Email = tbEmail.Text;
            newContact.Website = tbWebsite.Text;
            newContact.Facebook = tbFacebook.Text;
            newContact.Twitter = tbFacebook.Text;
            newContact.Linkedin = tbLinked.Text;
            try
            {
                ls.Add(newContact);
                xs.Serialize(fs, ls);
                fs.Close();
                MessageBox.Show("Contact details are added !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+  ex.Message);
            }
        
        }
    }
}
