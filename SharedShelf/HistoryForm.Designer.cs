namespace SharedShelf
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.label.Location = new System.Drawing.Point(128, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(349, 46);
            this.label.TabIndex = 13;
            this.label.Text = "Transaction History";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(257, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 90);
            this.panel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.historyControl1);
            this.flowLayoutPanel1.Controls.Add(this.historyControl2);
            this.flowLayoutPanel1.Controls.Add(this.historyControl3);
            this.flowLayoutPanel1.Controls.Add(this.historyControl4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 422);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // HistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(625, 609);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel2);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.HistoryControl historyControl1;
        private UserControls.HistoryControl historyControl2;
        private UserControls.HistoryControl historyControl3;
        private UserControls.HistoryControl historyControl4;
    }
}