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
    public partial class EditItemForm : Form
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";
        string item_id;
        public EditItemForm(string item_id, string title, string category, string desc)
        {
            InitializeComponent();
            this.item_id = item_id;
            name_tb.Text = title;
            category_box.SelectedIndex = Convert.ToInt32(category) - 1; // Set selected index based on category_id
            desc_tb.Text = desc;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE items SET item_name = @name, category_id = @category, description = @description WHERE item_id = @item_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name_tb.Text);
                cmd.Parameters.AddWithValue("@category", toIntCategory(category_box.Text));
                cmd.Parameters.AddWithValue("@description", desc_tb.Text);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item updated successfully!");

                this.Close();
            }
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
