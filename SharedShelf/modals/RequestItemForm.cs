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

namespace SharedShelf.modals
{
    public partial class RequestItemForm : Form
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int borrowerID;
        private int itemID;
        public RequestItemForm(int borrowerID, int itemID)
        {
            InitializeComponent();
            this.borrowerID = borrowerID;
            this.itemID = itemID;

            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Single query joining both tables
                    string query = @"
                SELECT 
                    u.user_id, 
                    u.first_name, 
                    u.last_name,
                    i.item_id,
                    i.item_name,
                    i.category_id,
                    i.description
                FROM users u
                CROSS JOIN items i
                WHERE u.user_id = @borrowerID 
                AND i.item_id = @itemID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@borrowerID", borrowerID);
                    cmd.Parameters.AddWithValue("@itemID", itemID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string borrowerName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                        borrower_tb.Text = borrowerName;

                        string itemName = reader["item_name"].ToString();
                        item_tb.Text = itemName;
                    }
                    reader.Close();

                    category_box.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestItemForm_Load(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            // Validate return date is in the future
            if (returndate_box.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Return date must be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Insert new request
                    string insertRequestQuery = @"
                INSERT INTO request (borrower_id, borrow_date, return_date, created_at, item_id, status_id)
                VALUES (@borrowerID, @borrowDate, @returnDate, @createdAt, @itemID, @statusID)";

                    SqlCommand insertCmd = new SqlCommand(insertRequestQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@borrowerID", borrowerID);
                    insertCmd.Parameters.AddWithValue("@borrowDate", DateTime.Now.Date);
                    insertCmd.Parameters.AddWithValue("@returnDate", returndate_box.Value.Date);
                    insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@itemID", itemID);
                    insertCmd.Parameters.AddWithValue("@statusID", 1);
                    insertCmd.ExecuteNonQuery();

                    // 2. Update item availability to 0 (not available)
                    string updateItemQuery = "UPDATE items SET is_available = 0 WHERE item_id = @itemID";
                    SqlCommand updateCmd = new SqlCommand(updateItemQuery, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@itemID", itemID);
                    updateCmd.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();

                    MessageBox.Show("Request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set dialog result to OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Rollback transaction if error occurs
                    transaction?.Rollback();
                    MessageBox.Show($"Error submitting request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
