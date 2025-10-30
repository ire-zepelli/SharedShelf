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

        private void dashboard_btn_Onclick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(15, 198);
            dashboardControl1.BringToFront();
        }

        private void users_btn_Onclick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(15, 290);
            adminUsersControl1.BringToFront();
        }

        private void items_btn_Onclick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(15, 387);
            adminItemsControl1.BringToFront();
        }

        private void settings_btn__Onclick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(15, 628);
        }

        private void logout_btn_Onclick(object sender, EventArgs e)
        {
            selected_panel.Location = new Point(15, 723);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
