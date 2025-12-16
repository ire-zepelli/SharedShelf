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
    public partial class UserBrowseControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int userId;

        public UserBrowseControl()
        {
            InitializeComponent();
        }

        public void SetUser(users user)
        {
            if (user != null)
            {
                userId = user.user_id;
                LoadData();
            }
        }

        public void LoadData()
        {
            MessageBox.Show("Loading data for user ID: " + userId);
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM items WHERE owner_id != @userID AND is_available = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@userID", userId);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                foreach (DataRow row in itemsTable.Rows)
                {
                    int itemId = Convert.ToInt32(row["item_id"]);
                    int ownerId = Convert.ToInt32(row["owner_id"]);
                    string itemName = row["item_name"].ToString();
                    int categoryId = Convert.ToInt32(row["category_id"]);
                    string description = row["description"].ToString();
                    DateTime datePosted = Convert.ToDateTime(row["date_posted"]);
                    bool isAvailable = Convert.ToBoolean(row["is_available"]);

                    flowLayoutPanel1.Controls.Add(new BorrowCardControl(itemName, description, categoryId + "", itemId, userId + ""));
                }
            }
        }

        private void UserBrowseControl_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If no search term and "All" selected, just load everything
            if (search_tb.Text.Trim() == "" && filter_box.Text == "All")
            {
                LoadData();
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM items WHERE owner_id != @userID AND is_available = 1";

                if (search_tb.Text.Trim() != "")
                {
                    query += " AND item_name LIKE @searchTerm";
                }

                if (filter_box.Text != "All")
                {
                    query += " AND category_id = @categoryId";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@userID", userId);

                if (search_tb.Text.Trim() != "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + search_tb.Text.Trim() + "%");
                }

                if (filter_box.Text != "All")
                {
                    // SelectedIndex 0 = "All", so subtract 1 to skip it
                    // SelectedIndex 1 = "Household Items" = category_id 1
                    // SelectedIndex 2 = "Tools & Equipment" = category_id 2, etc.
                    int categoryId = filter_box.SelectedIndex; // No need to add 1 since "All" is at index 0
                    adapter.SelectCommand.Parameters.AddWithValue("@categoryId", categoryId);
                }

                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow row in itemsTable.Rows)
                {
                    int itemId = Convert.ToInt32(row["item_id"]);
                    int ownerId = Convert.ToInt32(row["owner_id"]);
                    string itemName = row["item_name"].ToString();
                    int categoryId = Convert.ToInt32(row["category_id"]);
                    string description = row["description"].ToString();
                    DateTime datePosted = Convert.ToDateTime(row["date_posted"]);
                    bool isAvailable = Convert.ToBoolean(row["is_available"]);

                    flowLayoutPanel1.Controls.Add(new BorrowCardControl(itemName, description, categoryId + "", itemId, userId+""));
                }
            }
        }
    }
}