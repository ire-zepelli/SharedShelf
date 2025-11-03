namespace SharedShelf
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selected_panel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardControl1 = new SharedShelf.UserControls.DashboardControl();
            this.adminUsersControl1 = new SharedShelf.UserControls.AdminUsersControl();
            this.adminItemsControl1 = new SharedShelf.UserControls.AdminItemsControl();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.selected_panel);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.welcome_label);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 815);
            this.panel1.TabIndex = 0;
            // 
            // selected_panel
            // 
            this.selected_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.selected_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.selected_panel.Location = new System.Drawing.Point(24, 718);
            this.selected_panel.Name = "selected_panel";
            this.selected_panel.Size = new System.Drawing.Size(10, 69);
            this.selected_panel.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(39, 721);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 70);
            this.panel11.TabIndex = 20;
            this.panel11.Click += new System.EventHandler(this.logout_click);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(60, 60);
            this.panel12.TabIndex = 2;
            this.panel12.Click += new System.EventHandler(this.logout_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(66, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 46);
            this.label5.TabIndex = 15;
            this.label5.Text = "Logout";
            this.label5.Click += new System.EventHandler(this.logout_click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(39, 636);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 70);
            this.panel9.TabIndex = 19;
            this.panel9.Click += new System.EventHandler(this.settings_click);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 60);
            this.panel10.TabIndex = 2;
            this.panel10.Click += new System.EventHandler(this.settings_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(66, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "Settings";
            this.label4.Click += new System.EventHandler(this.settings_click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(39, 406);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 70);
            this.panel7.TabIndex = 18;
            this.panel7.Click += new System.EventHandler(this.users_click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 60);
            this.panel8.TabIndex = 2;
            this.panel8.Click += new System.EventHandler(this.users_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(66, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Users";
            this.label3.Click += new System.EventHandler(this.users_click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(39, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 70);
            this.panel5.TabIndex = 17;
            this.panel5.Click += new System.EventHandler(this.items_click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 60);
            this.panel6.TabIndex = 2;
            this.panel6.Click += new System.EventHandler(this.items_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(66, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Items";
            this.label2.Click += new System.EventHandler(this.items_click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(39, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 70);
            this.panel3.TabIndex = 16;
            this.panel3.Click += new System.EventHandler(this.dashboard_click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.dashboard_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(66, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.dashboard_click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.welcome_label.Location = new System.Drawing.Point(187, 74);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(104, 23);
            this.welcome_label.TabIndex = 14;
            this.welcome_label.Text = "Admin Side";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label.Location = new System.Drawing.Point(132, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(219, 46);
            this.label.TabIndex = 9;
            this.label.Text = "SharedShelf";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(22, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 92);
            this.panel2.TabIndex = 1;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.dashboardControl1.Location = new System.Drawing.Point(365, 0);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(963, 811);
            this.dashboardControl1.TabIndex = 4;
            // 
            // adminUsersControl1
            // 
            this.adminUsersControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.adminUsersControl1.Location = new System.Drawing.Point(357, 0);
            this.adminUsersControl1.Name = "adminUsersControl1";
            this.adminUsersControl1.Size = new System.Drawing.Size(963, 811);
            this.adminUsersControl1.TabIndex = 2;
            // 
            // adminItemsControl1
            // 
            this.adminItemsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.adminItemsControl1.Location = new System.Drawing.Point(365, 0);
            this.adminItemsControl1.Name = "adminItemsControl1";
            this.adminItemsControl1.Size = new System.Drawing.Size(963, 811);
            this.adminItemsControl1.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1340, 810);
            this.Controls.Add(this.dashboardControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminUsersControl1);
            this.Controls.Add(this.adminItemsControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharedShelf | Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel selected_panel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private UserControls.AdminUsersControl adminUsersControl1;
        private UserControls.AdminItemsControl adminItemsControl1;
        private UserControls.DashboardControl dashboardControl1;
    }
}