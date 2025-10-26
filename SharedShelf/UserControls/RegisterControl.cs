using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SharedShelf.UserControls
{
    public partial class RegisterControl : UserControl
    {
        private static SharedShelfDBEntities1 database = new SharedShelfDBEntities1();
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                    result.Append(b.ToString("x2")); // convert to hexadecimal

                return result.ToString();
            }
        }

        private void register_btn_Clicked(object sender, EventArgs e)
        {
            String username = username_tb.Text;
            String fname = fname_tb.Text;
            String lname = lname_tb.Text;
            String contact = contact_tb.Text;
            String address = address_tb.Text;
            String password = password_tb.Text;
            String confirm_password = confirm_password_tb.Text;

            //check if the passwords are the same
            if (password != confirm_password)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            //checks if the username already exists
            var exisitngUser = database.user_auth.Where(u => u.username == username).FirstOrDefault();

            if (exisitngUser != null)
            {
                MessageBox.Show("Username already exists");
                return;
            }

            //creates a new user+auth
            user_auth newUserAuth = new user_auth()
            {
                username = username,
                password = HashPassword(password),
                created_at = DateTime.Now,
                user_type = "User"
            };

            database.user_auth.Add(newUserAuth);
            database.SaveChanges();

            //creates user probile
            users newUser = new users()
            {
                first_name = fname,
                last_name = lname,
                contact = contact,
                address = address,
                user_auth_id = newUserAuth.user_auth_id
            };

            database.users.Add(newUser);
            database.SaveChanges();

            MessageBox.Show("Registration successful!");
            ClearForm();
            this.Visible = false;
        }

        public void ClearForm()
        {
            username_tb.Text = "";
            fname_tb.Text = "";
            lname_tb.Text = "";
            contact_tb.Text = "";
            address_tb.Text = "";
            password_tb.Text = "";
            confirm_password_tb.Text = "";
        }
    }
}
