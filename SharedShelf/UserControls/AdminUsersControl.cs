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
    public partial class AdminUsersControl : UserControl    
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        public AdminUsersControl()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data() {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                String query = "SELECT * FROM users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void AdminUsersControl_Load(object sender, EventArgs e)
        {

        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string first_name = fname_tb.Text;
            string last_name = lname_tb.Text;
            string contact = contact_tb.Text;
            string address = address_tb.Text;
            string password = password_tb.Text;
            int user_type = role_box.SelectedItem.ToString().Equals("Admin") ? 1 : 2;

            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                String query = "INSERT INTO user_auth (username, password, created_at, user_type) OUTPUT INSERTED.user_auth_id VALUES (@username, @password, @date, @user_type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@user_type", user_type);

                int user_auth_id = (int)cmd.ExecuteScalar();

                query = "INSERT INTO users (first_name, last_name, contact, address, user_auth_id) VALUES (@first_name, @last_name, @contact, @address, @user_auth_id)";
                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@user_auth_id", user_auth_id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully!");
                load_data();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchTerm = search_tb.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                users.user_id,
                users.first_name,
                users.last_name,
                users.contact,
                users.address,
                user_auth.user_type,
                user_auth.username,
                user_auth.password
            FROM users
            JOIN user_auth 
                ON users.user_auth_id = user_auth.user_auth_id
            WHERE users.user_id = @searchTerm";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchTerm", searchTerm);

                SqlDataAdapter users_da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                users_da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    fname_tb.Text = dt.Rows[0]["first_name"].ToString();
                    lname_tb.Text = dt.Rows[0]["last_name"].ToString();
                    contact_tb.Text = dt.Rows[0]["contact"].ToString();
                    address_tb.Text = dt.Rows[0]["address"].ToString();

                    // Set role correctly
                    role_box.SelectedItem = dt.Rows[0]["user_type"].ToString() == "1" ? "Admin" : "User";

                    username_tb.Text = dt.Rows[0]["username"].ToString();
                    password_tb.Text = dt.Rows[0]["password"].ToString(); // Not secure but works
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            string userID = delete_tb.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getAuthQuery = "SELECT user_auth_id FROM users WHERE user_id = @userID";

                SqlCommand getAuthCmd = new SqlCommand(getAuthQuery, conn);
                getAuthCmd.Parameters.AddWithValue("@userID", userID);

                object result = getAuthCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("User ID not found.");
                    return;
                }

                int user_auth_id = Convert.ToInt32(result);

                string deleteUserQuery = "DELETE FROM users WHERE user_id = @userID";
                SqlCommand delUserCmd = new SqlCommand(deleteUserQuery, conn);
                delUserCmd.Parameters.AddWithValue("@userID", userID);
                delUserCmd.ExecuteNonQuery();

                string deleteAuthQuery = "DELETE FROM user_auth WHERE user_auth_id = @authID";
                SqlCommand delAuthCmd = new SqlCommand(deleteAuthQuery, conn);
                delAuthCmd.Parameters.AddWithValue("@authID", user_auth_id);
                delAuthCmd.ExecuteNonQuery();

                MessageBox.Show("User deleted successfully!");

                load_data();
            }
        }

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            string userID = search_tb.Text;
            string username = username_tb.Text;
            string first_name = fname_tb.Text;
            string last_name = lname_tb.Text;
            string contact = contact_tb.Text;
            string address = address_tb.Text;
            string password = password_tb.Text;
            int user_type = role_box.SelectedItem.ToString() == "Admin" ? 1 : 2;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1️⃣ Get the user_auth_id for this user
                string getAuthQuery = "SELECT user_auth_id FROM users WHERE user_id = @userID";
                SqlCommand getAuthCmd = new SqlCommand(getAuthQuery, conn);
                getAuthCmd.Parameters.AddWithValue("@userID", userID);

                object result = getAuthCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }
                int user_auth_id = Convert.ToInt32(result);

                // 2️⃣ Update users table
                string updateUserQuery = @"
            UPDATE users
            SET first_name = @first_name,
                last_name = @last_name,
                contact = @contact,
                address = @address
            WHERE user_id = @userID";

                SqlCommand updateUserCmd = new SqlCommand(updateUserQuery, conn);
                updateUserCmd.Parameters.AddWithValue("@first_name", first_name);
                updateUserCmd.Parameters.AddWithValue("@last_name", last_name);
                updateUserCmd.Parameters.AddWithValue("@contact", contact);
                updateUserCmd.Parameters.AddWithValue("@address", address);
                updateUserCmd.Parameters.AddWithValue("@userID", userID);
                updateUserCmd.ExecuteNonQuery();

                // 3️⃣ Update user_auth table
                string updateAuthQuery = @"
            UPDATE user_auth
            SET username = @username,
                password = @password,
                user_type = @user_type
            WHERE user_auth_id = @authID";

                SqlCommand updateAuthCmd = new SqlCommand(updateAuthQuery, conn);
                updateAuthCmd.Parameters.AddWithValue("@username", username);
                updateAuthCmd.Parameters.AddWithValue("@password", password);
                updateAuthCmd.Parameters.AddWithValue("@user_type", user_type);
                updateAuthCmd.Parameters.AddWithValue("@authID", user_auth_id);
                updateAuthCmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully!");
                load_data(); // refresh your DataGridView
            }
        }
    }
}
