namespace SharedShelf.UserControls
{
    partial class AdminItemsControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_label = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.category_label = new System.Windows.Forms.Label();
            this.updateItem_btn = new System.Windows.Forms.Button();
            this.deleteItem_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage current listed items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 67);
            this.label1.TabIndex = 18;
            this.label1.Text = "Items Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(9, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 35);
            this.label3.TabIndex = 26;
            this.label3.Text = "Actions";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(201, 122);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 25;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(15, 122);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(180, 22);
            this.search_tb.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 230);
            this.dataGridView1.TabIndex = 23;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.id_label.Location = new System.Drawing.Point(11, 442);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(75, 23);
            this.id_label.TabIndex = 28;
            this.id_label.Text = "Item ID:";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(129, 444);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(180, 22);
            this.id_tb.TabIndex = 27;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.name_label.Location = new System.Drawing.Point(11, 468);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(104, 23);
            this.name_label.TabIndex = 30;
            this.name_label.Text = "Item Name:";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(129, 470);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(180, 22);
            this.name_tb.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(11, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Description:";
            // 
            // desc_tb
            // 
            this.desc_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.desc_tb.Location = new System.Drawing.Point(129, 496);
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(180, 22);
            this.desc_tb.TabIndex = 31;
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
            this.category_box.Location = new System.Drawing.Point(449, 441);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(180, 24);
            this.category_box.TabIndex = 40;
            this.category_box.Text = "Select Category";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.category_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.category_label.Location = new System.Drawing.Point(351, 442);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(89, 23);
            this.category_label.TabIndex = 39;
            this.category_label.Text = "Category:";
            // 
            // updateItem_btn
            // 
            this.updateItem_btn.Location = new System.Drawing.Point(685, 442);
            this.updateItem_btn.Name = "updateItem_btn";
            this.updateItem_btn.Size = new System.Drawing.Size(219, 37);
            this.updateItem_btn.TabIndex = 42;
            this.updateItem_btn.Text = "Update Item";
            this.updateItem_btn.UseVisualStyleBackColor = true;
            this.updateItem_btn.Click += new System.EventHandler(this.updateItem_btn_Click);
            // 
            // deleteItem_btn
            // 
            this.deleteItem_btn.Location = new System.Drawing.Point(685, 485);
            this.deleteItem_btn.Name = "deleteItem_btn";
            this.deleteItem_btn.Size = new System.Drawing.Size(219, 37);
            this.deleteItem_btn.TabIndex = 46;
            this.deleteItem_btn.Text = "Remove Item";
            this.deleteItem_btn.UseVisualStyleBackColor = true;
            this.deleteItem_btn.Click += new System.EventHandler(this.deleteItem_btn_Click);
            // 
            // AdminItemsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.Controls.Add(this.deleteItem_btn);
            this.Controls.Add(this.updateItem_btn);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminItemsControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.Load += new System.EventHandler(this.AdminItemsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button updateItem_btn;
        private System.Windows.Forms.Button deleteItem_btn;
    }
}
