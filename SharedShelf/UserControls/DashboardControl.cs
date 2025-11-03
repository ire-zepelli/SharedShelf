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
        //SharedShelfDBEntities1 database = new SharedShelfDBEntities1();
        public DashboardControl()
        {
            InitializeComponent();
            if (!System.ComponentModel.LicenseManager.UsageMode.Equals(System.ComponentModel.LicenseUsageMode.Designtime))
            {
                LoadDashboardData();
            }
        }

        public void LoadDashboardData() { 
            var totalUsers = AdminForm.db.users.Count();
            var totalItems = AdminForm.db.items.Count();
            var totalTransactions = AdminForm.db.transactions.Count();

            total_users_label.Text = totalUsers.ToString();
            total_items_label.Text = totalItems.ToString();
            total_transactions_label.Text = totalTransactions.ToString();

            dataGridView1.DataSource = AdminForm.db.items
                .Select(i => new
                {
                    i.item_id,
                    i.owner_id,
                    i.item_name,
                    i.category_id,
                    i.description
                })
                .ToList();
        }
    }
}
