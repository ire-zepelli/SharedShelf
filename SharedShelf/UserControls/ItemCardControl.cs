using MahApps.Metro.Controls.Dialogs;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SharedShelf.UserControls
{
    public partial class ItemCardControl : UserControl
    {
        private string connectionString = "Server=DESKTOP-KU0OPCN\\SQLEXPRESS;Initial Catalog=SharedShelfDB;Integrated Security=True;";

        private string item_id;
        private string title;
        private string description;
        private string category;

        public ItemCardControl(string id, string title, string desc, string category)
        {
            InitializeComponent();
            this.item_id = id;
            this.title = title;
            this.description = desc;
            this.category = category;
            LoadData(title, desc, category);
        }

        public void LoadData(string title, string desc,string category) { 
            title_label.Text = title;
            description_label.Text = desc;
            category_label.Text = toStringCategory(category);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditItemForm(item_id, title, category, description).ShowDialog();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT item_name, description, category_id FROM items WHERE item_id = @item_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@item_id", item_id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        title_label.Text = reader["item_name"].ToString();
                        description_label.Text = reader["description"].ToString();
                        category_label.Text = toStringCategory(reader["category_id"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (result == "Yes")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM items WHERE item_id = @item_id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@item_id", item_id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item deleted successfully!");

                        if (this.Parent != null)
                        {
                            this.Parent.Controls.Remove(this);
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
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


            int index = Convert.ToInt32(category_id) - 1;

            if (index >= 0 && index < categories.Length)
            {
                return categories[index];
            }

            return "Unknown Category";
        }

        private void ItemCardControl_Load(object sender, EventArgs e)
        {

        }

    }
}
