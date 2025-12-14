using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedShelf.modals
{
    public partial class Borrows : Form
    {
        string userID = string.Empty;
        public Borrows(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Borrows_Load(object sender, EventArgs e)
        {

        }
    }
}
