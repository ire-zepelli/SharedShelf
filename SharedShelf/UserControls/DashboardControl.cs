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
    public partial class DashboardControl : UserControl
    {
        private static SharedShelfDBEntities1 database = new SharedShelfDBEntities1();

        public DashboardControl()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        public void LoadDashboardData() { 
            var totalUsers = database.users.Count();
            var totalItems = database.items.Count();
            var totalTransactions = database.transactions.Count();

            total_users_label.Text = totalUsers.ToString();
            total_items_label.Text = totalItems.ToString();
            total_transactions_label.Text = totalTransactions.ToString();
        }
    }
}
