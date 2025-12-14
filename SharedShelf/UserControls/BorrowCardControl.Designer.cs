namespace SharedShelf.UserControls
{
    partial class BorrowCardControl
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
            this.category_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.decription_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.borrow_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.decription_label);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 123);
            this.panel1.TabIndex = 1;
            // 
            // category_label
            // 
            this.category_label.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.category_label.Location = new System.Drawing.Point(583, 76);
            this.category_label.Name = "category_label";
            this.category_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.category_label.Size = new System.Drawing.Size(188, 23);
            this.category_label.TabIndex = 25;
            this.category_label.Text = "Tools";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 23;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // decription_label
            // 
            this.decription_label.AutoSize = true;
            this.decription_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decription_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.decription_label.Location = new System.Drawing.Point(144, 76);
            this.decription_label.Name = "decription_label";
            this.decription_label.Size = new System.Drawing.Size(312, 23);
            this.decription_label.TabIndex = 22;
            this.decription_label.Text = "A bit worned out but no missing pages.";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.title_label.Location = new System.Drawing.Point(138, 4);
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
            // borrow_btn
            // 
            this.borrow_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.borrow_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.borrow_btn.Location = new System.Drawing.Point(677, 9);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(90, 29);
            this.borrow_btn.TabIndex = 53;
            this.borrow_btn.Text = "Borrow";
            this.borrow_btn.UseVisualStyleBackColor = false;
            this.borrow_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(683, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 29);
            this.panel3.TabIndex = 54;
            // 
            // BorrowCardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "BorrowCardControl";
            this.Size = new System.Drawing.Size(818, 144);
            this.Load += new System.EventHandler(this.BorrowCardControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label decription_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Panel panel3;
    }
}
