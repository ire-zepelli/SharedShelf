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
    public partial class UserSelfControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        private int userId;
        public UserSelfControl()
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
            flowLayoutPanel1.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM items WHERE owner_id = @userID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
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

                    flowLayoutPanel1.Controls.Add(new ItemCardControl(itemId + "", itemName, description, categoryId + ""));
                }

            }
        }   

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(userId + "");
            addItemForm.ShowDialog();
            LoadData();
        }

        private void UserSelfControl_Load(object sender, EventArgs e)
        {

        }

        private void borrowed_btn_Click(object sender, EventArgs e)
        {
            Borrows borrows = new Borrows(userId + "");
            borrows.ShowDialog();
            LoadData();
        }
    }
}
