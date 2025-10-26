using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf
{
    public partial class UserForm : Form
    {
        private static SharedShelfDBEntities1 database = new SharedShelfDBEntities1();
        public static users currentUser = null;
        public UserForm(users user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            welcome_label.Text = "Welcome User " + currentUser.first_name + " " + currentUser.last_name + "!";
        }
    }
}
