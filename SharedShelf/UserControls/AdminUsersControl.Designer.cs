namespace SharedShelf.UserControls
{
    partial class AdminUsersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.lname_label = new System.Windows.Forms.Label();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.contact_label = new System.Windows.Forms.Label();
            this.contact_tb = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.Role_Label = new System.Windows.Forms.Label();
            this.role_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.updateUser_btn = new System.Windows.Forms.Button();
            this.delete_label = new System.Windows.Forms.Label();
            this.delete_tb = new System.Windows.Forms.TextBox();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Manage Users and Their Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 67);
            this.label1.TabIndex = 16;
            this.label1.Text = "Users Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 230);
            this.dataGridView1.TabIndex = 18;
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(29, 137);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(180, 22);
            this.search_tb.TabIndex = 19;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(215, 137);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(143, 453);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(180, 22);
            this.username_tb.TabIndex = 22;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.username_label.Location = new System.Drawing.Point(25, 451);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(94, 23);
            this.username_label.TabIndex = 23;
            this.username_label.Text = "Username:";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.fname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.fname_label.Location = new System.Drawing.Point(25, 479);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(107, 23);
            this.fname_label.TabIndex = 27;
            this.fname_label.Text = "First Name: ";
            // 
            // fname_tb
            // 
            this.fname_tb.Location = new System.Drawing.Point(143, 481);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(180, 22);
            this.fname_tb.TabIndex = 26;
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.lname_label.Location = new System.Drawing.Point(25, 506);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(99, 23);
            this.lname_label.TabIndex = 29;
            this.lname_label.Text = "Last Name:";
            // 
            // lname_tb
            // 
            this.lname_tb.Location = new System.Drawing.Point(143, 508);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(180, 22);
            this.lname_tb.TabIndex = 28;
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.contact_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.contact_label.Location = new System.Drawing.Point(342, 453);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(77, 23);
            this.contact_label.TabIndex = 31;
            this.contact_label.Text = "Contact:";
            // 
            // contact_tb
            // 
            this.contact_tb.Location = new System.Drawing.Point(460, 455);
            this.contact_tb.Name = "contact_tb";
            this.contact_tb.Size = new System.Drawing.Size(180, 22);
            this.contact_tb.TabIndex = 30;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.address_label.Location = new System.Drawing.Point(342, 484);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(79, 23);
            this.address_label.TabIndex = 33;
            this.address_label.Text = "Address:";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(460, 486);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(180, 22);
            this.address_tb.TabIndex = 32;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.password_label.Location = new System.Drawing.Point(342, 513);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(90, 23);
            this.password_label.TabIndex = 35;
            this.password_label.Text = "Password:";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(460, 515);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(180, 22);
            this.password_tb.TabIndex = 34;
            // 
            // Role_Label
            // 
            this.Role_Label.AutoSize = true;
            this.Role_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Role_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.Role_Label.Location = new System.Drawing.Point(25, 532);
            this.Role_Label.Name = "Role_Label";
            this.Role_Label.Size = new System.Drawing.Size(50, 23);
            this.Role_Label.TabIndex = 37;
            this.Role_Label.Text = "Role:";
            // 
            // role_box
            // 
            this.role_box.FormattingEnabled = true;
            this.role_box.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.role_box.Location = new System.Drawing.Point(143, 536);
            this.role_box.Name = "role_box";
            this.role_box.Size = new System.Drawing.Size(180, 24);
            this.role_box.TabIndex = 38;
            this.role_box.Text = "Select Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(23, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "User Actions";
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(699, 457);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(219, 37);
            this.addUser_btn.TabIndex = 39;
            this.addUser_btn.Text = "Add User";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // updateUser_btn
            // 
            this.updateUser_btn.Location = new System.Drawing.Point(699, 508);
            this.updateUser_btn.Name = "updateUser_btn";
            this.updateUser_btn.Size = new System.Drawing.Size(219, 37);
            this.updateUser_btn.TabIndex = 40;
            this.updateUser_btn.Text = "Update User";
            this.updateUser_btn.UseVisualStyleBackColor = true;
            this.updateUser_btn.Click += new System.EventHandler(this.updateUser_btn_Click);
            // 
            // delete_label
            // 
            this.delete_label.AutoSize = true;
            this.delete_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.delete_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.delete_label.Location = new System.Drawing.Point(25, 662);
            this.delete_label.Name = "delete_label";
            this.delete_label.Size = new System.Drawing.Size(73, 23);
            this.delete_label.TabIndex = 42;
            this.delete_label.Text = "User ID:";
            // 
            // delete_tb
            // 
            this.delete_tb.Location = new System.Drawing.Point(143, 664);
            this.delete_tb.Name = "delete_tb";
            this.delete_tb.Size = new System.Drawing.Size(180, 22);
            this.delete_tb.TabIndex = 41;
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.Location = new System.Drawing.Point(29, 707);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(219, 37);
            this.deleteUser_btn.TabIndex = 43;
            this.deleteUser_btn.Text = "Remove User";
            this.deleteUser_btn.UseVisualStyleBackColor = true;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // AdminUsersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.deleteUser_btn);
            this.Controls.Add(this.delete_label);
            this.Controls.Add(this.delete_tb);
            this.Controls.Add(this.updateUser_btn);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.role_box);
            this.Controls.Add(this.Role_Label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.contact_tb);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminUsersControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.Load += new System.EventHandler(this.AdminUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.TextBox contact_tb;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.ComboBox role_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Button updateUser_btn;
        private System.Windows.Forms.Label delete_label;
        private System.Windows.Forms.TextBox delete_tb;
        private System.Windows.Forms.Button deleteUser_btn;
    }
}
