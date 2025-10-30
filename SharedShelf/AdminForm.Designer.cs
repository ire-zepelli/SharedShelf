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
            this.logout_btn = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.settings_btn = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.items_btn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.users_btn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.selected_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard_btn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dashboardControl1 = new SharedShelf.UserControls.DashboardControl();
            this.adminUsersControl1 = new SharedShelf.UserControls.AdminUsersControl();
            this.adminItemsControl1 = new SharedShelf.UserControls.AdminItemsControl();
            this.panel1.SuspendLayout();
            this.logout_btn.SuspendLayout();
            this.settings_btn.SuspendLayout();
            this.items_btn.SuspendLayout();
            this.users_btn.SuspendLayout();
            this.dashboard_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.items_btn);
            this.panel1.Controls.Add(this.users_btn);
            this.panel1.Controls.Add(this.selected_panel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 816);
            this.panel1.TabIndex = 10;
            // 
            // logout_btn
            // 
            this.logout_btn.Controls.Add(this.label7);
            this.logout_btn.Controls.Add(this.panel12);
            this.logout_btn.Location = new System.Drawing.Point(43, 723);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(266, 74);
            this.logout_btn.TabIndex = 18;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Onclick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(70, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 46);
            this.label7.TabIndex = 14;
            this.label7.Text = "Logout";
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Location = new System.Drawing.Point(4, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(60, 60);
            this.panel12.TabIndex = 11;
            // 
            // settings_btn
            // 
            this.settings_btn.Controls.Add(this.label6);
            this.settings_btn.Controls.Add(this.panel10);
            this.settings_btn.Location = new System.Drawing.Point(43, 628);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(266, 74);
            this.settings_btn.TabIndex = 17;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn__Onclick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(70, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 46);
            this.label6.TabIndex = 14;
            this.label6.Text = "Settings";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(4, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 60);
            this.panel10.TabIndex = 11;
            // 
            // items_btn
            // 
            this.items_btn.Controls.Add(this.label5);
            this.items_btn.Controls.Add(this.panel6);
            this.items_btn.Location = new System.Drawing.Point(43, 388);
            this.items_btn.Name = "items_btn";
            this.items_btn.Size = new System.Drawing.Size(266, 74);
            this.items_btn.TabIndex = 16;
            this.items_btn.Click += new System.EventHandler(this.items_btn_Onclick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(70, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "Items";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(4, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 60);
            this.panel6.TabIndex = 11;
            // 
            // users_btn
            // 
            this.users_btn.Controls.Add(this.label4);
            this.users_btn.Controls.Add(this.panel9);
            this.users_btn.Location = new System.Drawing.Point(43, 292);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(266, 74);
            this.users_btn.TabIndex = 15;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Onclick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(70, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "Users";
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(4, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(60, 60);
            this.panel9.TabIndex = 11;
            // 
            // selected_panel
            // 
            this.selected_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.selected_panel.Location = new System.Drawing.Point(15, 198);
            this.selected_panel.Name = "selected_panel";
            this.selected_panel.Size = new System.Drawing.Size(10, 73);
            this.selected_panel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(172, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Admin Side";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "SharedShelf";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 84);
            this.panel2.TabIndex = 11;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Controls.Add(this.label3);
            this.dashboard_btn.Controls.Add(this.panel3);
            this.dashboard_btn.Location = new System.Drawing.Point(46, 197);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(266, 74);
            this.dashboard_btn.TabIndex = 11;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Onclick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(70, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 60);
            this.panel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(381, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 46);
            this.label8.TabIndex = 11;
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.dashboardControl1.Location = new System.Drawing.Point(366, 1);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(963, 811);
            this.dashboardControl1.TabIndex = 12;
            // 
            // adminUsersControl1
            // 
            this.adminUsersControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.adminUsersControl1.Location = new System.Drawing.Point(366, 1);
            this.adminUsersControl1.Name = "adminUsersControl1";
            this.adminUsersControl1.Size = new System.Drawing.Size(963, 811);
            this.adminUsersControl1.TabIndex = 13;
            // 
            // adminItemsControl1
            // 
            this.adminItemsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.adminItemsControl1.Location = new System.Drawing.Point(366, 1);
            this.adminItemsControl1.Name = "adminItemsControl1";
            this.adminItemsControl1.Size = new System.Drawing.Size(963, 811);
            this.adminItemsControl1.TabIndex = 14;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1340, 810);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminUsersControl1);
            this.Controls.Add(this.adminItemsControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharedShelf - Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.logout_btn.ResumeLayout(false);
            this.logout_btn.PerformLayout();
            this.settings_btn.ResumeLayout(false);
            this.settings_btn.PerformLayout();
            this.items_btn.ResumeLayout(false);
            this.items_btn.PerformLayout();
            this.users_btn.ResumeLayout(false);
            this.users_btn.PerformLayout();
            this.dashboard_btn.ResumeLayout(false);
            this.dashboard_btn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel selected_panel;
        private System.Windows.Forms.Panel users_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel dashboard_btn;
        private System.Windows.Forms.Panel logout_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel settings_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel items_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private UserControls.DashboardControl dashboardControl1;
        private UserControls.AdminUsersControl adminUsersControl1;
        private UserControls.AdminItemsControl adminItemsControl1;
    }
}