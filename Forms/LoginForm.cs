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
using System.Xml.Linq;
using System.Xml.Serialization;
namespace MyContacts.Forms
{
    public partial class Login : Form
    {
        private Button button1;

        public Login()
        {
            XmlSerializer xs;
            List<Users> ls;

            ls = new List<Users>();
            xs = new XmlSerializer(typeof(List<Users>));

            InitializeComponent();
            if (!File.Exists("Users.xml"))
            {
                try
                {
                    FileStream fs = new FileStream("Users.xml", FileMode.Create, FileAccess.Write);
                    Users users = new Users();
                    users.Username = "";
                    users.Password = "";

                    ls.Add(users);
                    xs.Serialize(fs, ls);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
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
                    if (username == tbUsername.Text) UsernameExist = true;

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
                        if (password == EncodePassword.EncodePasswordToBase64(tbPassword.Text)) passwordExist = true;

                    }
                    if (passwordExist == true)
                    {
                        //create new thread to start main form and close login form
                        var t = new Thread(() => Application.Run(new MainForm()));
                        t.Start();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Your password or username doesn't match");
                }
            }

        }

        private void lbCreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var t = new Thread(() => Application.Run(new Register()));
            t.Start();
            this.Close();
        }

    }
}
