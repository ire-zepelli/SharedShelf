using MahApps.Metro.Controls.Dialogs;
using SharedShelf.modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf.UserControls
{
    public partial class ItemCardControl : UserControl
    {
        public ItemCardControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditItemForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (result == "Yes")
            {
                // Code to delete the item goes here
            }
        }
    }
}
