using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts.Forms
{
    public partial class ContactDetails : Form
    {
       

        public ContactDetails()
        {
            InitializeComponent();
        }
        public ContactDetails(string Name, string NickName, string Address, string cellPhone, string HomePhone, string Website, string Facebook, string Twitter, string LinkedIn )
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
