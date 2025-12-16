using SharedShelf.modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf.UserControls
{
    public partial class UserHomeControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int userId;
        private string firstname;
        public UserHomeControl()
        {
            InitializeComponent();
        }

        public void SetUser(users user)
        {
            if (user != null)   
            {
                userId = user.user_id;
                firstname = user.first_name;
                LoadData();
            }
        }

        public void LoadData() {
            label1.Text = "Welcome, " + firstname + "!";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT count(*) FROM items WHERE owner_id = @userID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userId);
                int itemCount = (int)cmd.ExecuteScalar();
                item_label.Text = itemCount.ToString();

                query = @"SELECT COUNT(*) 
                        FROM request r
                        INNER JOIN items i ON r.item_id = i.item_id
                        WHERE i.owner_id = @userID AND status_id = 1";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userId);
                int requestCount = (int)cmd.ExecuteScalar();
                request_label.Text = requestCount.ToString();

                query = @"SELECT COUNT(*)
                        FROM request r
                        WHERE r.borrower_id = @userID AND status_id = 4";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userId);
                int completedBorrow = (int)cmd.ExecuteScalar();
                successful_label.Text = completedBorrow.ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            new AddItemForm(userId + "").ShowDialog();
            LoadData();
        }

        private void requests_btn_Click(object sender, EventArgs e)
        {
            new RequestsForm(userId).ShowDialog();
            LoadData();
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            new HistoryForm(userId).ShowDialog(this);
            LoadData();
        }

        private void UserHomeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
