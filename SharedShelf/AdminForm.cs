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
    public partial class AdminForm : Form
    {
        private static SharedShelfDBEntities1 database = new SharedShelfDBEntities1();
        private static users currentUser = null;
        public AdminForm(users user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            welcome_label.Text = "Welcome Admin " + currentUser.first_name + " " + currentUser.last_name + "!";
        }
    }
}
