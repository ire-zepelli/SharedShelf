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

namespace SharedShelf
{
    public partial class HistoryForm : Form
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        int userId;

        public HistoryForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query all returned items (status_id = 4) for the user
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
                        WHERE r.status_id = 4
                        AND r.borrower_id = @userId
                        ORDER BY r.return_date DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);

                    DataTable historyTable = new DataTable();
                    adapter.Fill(historyTable);

                    // If using FlowLayoutPanel
                    flowLayoutPanel1.Controls.Clear();

                    foreach (DataRow row in historyTable.Rows)
                    {
                        string requestId = row["request_id"].ToString();
                        string item_name = row["item_name"].ToString();
                        string owner_name = row["owner_first_name"].ToString() + " " + row["owner_last_name"].ToString();
                        string owner_address = row["owner_address"].ToString();
                        string owner_contact = row["owner_contact"].ToString();
                        string borrow_date = Convert.ToDateTime(row["borrow_date"]).ToString("yyyy-MM-dd");
                        string return_date = Convert.ToDateTime(row["return_date"]).ToString("yyyy-MM-dd");


                        flowLayoutPanel1.Controls.Add(new HistoryControl(requestId, item_name, owner_name, owner_address, owner_contact, borrow_date, return_date));

                    }

                    if (historyTable.Rows.Count == 0)
                    {
                        MessageBox.Show("You have no borrow history.", "No History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
        }
    }
}