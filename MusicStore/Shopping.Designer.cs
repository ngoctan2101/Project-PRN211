namespace MusicStore
{
    partial class Shopping
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenreShopping = new System.Windows.Forms.ComboBox();
            this.tbTitleShopping = new System.Windows.Forms.TextBox();
            this.btSearchShopping = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // cbGenreShopping
            // 
            this.cbGenreShopping.FormattingEnabled = true;
            this.cbGenreShopping.Location = new System.Drawing.Point(113, 50);
            this.cbGenreShopping.Name = "cbGenreShopping";
            this.cbGenreShopping.Size = new System.Drawing.Size(151, 28);
            this.cbGenreShopping.TabIndex = 2;
            this.cbGenreShopping.SelectedIndexChanged += new System.EventHandler(this.cbGenreShopping_SelectedIndexChanged);
            // 
            // tbTitleShopping
            // 
            this.tbTitleShopping.Location = new System.Drawing.Point(352, 50);
            this.tbTitleShopping.Name = "tbTitleShopping";
            this.tbTitleShopping.Size = new System.Drawing.Size(165, 27);
            this.tbTitleShopping.TabIndex = 3;
            // 
            // btSearchShopping
            // 
            this.btSearchShopping.Location = new System.Drawing.Point(592, 48);
            this.btSearchShopping.Name = "btSearchShopping";
            this.btSearchShopping.Size = new System.Drawing.Size(94, 29);
            this.btSearchShopping.TabIndex = 4;
            this.btSearchShopping.Text = "Search";
            this.btSearchShopping.UseVisualStyleBackColor = true;
            this.btSearchShopping.Click += new System.EventHandler(this.btSearchShopping_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(57, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 280);
            this.panel1.TabIndex = 5;
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(57, 421);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(94, 29);
            this.btPrevious.TabIndex = 6;
            this.btPrevious.Text = "Previous";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(199, 421);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(94, 29);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 597);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSearchShopping);
            this.Controls.Add(this.tbTitleShopping);
            this.Controls.Add(this.cbGenreShopping);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Shopping";
            this.Text = "Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbGenreShopping;
        private TextBox tbTitleShopping;
        private Button btSearchShopping;
        private Panel panel1;
        private Button btPrevious;
        private Button btNext;
    }
}