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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void home_onClick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 141);
            this.userHomeControl1.BringToFront();
        }

        private void shelf_onClick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 228);
            this.userSelfControl1.BringToFront();
        }

        private void browse_onClick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 314);
        }

        private void setting_onClick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 640);
        }

        private void logout_onClick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 721);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
