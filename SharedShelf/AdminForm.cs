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
        public static SharedShelfDBEntities1 db = new SharedShelfDBEntities1();
        private users currentUser = null;
        public AdminForm(users user)
        {
            InitializeComponent();
            currentUser = user;
            LoadAdminSide();
        }

        public void LoadAdminSide()
        {
            MessageBox.Show("Welcome Admin: " + currentUser.first_name);
        }

        private void dashboard_click(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 233);
            dashboardControl1.BringToFront();
        }

        private void items_click(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 321);
            adminItemsControl1.BringToFront();
        }

        private void users_click(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 407);
            adminUsersControl1.BringToFront();
        }

        private void settings_click(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 637);
        }

        private void logout_click(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(24, 718);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
