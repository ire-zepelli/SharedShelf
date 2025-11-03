using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SharedShelf
{
    public partial class Form1 : Form
    {
        static SharedShelfDBEntities1 database = new SharedShelfDBEntities1();
        public Form1()
        {
            InitializeComponent();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerControl1.Visible = true;
        }

        private void login_btn_Clicked(object sender, EventArgs e)
        {
            String username = username_tb.Text;
            String password = HashPassword(password_tb.Text);
            var user = database.user_auth.Where(u => u.username == username && u.password == password).FirstOrDefault();

            if (user == null) {
                MessageBox.Show("Invalid username or password");
                return;
            }

            if (user.user_type == "Admin") {
                new AdminForm(user.users.FirstOrDefault()).Show();
                this.Hide();
            }
            else
            {
                new UserForm(user.users.FirstOrDefault()).Show();
                this.Hide();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
