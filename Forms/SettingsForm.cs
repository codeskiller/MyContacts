using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyContacts
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool UsernameExist = false;
            if (File.Exists("Users.xml"))
            {
                string xmlFile = File.ReadAllText("Users.xml");
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlFile);
                XmlNodeList nodeList = xmldoc.GetElementsByTagName("Username");
                string username = string.Empty;
                foreach (XmlNode node in nodeList)
                {
                    username = node.InnerText;
                    if (username == txtUserName.Text) UsernameExist = true;

                }


                if (UsernameExist == false)
                {
                    MessageBox.Show("This username is not registered");
                }
                else
                {
                    bool passwordExist = false;
                    XmlNodeList nodeList2 = xmldoc.GetElementsByTagName("Password");
                    string password = string.Empty;
                    foreach (XmlNode node in nodeList2)
                    {
                        password = node.InnerText;
                        if (password == EncodePassword.EncodePasswordToBase64(txtPassword.Text)) 
                            passwordExist = true;
                    }

                    XmlDocument doc = new XmlDocument();
                    doc.Load("Users.xml");
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList name = root.SelectNodes("//Users");
                    foreach (XmlNode node in name)
                    {
                        if (node.SelectSingleNode("Username").InnerText == txtUserName.Text)
                        {
                            if (passwordExist == true && rbtnEnableAccount.Checked == true)
                            {
                                node.SelectSingleNode("Status").InnerText = "Enable";
                            }
                            else if (passwordExist == true && rbtnDisableAccount.Checked == true)
                            {
                                node.SelectSingleNode("Status").InnerText = "Disable";
                            }
                                
                        } 
                    }

                   MessageBox.Show("Your password or username doesn't match");
                }
            }
        }

        private void rbtnDisableAccount_CheckedChanged(object sender, EventArgs e)
        {
            rbtnEnableAccount.Checked = false;
        }

        private void rbtnEnableAccount_CheckedChanged(object sender, EventArgs e)
        {
            rbtnDisableAccount.Checked = false;
        }
    }
}
