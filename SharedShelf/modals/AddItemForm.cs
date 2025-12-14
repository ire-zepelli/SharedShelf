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
    public partial class AddItemForm : Form
    {
        public string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;"; 
        private string ownerId = null;
        public AddItemForm(string ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string category = toIntCategory(category_box.Text) + "";
            string description = desc_tb.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "INSERT INTO items (item_name, category_id, description, owner_id, date_posted) VALUES (@name, @category, @description, @owner_id, @date_posted)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@owner_id", ownerId);
                cmd.Parameters.AddWithValue("@date_posted", DateTime.Now);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item added successfully!");
            }

            this.Close();
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
    }
}
