using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SharedShelf.UserControls
{
    public partial class ReturnCard : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        string requestID = string.Empty;
        int itemID;

        public ReturnCard(string requestID, string item_name, string owner_name, string address, string borrowDate, string returnDate, string ownerContact, string itemID)
        {
            InitializeComponent();
            this.requestID = requestID;
            this.itemID = Int32.Parse(itemID);
            item_label.Text = item_name;
            name_label.Text = owner_name;
            address_label.Text = address;
            contact_label.Text = ownerContact;
            duration_label.Text = borrowDate + " - " + returnDate;
        }

        private void ReturnCard_Load(object sender, EventArgs e)
        {
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to mark this item as returned?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // 1. Update request status to returned (4)
                        string updateRequestQuery = "UPDATE request SET status_id = 4 WHERE request_id = @request_id";
                        SqlCommand updateCmd = new SqlCommand(updateRequestQuery, conn);
                        updateCmd.Parameters.AddWithValue("@request_id", requestID);
                        updateCmd.ExecuteNonQuery();

                        // 2. Make item available again (is_available = 1)
                        string updateItemQuery = "UPDATE items SET is_available = 1 WHERE item_id = @item_id";
                        SqlCommand itemCmd = new SqlCommand(updateItemQuery, conn);
                        itemCmd.Parameters.AddWithValue("@item_id", itemID);
                        itemCmd.ExecuteNonQuery();

                        MessageBox.Show("Item returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove card from parent
                        if (this.Parent != null)
                        {
                            this.Parent.Controls.Remove(this);
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error returning item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}