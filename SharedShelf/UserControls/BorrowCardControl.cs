using SharedShelf.modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf.UserControls
{
    public partial class BorrowCardControl : UserControl
    {
        private int itemID;
        private int borrowerID;
        public BorrowCardControl(string title, string desc, string category, int itemID, string borrowerID)
        {
            InitializeComponent();
            title_label.Text = title;
            decription_label.Text = desc;
            category_label.Text = toStringCategory(category);
            this.itemID = itemID;
            this.borrowerID = Convert.ToInt32(borrowerID);
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

        private void BorrowCardControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = new RequestItemForm(borrowerID, itemID).ShowDialog();

            // If request was successful, remove this card
            if (result == DialogResult.OK)
            {
                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
            }

        }
    }
}
