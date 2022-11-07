namespace MusicStore
{
    partial class CRUD
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGenreCRUD = new System.Windows.Forms.ComboBox();
            this.cbArtistCRUD = new System.Windows.Forms.ComboBox();
            this.tbTitleCRUD = new System.Windows.Forms.TextBox();
            this.tbPriceCRUD = new System.Windows.Forms.TextBox();
            this.btSaveCURD = new System.Windows.Forms.Button();
            this.btCancle = new System.Windows.Forms.Button();
            this.tbimageCRUD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // cbGenreCRUD
            // 
            this.cbGenreCRUD.FormattingEnabled = true;
            this.cbGenreCRUD.Location = new System.Drawing.Point(236, 60);
            this.cbGenreCRUD.Name = "cbGenreCRUD";
            this.cbGenreCRUD.Size = new System.Drawing.Size(287, 28);
            this.cbGenreCRUD.TabIndex = 4;
            // 
            // cbArtistCRUD
            // 
            this.cbArtistCRUD.FormattingEnabled = true;
            this.cbArtistCRUD.Location = new System.Drawing.Point(236, 141);
            this.cbArtistCRUD.Name = "cbArtistCRUD";
            this.cbArtistCRUD.Size = new System.Drawing.Size(287, 28);
            this.cbArtistCRUD.TabIndex = 5;
            // 
            // tbTitleCRUD
            // 
            this.tbTitleCRUD.Location = new System.Drawing.Point(236, 199);
            this.tbTitleCRUD.Name = "tbTitleCRUD";
            this.tbTitleCRUD.Size = new System.Drawing.Size(287, 27);
            this.tbTitleCRUD.TabIndex = 6;
            // 
            // tbPriceCRUD
            // 
            this.tbPriceCRUD.Location = new System.Drawing.Point(236, 263);
            this.tbPriceCRUD.Name = "tbPriceCRUD";
            this.tbPriceCRUD.Size = new System.Drawing.Size(125, 27);
            this.tbPriceCRUD.TabIndex = 7;
            // 
            // btSaveCURD
            // 
            this.btSaveCURD.Location = new System.Drawing.Point(182, 434);
            this.btSaveCURD.Name = "btSaveCURD";
            this.btSaveCURD.Size = new System.Drawing.Size(94, 29);
            this.btSaveCURD.TabIndex = 9;
            this.btSaveCURD.Text = "Save";
            this.btSaveCURD.UseVisualStyleBackColor = true;
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(429, 434);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(94, 29);
            this.btCancle.TabIndex = 10;
            this.btCancle.Text = "Cancel";
            this.btCancle.UseVisualStyleBackColor = true;
            // 
            // tbimageCRUD
            // 
            this.tbimageCRUD.Location = new System.Drawing.Point(236, 331);
            this.tbimageCRUD.Name = "tbimageCRUD";
            this.tbimageCRUD.Size = new System.Drawing.Size(480, 27);
            this.tbimageCRUD.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(611, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 166);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbimageCRUD);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btSaveCURD);
            this.Controls.Add(this.tbPriceCRUD);
            this.Controls.Add(this.tbTitleCRUD);
            this.Controls.Add(this.cbArtistCRUD);
            this.Controls.Add(this.cbGenreCRUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUD";
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbGenreCRUD;
        private ComboBox cbArtistCRUD;
        private TextBox tbTitleCRUD;
        private TextBox tbPriceCRUD;
        private Button btSaveCURD;
        private Button btCancle;
        private TextBox tbimageCRUD;
        private PictureBox pictureBox1;
        private Label label5;
    }
}