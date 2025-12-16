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
    public partial class HistoryControl : UserControl
    {
        string requestId;
        public HistoryControl(string requestId, string item_name, string owner_name, string owner_address, string owner_contact, string borrow_date, string return_date)
        {
            InitializeComponent();
            this.requestId = requestId;

            name_label.Text = owner_name;
            label1.Text = owner_contact;
            address_label.Text = owner_address;
            label3.Text = item_name;
            label4.Text = borrow_date + " - " + return_date;
        }
    }
}
