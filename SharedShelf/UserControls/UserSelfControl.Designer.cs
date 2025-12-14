namespace SharedShelf.UserControls
{
    partial class UserSelfControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borrowed_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 67);
            this.label1.TabIndex = 16;
            this.label1.Text = "My Shelf";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 625);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.add_btn.Location = new System.Drawing.Point(270, 39);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(90, 29);
            this.add_btn.TabIndex = 51;
            this.add_btn.Text = "Add Item";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(276, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 29);
            this.panel1.TabIndex = 52;
            // 
            // borrowed_btn
            // 
            this.borrowed_btn.BackColor = System.Drawing.Color.IndianRed;
            this.borrowed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowed_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.borrowed_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borrowed_btn.Location = new System.Drawing.Point(387, 39);
            this.borrowed_btn.Name = "borrowed_btn";
            this.borrowed_btn.Size = new System.Drawing.Size(141, 29);
            this.borrowed_btn.TabIndex = 53;
            this.borrowed_btn.Text = "Borrowed Items";
            this.borrowed_btn.UseVisualStyleBackColor = false;
            this.borrowed_btn.Click += new System.EventHandler(this.borrowed_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(393, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 29);
            this.panel2.TabIndex = 54;
            // 
            // UserSelfControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borrowed_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "UserSelfControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.Load += new System.EventHandler(this.UserSelfControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button borrowed_btn;
        private System.Windows.Forms.Panel panel2;
    }
}
