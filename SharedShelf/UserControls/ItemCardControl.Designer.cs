namespace SharedShelf.UserControls
{
    partial class ItemCardControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.category_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.status_label);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.description_label);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 123);
            this.panel1.TabIndex = 0;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.edit_btn.Location = new System.Drawing.Point(660, 75);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(90, 29);
            this.edit_btn.TabIndex = 51;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(768, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 29);
            this.panel4.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(666, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 29);
            this.panel3.TabIndex = 52;
            // 
            // category_label
            // 
            this.category_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.category_label.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.category_label.Location = new System.Drawing.Point(146, 57);
            this.category_label.Name = "category_label";
            this.category_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.category_label.Size = new System.Drawing.Size(251, 23);
            this.category_label.TabIndex = 25;
            this.category_label.Text = "Miscellaneous";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.description_label.Location = new System.Drawing.Point(146, 83);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(312, 23);
            this.description_label.TabIndex = 22;
            this.description_label.Text = "A bit worned out but no missing pages.";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.title_label.Location = new System.Drawing.Point(140, 12);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(277, 59);
            this.title_label.TabIndex = 16;
            this.title_label.Text = "Harry Potter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 100);
            this.panel2.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.IndianRed;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delete_btn.Location = new System.Drawing.Point(762, 75);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(90, 29);
            this.delete_btn.TabIndex = 53;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // status_label
            // 
            this.status_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.status_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status_label.Location = new System.Drawing.Point(614, 11);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(238, 23);
            this.status_label.TabIndex = 55;
            this.status_label.Text = "✪ Active";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemCardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ItemCardControl";
            this.Size = new System.Drawing.Size(891, 137);
            this.Load += new System.EventHandler(this.ItemCardControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label status_label;
    }
}
