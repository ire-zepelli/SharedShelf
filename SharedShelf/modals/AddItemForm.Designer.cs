namespace SharedShelf.modals
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.name_label = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.category_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.name_label.Location = new System.Drawing.Point(21, 188);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(104, 23);
            this.name_label.TabIndex = 32;
            this.name_label.Text = "Item Name:";
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.name_tb.Location = new System.Drawing.Point(25, 223);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(180, 25);
            this.name_tb.TabIndex = 21;
            // 
            // category_box
            // 
            this.category_box.Font = new System.Drawing.Font("Segoe UI", 8F);
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
            this.category_box.Location = new System.Drawing.Point(317, 223);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(180, 25);
            this.category_box.TabIndex = 42;
            this.category_box.Text = "Select Category";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.category_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.category_label.Location = new System.Drawing.Point(313, 188);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(89, 23);
            this.category_label.TabIndex = 28;
            this.category_label.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(21, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Description:";
            // 
            // desc_tb
            // 
            this.desc_tb.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.desc_tb.Location = new System.Drawing.Point(25, 304);
            this.desc_tb.Multiline = true;
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(558, 122);
            this.desc_tb.TabIndex = 43;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label.Location = new System.Drawing.Point(178, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(249, 46);
            this.label.TabIndex = 48;
            this.label.Text = "List New Item";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(253, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 90);
            this.panel2.TabIndex = 47;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.add_btn.Location = new System.Drawing.Point(370, 449);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(90, 29);
            this.add_btn.TabIndex = 49;
            this.add_btn.Text = "Add Item";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(376, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 29);
            this.panel1.TabIndex = 50;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.IndianRed;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancel_btn.Location = new System.Drawing.Point(489, 449);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(90, 29);
            this.cancel_btn.TabIndex = 51;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(495, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 29);
            this.panel3.TabIndex = 52;
            // 
            // AddItemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(599, 496);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_tb);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharedShelf - Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel3;
    }
}