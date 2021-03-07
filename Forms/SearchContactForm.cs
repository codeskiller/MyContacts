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

namespace MyContacts
{
    public partial class SearchContactForm : Form
    {
        public SearchContactForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool nameExist = false;
            bool cellPhoneExist = false;
            if (File.Exists("Contacts.xml"))
            {
                string name = string.Empty;
                string nickName = string.Empty;
                string address = string.Empty;
                string cellPhone = string.Empty;
                string homePhone = string.Empty;
                string website = string.Empty;
                string facebook = string.Empty;
                string twitter = string.Empty;
                string linkedIn = string.Empty;

                XmlDocument doc = new XmlDocument();
                doc.Load("Contacts.xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList names = root.SelectNodes("//Contacts/Table");
                foreach (XmlNode node in names)
                {

                    if (tbName.Text != null && node.SelectSingleNode("Name").InnerText == tbName.Text)
                    {
                        nameExist = true;
                        tbResult.Text = "Name: " + tbName.Text + "\r\n" +
                                        "NickName: " + node.SelectSingleNode("NickName").InnerText + "\r\n" +
                                        "Address: " + node.SelectSingleNode("Address").InnerText + "\r\n" +
                                        "Cell Phone: " + node.SelectSingleNode("CellPhone").InnerText + "\r\n" +
                                        "Home Phone: " + node.SelectSingleNode("HomePhone").InnerText + "\r\n" +
                                        "Email: " + node.SelectSingleNode("Email").InnerText + "\r\n" +
                                        "Website: " + node.SelectSingleNode("Website").InnerText + "\r\n" +
                                        "Facebook: " + node.SelectSingleNode("Facebook").InnerText + "\r\n" +
                                        "Twitter: " + node.SelectSingleNode("Twitter").InnerText + "\r\n" +
                                        "LinkedIn: " + node.SelectSingleNode("LinkedIn").InnerText + "\r\n" ;
                    }
                    else if (tbCellPhone.Text != null && node.SelectSingleNode("CellPhone").InnerText == tbCellPhone.Text)
                    {
                        cellPhoneExist = true;
                        tbResult.Text = "Name: " + node.SelectSingleNode("Name").InnerText + "\r\n" +
                                        "NickName: " + node.SelectSingleNode("NickName").InnerText + "\r\n" +
                                        "Address: " + node.SelectSingleNode("Address").InnerText + "\r\n" +
                                        "Cell Phone: " + tbCellPhone.Text + "\r\n" +
                                        "Home Phone: " + node.SelectSingleNode("HomePhone").InnerText + "\r\n" +
                                        "Email: " + node.SelectSingleNode("Email").InnerText + "\r\n" +
                                        "Website: " + node.SelectSingleNode("Website").InnerText + "\r\n" +
                                        "Facebook: " + node.SelectSingleNode("Facebook").InnerText + "\r\n" +
                                        "Twitter: " + node.SelectSingleNode("Twitter").InnerText + "\r\n" +
                                        "LinkedIn: " + node.SelectSingleNode("LinkedIn").InnerText + "\r\n";
                    }

                }

                if (nameExist == false && cellPhoneExist == false)
                {
                    MessageBox.Show("This contact is not found");
                }
            }
            else
                MessageBox.Show("This contact is not found");
        }
    }
}
