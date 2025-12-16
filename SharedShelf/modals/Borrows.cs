using SharedShelf.UserControls;
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
    public partial class Borrows : Form
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        string userID = string.Empty;

        public Borrows(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Join request, items, and users tables to get all needed information
                    string query = @"
                        SELECT 
                            r.request_id,
                            r.borrow_date,
                            r.return_date,
                            i.item_name,
                            i.item_id,
                            owner.first_name AS owner_first_name,
                            owner.last_name AS owner_last_name,
                            owner.address AS owner_address,
                            owner.contact AS owner_contact
                        FROM request r
                        INNER JOIN items i ON r.item_id = i.item_id
                        INNER JOIN users owner ON i.owner_id = owner.user_id
                        WHERE r.status_id = 2 
                        AND r.borrower_id = @userID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userID", userID);

                    DataTable borrowsTable = new DataTable();
                    adapter.Fill(borrowsTable);

                    // Clear existing controls if using FlowLayoutPanel
                    // flowLayoutPanel1.Controls.Clear();

                    foreach (DataRow row in borrowsTable.Rows)
                    {
                        string itemID = row["item_id"].ToString();
                        string requestID = row["request_id"].ToString();
                        string item_name = row["item_name"].ToString();
                        string owner_name = row["owner_first_name"].ToString() + " " + row["owner_last_name"].ToString();
                        string address = row["owner_address"].ToString();
                        string borrowDate = Convert.ToDateTime(row["borrow_date"]).ToString("yyyy-MM-dd");
                        string returnDate = Convert.ToDateTime(row["return_date"]).ToString("yyyy-MM-dd");
                        string ownerContact = row["owner_contact"].ToString();

                        flowLayoutPanel1.Controls.Add(new ReturnCard(requestID, item_name, owner_name, address, borrowDate, returnDate, ownerContact, itemID));
                    }

                    // If no borrows found
                    if (borrowsTable.Rows.Count == 0)
                    {
                        MessageBox.Show("You have no active borrows.", "No Borrows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading borrows: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Borrows_Load(object sender, EventArgs e)
        {
        }
    }
}