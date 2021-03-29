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
    public partial class Register : Form
    {
        XmlSerializer xs;
        List<Users> ls;   
        

        public Register()
        {
            InitializeComponent();
            ls = new List<Users>();
            xs = new XmlSerializer(typeof(List<Users>));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool UsernameExist = false;
            if (File.Exists("Users.xml"))
            {
                //check if the user already existed.
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
            }
           
            
            if ( tbUsername == null || tbPassword == null || tbConfirmPassword == null)
            {
                MessageBox.Show("Please fill in all the blank");
            }
            else
            {
                if (UsernameExist)
                {
                    MessageBox.Show("This username is already taken !");
                }
                else
                {
                    if (tbPassword.Text == tbConfirmPassword.Text)
                    {
                        FileStream fs = new FileStream("Users.xml", FileMode.Create, FileAccess.Write);
                        Users users = new Users();
                        users.Id += 1;
                        users.Username = tbUsername.Text;
                        users.Password = EncodePassword.EncodePasswordToBase64(tbPassword.Text);
                        users.Status = "Enable";
                        try
                        {
                            ls.Add(users);
                            xs.Serialize(fs, ls);
                            fs.Close();
                            MessageBox.Show("Your account has been created!");
                            var login = new Login();
                            var t = new Thread(() => Application.Run(new Login()));
                            t.Start();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Your password doesn't match");
                }               
            }                   
        }
    }
}
