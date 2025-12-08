namespace SharedShelf.UserControls
{
    partial class UserBrowseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBrowseControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.borrowCardControl1 = new SharedShelf.UserControls.BorrowCardControl();
            this.borrowCardControl2 = new SharedShelf.UserControls.BorrowCardControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.category_box);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(62, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 611);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.Items.AddRange(new object[] {
            "Household Items",
            "Tools & Equipment",
            "Electronics",
            "Books & Media",
            "Personal Items",
            "Kids & Family",
            "Furniture",
            "Hobbies & Crafts",
            "Sports & Outdoor",
            "Miscellaneous"});
            this.category_box.Location = new System.Drawing.Point(29, 100);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(160, 24);
            this.category_box.TabIndex = 41;
            this.category_box.Text = "Filter Category";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.borrowCardControl1);
            this.flowLayoutPanel1.Controls.Add(this.borrowCardControl2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(826, 446);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // borrowCardControl1
            // 
            this.borrowCardControl1.BackColor = System.Drawing.Color.White;
            this.borrowCardControl1.Location = new System.Drawing.Point(3, 3);
            this.borrowCardControl1.Name = "borrowCardControl1";
            this.borrowCardControl1.Size = new System.Drawing.Size(809, 144);
            this.borrowCardControl1.TabIndex = 0;
            // 
            // borrowCardControl2
            // 
            this.borrowCardControl2.BackColor = System.Drawing.Color.White;
            this.borrowCardControl2.Location = new System.Drawing.Point(3, 153);
            this.borrowCardControl2.Name = "borrowCardControl2";
            this.borrowCardControl2.Size = new System.Drawing.Size(809, 144);
            this.borrowCardControl2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(29, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 65);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 47);
            this.panel3.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(63, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(749, 47);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 67);
            this.label1.TabIndex = 17;
            this.label1.Text = "Browse";
            // 
            // UserBrowseControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserBrowseControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.Button button1;
        private BorrowCardControl borrowCardControl1;
        private BorrowCardControl borrowCardControl2;
    }
}
