using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyContacts.Forms
{
    public partial class ContactDetails : Form
    {
        public AllContactForm formObject;

        MainForm main;
        public ContactDetails()
        {
            InitializeComponent();
        }
        public ContactDetails(MainForm main)
        {
            InitializeComponent();
            main = main;
        }
        public void getContactDetails(string Name, string NickName, string Address, string CellPhone, string HomePhone, string Website, string Facebook, string Twitter, string LinkedIn )
        {

            tbName.Text = Name;
            tbNickName.Text = NickName;
            tbAddress.Text = Address;
            tbCellPhone.Text = CellPhone;
            tbHomePhone.Text = HomePhone;
            tbWebsite.Text = Website;
            tbFacebook.Text = Facebook;
            tbTwitter.Text = Twitter;
            tbLinked.Text = LinkedIn;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            //read xml and update                    
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Contacts.xml");

                XmlElement root = doc.DocumentElement;
                XmlNodeList name = root.SelectNodes("//Contacts/Table");
                foreach(XmlNode node in name)
                {
                    if (node.SelectSingleNode("Name").InnerText == tbName.Text)
                    {
                        if (node.SelectSingleNode("Name").InnerText != null)
                        {
                            node.SelectSingleNode("Name").InnerText =  tbName.Text;
                        }
                        if (node.SelectSingleNode("NickName").InnerText != null)
                        {
                            node.SelectSingleNode("NickName").InnerText = tbNickName.Text;
                        }
                        if (node.SelectSingleNode("Address").InnerText != null)
                        {
                            node.SelectSingleNode("Address").InnerText = tbAddress.Text;
                        }
                        if (node.SelectSingleNode("CellPhone").InnerText != null)
                        {
                            node.SelectSingleNode("CellPhone").InnerText = tbCellPhone.Text;
                        }
                        if (node.SelectSingleNode("HomePhone").InnerText != null)
                        {
                            node.SelectSingleNode("HomePhone").InnerText = tbHomePhone.Text;
                        }
                        if (node.SelectSingleNode("Email").InnerText != null)
                        {
                            node.SelectSingleNode("Email").InnerText = tbEmail.Text;
                        }
                        if (node.SelectSingleNode("Website").InnerText != null)
                        {
                            node.SelectSingleNode("Website").InnerText = tbWebsite.Text;
                        }
                        if (node.SelectSingleNode("Facebook").InnerText != null)
                        {
                            node.SelectSingleNode("Facebook").InnerText = tbFacebook.Text;
                        }
                        if (node.SelectSingleNode("Twitter").InnerText != null)
                        {
                            node.SelectSingleNode("Twitter").InnerText = tbTwitter.Text;
                        }
                        if (node.SelectSingleNode("LinkedIn").InnerText != null)
                        {
                            node.SelectSingleNode("LinkedIn").InnerText = tbLinked.Text;
                        }
                          doc.Save("Contacts.xml");                      
                        break;

                    }

                }

                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void AllContactFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            //read xml and remove                    
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Contacts.xml");

                XmlElement root = doc.DocumentElement;
                XmlNodeList name = root.SelectNodes("//Contacts/Table");
                foreach (XmlNode node in name)
                {
                    if (node.SelectSingleNode("Name").InnerText == tbName.Text && node.SelectSingleNode("CellPhone").InnerText == tbCellPhone.Text ||
                        (node.SelectSingleNode("Name").InnerText == tbName.Text && node.SelectSingleNode("HomePhone").InnerText == tbHomePhone.Text))
                    {
                        //remove chile node
                        root.RemoveChild(node);

                        //verify the new XML structure
                        string newXML = doc.OuterXml;
                    }
                }
                doc.Save("Contacts.xml");
                MessageBox.Show("The contact has been deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            this.Close();
        }
    }
}
