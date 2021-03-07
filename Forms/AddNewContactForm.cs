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
using System.Xml;
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
            CreateXMLFile();
        }
        static void CreateXMLFile()
        {
            //create xml file if it doesn't exis
            if (!File.Exists("Contacts.xml"))
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.CreateElement("Contacts");
                doc.AppendChild(root);
                doc.Save("Contacts.xml");
            }        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            //load xml file and create element
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Contacts.xml");
                XmlNode root = doc.SelectSingleNode("Contacts");
                XmlElement contacts = doc.CreateElement("Table");
                root.AppendChild(contacts);

                XmlElement name = doc.CreateElement("Name");
                XmlElement nickName = doc.CreateElement("NickName");
                XmlElement address = doc.CreateElement("Address");
                XmlElement cellPhone = doc.CreateElement("CellPhone");
                XmlElement homePhone = doc.CreateElement("HomePhone");
                XmlElement email = doc.CreateElement("Email");             
                XmlElement website = doc.CreateElement("Website");
                XmlElement facebook = doc.CreateElement("Facebook");
                XmlElement twitter = doc.CreateElement("Twitter");
                XmlElement linkedIn = doc.CreateElement("LinkedIn");
                contacts.AppendChild(name);
                contacts.AppendChild(nickName);
                contacts.AppendChild(address);
                contacts.AppendChild(cellPhone);
                contacts.AppendChild(homePhone);
                contacts.AppendChild(email);
                contacts.AppendChild(website);
                contacts.AppendChild(facebook);
                contacts.AppendChild(twitter);
                contacts.AppendChild(linkedIn);

                name.InnerText = tbName.Text;
                nickName.InnerText = tbNickName.Text;
                address.InnerText = tbAddress.Text;
                cellPhone.InnerText = tbCellPhone.Text;
                homePhone.InnerText = tbHomePhone.Text;
                email.InnerText = tbEmail.Text;
                website.InnerText = tbWebsite.Text;
                facebook.InnerText = tbFacebook.Text;
                twitter.InnerText = tbFacebook.Text;
                linkedIn.InnerText = tbLinked.Text;
                doc.Save("Contacts.xml");
                MessageBox.Show("Contact details are added !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+  ex.Message);
            }
        
        }
    }
}
