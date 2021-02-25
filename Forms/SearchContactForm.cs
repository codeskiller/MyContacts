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

                string xmlFile = File.ReadAllText("Contacts.xml");
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNodeList nodeList = xmldoc.GetElementsByTagName("Name");
              
                foreach (XmlNode node in nodeList)
                {
                    name = node.InnerText;
                    if (name == tbName.Text)
                    {
                        nameExist = true;
                         nickName = string.Empty;
                         address = string.Empty;
                         cellPhone = string.Empty;
                         homePhone = string.Empty;
                         website = string.Empty;
                         facebook = string.Empty;
                         twitter = string.Empty;
                         linkedIn = string.Empty;
                    }
                }


                if (nameExist == false)
                {
                    MessageBox.Show("This name is not found");
                }
                else
                {

                    string password = string.Empty;
                    foreach (XmlNode node in nodeList)
                    {
                        name = node.InnerText;
                        if(name == tbName.Text)
                            tbResult.Text = name;

                    }
                }
                XmlNodeList nodeList2 = xmldoc.GetElementsByTagName("Cell Phone");
                
                foreach (XmlNode node in nodeList2)
                {
                    cellPhone = node.InnerText;
                    if (cellPhone == tbCellPhone.Text) nameExist = true;

                }

            }
            else
                MessageBox.Show("This name is not found");
        }
    }
}
