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
            this.add_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemCardControl1 = new SharedShelf.UserControls.ItemCardControl();
            this.itemCardControl2 = new SharedShelf.UserControls.ItemCardControl();
            this.itemCardControl3 = new SharedShelf.UserControls.ItemCardControl();
            this.flowLayoutPanel1.SuspendLayout();
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
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(263, 34);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(89, 40);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "Add Item";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.itemCardControl1);
            this.flowLayoutPanel1.Controls.Add(this.itemCardControl2);
            this.flowLayoutPanel1.Controls.Add(this.itemCardControl3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 625);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // itemCardControl1
            // 
            this.itemCardControl1.BackColor = System.Drawing.Color.White;
            this.itemCardControl1.Location = new System.Drawing.Point(3, 3);
            this.itemCardControl1.Name = "itemCardControl1";
            this.itemCardControl1.Size = new System.Drawing.Size(891, 143);
            this.itemCardControl1.TabIndex = 0;
            // 
            // itemCardControl2
            // 
            this.itemCardControl2.BackColor = System.Drawing.Color.White;
            this.itemCardControl2.Location = new System.Drawing.Point(3, 152);
            this.itemCardControl2.Name = "itemCardControl2";
            this.itemCardControl2.Size = new System.Drawing.Size(891, 143);
            this.itemCardControl2.TabIndex = 1;
            // 
            // itemCardControl3
            // 
            this.itemCardControl3.BackColor = System.Drawing.Color.White;
            this.itemCardControl3.Location = new System.Drawing.Point(3, 301);
            this.itemCardControl3.Name = "itemCardControl3";
            this.itemCardControl3.Size = new System.Drawing.Size(891, 143);
            this.itemCardControl3.TabIndex = 2;
            // 
            // UserSelfControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Name = "UserSelfControl";
            this.Size = new System.Drawing.Size(963, 811);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ItemCardControl itemCardControl1;
        private ItemCardControl itemCardControl2;
        private ItemCardControl itemCardControl3;
    }
}
