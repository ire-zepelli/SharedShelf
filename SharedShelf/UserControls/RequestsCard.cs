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
    public partial class RequestsCard : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int request_id;
        private int item_id;

        public RequestsCard(int request_id, string name, string phone, string address, string item_name, string duration, int item_id)
        {
            InitializeComponent();
            this.request_id = request_id;
            this.item_id = item_id;

            name_label.Text = name;
            phone_label.Text = phone;
            address_label.Text = address;
            item_label.Text = item_name;
            duration_label.Text = duration;
        }

        private void button1_Click(object sender, EventArgs e) // Accept button
        {
            DialogResult result = MessageBox.Show("Are you sure you want to approve this request?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Update request status to approved (2)
                        string updateRequestQuery = "UPDATE request SET status_id = 2 WHERE request_id = @request_id";
                        SqlCommand updateCmd = new SqlCommand(updateRequestQuery, conn);
                        updateCmd.Parameters.AddWithValue("@request_id", request_id);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove card from parent
                        if (this.Parent != null)
                        {
                            this.Parent.Controls.Remove(this);
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error approving request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deny_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reject this request?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // 1. Update request status to rejected (3)
                        string updateRequestQuery = "UPDATE request SET status_id = 3 WHERE request_id = @request_id";
                        SqlCommand updateCmd = new SqlCommand(updateRequestQuery, conn);
                        updateCmd.Parameters.AddWithValue("@request_id", request_id);
                        updateCmd.ExecuteNonQuery();

                        // 2. Make item available again (is_available = 1)
                        string updateItemQuery = "UPDATE items SET is_available = 1 WHERE item_id = @item_id";
                        SqlCommand itemCmd = new SqlCommand(updateItemQuery, conn);
                        itemCmd.Parameters.AddWithValue("@item_id", item_id);
                        itemCmd.ExecuteNonQuery();

                        MessageBox.Show("Request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove card from parent
                        if (this.Parent != null)
                        {
                            this.Parent.Controls.Remove(this);
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error rejecting request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RequestsCard_Load(object sender, EventArgs e)
        {
        }
    }
}