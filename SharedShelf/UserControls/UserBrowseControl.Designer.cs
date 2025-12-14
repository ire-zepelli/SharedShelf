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
            this.category_box = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.borrowCardControl1 = new SharedShelf.UserControls.BorrowCardControl();
            this.borrowCardControl2 = new SharedShelf.UserControls.BorrowCardControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.filter_btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.category_box);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(62, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 611);
            this.panel1.TabIndex = 0;
            // 
            // category_box
            // 
            this.category_box.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.category_box.Size = new System.Drawing.Size(160, 28);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(29, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 65);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 47);
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
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.filter_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filter_btn.Location = new System.Drawing.Point(201, 96);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(90, 29);
            this.filter_btn.TabIndex = 53;
            this.filter_btn.Text = "Filter";
            this.filter_btn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(207, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 29);
            this.panel4.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(719, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(725, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 29);
            this.panel5.TabIndex = 56;
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
            // UserBrowseControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserBrowseControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.Load += new System.EventHandler(this.UserBrowseControl_Load);
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
        private System.Windows.Forms.ComboBox category_box;
        private BorrowCardControl borrowCardControl1;
        private BorrowCardControl borrowCardControl2;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
    }
}
