using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf.UserControls
{
    public partial class UserSettingsControl : UserControl
    {
        string full_name, address, contact, created_at;
        public UserSettingsControl()
        {
            InitializeComponent();
        }

        public void SetUserDetails(string full_name, string address, string contact)
        {
            this.full_name = full_name;
            this.address = address;
            this.contact = contact;
            LoadData();
        }

        public void LoadData()
        {
            full_name_lb.Text = full_name;
            address_lb.Text = address;
            label3.Text = contact;
        }       

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
