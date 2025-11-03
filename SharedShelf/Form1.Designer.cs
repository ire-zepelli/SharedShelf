namespace SharedShelf
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.registerControl1 = new SharedShelf.UserControls.RegisterControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 815);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(19, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 637);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.username_tb);
            this.panel3.Location = new System.Drawing.Point(788, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 73);
            this.panel3.TabIndex = 1;
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_tb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.username_tb.Location = new System.Drawing.Point(35, 19);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(412, 36);
            this.username_tb.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.password_tb);
            this.panel4.Location = new System.Drawing.Point(788, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 73);
            this.panel4.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.password_tb.Location = new System.Drawing.Point(28, 18);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(419, 36);
            this.password_tb.TabIndex = 7;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.Location = new System.Drawing.Point(788, 503);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(475, 73);
            this.login_btn.TabIndex = 3;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(793, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "I dont have an account yet.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.linkLabel1.Location = new System.Drawing.Point(1093, 612);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(153, 31);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register Now";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.username_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.username_label.Location = new System.Drawing.Point(819, 261);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(118, 31);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.password_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.password_label.Location = new System.Drawing.Point(817, 363);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(112, 31);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // registerControl1
            // 
            this.registerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.registerControl1.Location = new System.Drawing.Point(749, 0);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(558, 815);
            this.registerControl1.TabIndex = 8;
            this.registerControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1340, 810);
            this.Controls.Add(this.registerControl1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharedShelf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private UserControls.RegisterControl registerControl1;
    }
}

