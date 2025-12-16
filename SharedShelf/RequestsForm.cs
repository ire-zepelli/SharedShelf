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
    public partial class RequestsForm : Form
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int user_id;
        public RequestsForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Join request with items to filter by owner_id
                    string query = @"
                SELECT 
                    r.request_id,
                    r.borrower_id,
                    r.borrow_date,
                    r.return_date,
                    r.created_at,
                    r.item_id,
                    r.status_id,
                    i.item_name,
                    i.owner_id,
                    i.category_id,
                    i.description,
                    u.first_name,
                    u.last_name,
                    u.contact,
                    u.address
                FROM request r
                INNER JOIN items i ON r.item_id = i.item_id
                INNER JOIN users u ON r.borrower_id = u.user_id
                WHERE i.owner_id = @ownerID AND status_id = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ownerID", user_id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int requestId = Convert.ToInt32(reader["request_id"]);
                        int borrowerId = Convert.ToInt32(reader["borrower_id"]);
                        DateTime borrowDate = Convert.ToDateTime(reader["borrow_date"]);
                        DateTime returnDate = Convert.ToDateTime(reader["return_date"]);
                        DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                        int itemId = Convert.ToInt32(reader["item_id"]);
                        int statusId = Convert.ToInt32(reader["status_id"]);
                        string itemName = reader["item_name"].ToString();
                        string contact = reader["contact"].ToString();
                        string address = reader["address"].ToString();
                        string borrowerName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                        
                        flowLayoutPanel1.Controls.Add(new RequestsCard(requestId, borrowerName, contact, address, itemName, borrowDate.ToString("yyyy-MM-dd") + " - " + returnDate.ToString("yyyy-MM-dd"), itemId ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
