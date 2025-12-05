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
    public partial class AdminItemsControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        public AdminItemsControl()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT * FROM items";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void AdminItemsControl_Load(object sender, EventArgs e)
        {
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchTerm = search_tb.Text.Trim();
            string item_id = "";
            string item_name = "";
            string category = "";
            string description = "";

            if (searchTerm == "")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    String query = "SELECT * FROM items";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "SELECT * FROM items WHERE item_id LIKE @searchTerm";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    item_id = dt.Rows[0]["item_id"].ToString();
                    item_name = dt.Rows[0]["item_name"].ToString();
                    category = dt.Rows[0]["category_id"].ToString();
                    description = dt.Rows[0]["description"].ToString();
                    id_tb.Text = item_id;
                    name_tb.Text = item_name;
                    category_box.Text = toStringCategory(dt.Rows[0]["category_id"].ToString());
                    desc_tb.Text = description;
                }
                else
                {
                    MessageBox.Show("Item not found.");
                    clearTextboxes();
                }
            }


        }

        private void clearTextboxes()
        {
            id_tb.Text = "";
            name_tb.Text = "";
            category_box.Text = "Select Category";
            desc_tb.Text = "";
        }

        private string toStringCategory(string category_id)
        {

            string[] categories = new string[]{
            "Household Items",
            "Tools & Equipment",
            "Electronics",
            "Books & Media",
            "Personal Items",
            "Kids & Family",
            "Furniture",
            "Hobbies & Crafts",
            "Sports & Outdoor",
            "Miscellaneous"
            };


            return category_box.Items[Convert.ToInt32(category_id) - 1].ToString();
        }

        private int toIntCategory(string category_name)
        {
            string[] categories = new string[]{
            "Household Items",
            "Tools & Equipment",
            "Electronics",
            "Books & Media",
            "Personal Items",
            "Kids & Family",
            "Furniture",
            "Hobbies & Crafts",
            "Sports & Outdoor",
            "Miscellaneous"
            };

            return category_box.Items.IndexOf(category_name) + 1;
        }

        private void updateItem_btn_Click(object sender, EventArgs e)
        {
            string item_id = id_tb.Text.Trim();
            string item_name = name_tb.Text.Trim();
            string category_id = toIntCategory(category_box.Text.Trim()) + "";
            string description = desc_tb.Text.Trim();

            if (item_id == "" || item_name == "" || category_box.Text == "Select Category" || description == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "UPDATE items SET item_name=@item_name, category_id=@category_id, description=@description WHERE item_id=@item_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item updated successfully.");
                load_data();
                clearTextboxes();
            }
        }

        private void deleteItem_btn_Click(object sender, EventArgs e)
        {
            string item_id = id_tb.Text.Trim();

            if (item_id == "")
            {
                MessageBox.Show("Please enter an Item ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "DELETE FROM items WHERE item_id=@item_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item deleted successfully.");
                load_data();
                clearTextboxes();
            }
        }
    }
}
