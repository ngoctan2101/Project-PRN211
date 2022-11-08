namespace MusicStore
{
    partial class Login
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
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btLoginLogin = new System.Windows.Forms.Button();
            this.btCancelLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Location = new System.Drawing.Point(236, 92);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(171, 27);
            this.tbUsernameLogin.TabIndex = 2;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(236, 181);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(171, 27);
            this.tbPasswordLogin.TabIndex = 3;
            // 
            // btLoginLogin
            // 
            this.btLoginLogin.Location = new System.Drawing.Point(131, 306);
            this.btLoginLogin.Name = "btLoginLogin";
            this.btLoginLogin.Size = new System.Drawing.Size(94, 29);
            this.btLoginLogin.TabIndex = 4;
            this.btLoginLogin.Text = "Login";
            this.btLoginLogin.UseVisualStyleBackColor = true;
            this.btLoginLogin.Click += new System.EventHandler(this.btLoginLogin_Click);
            // 
            // btCancelLogin
            // 
            this.btCancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelLogin.Location = new System.Drawing.Point(332, 306);
            this.btCancelLogin.Name = "btCancelLogin";
            this.btCancelLogin.Size = new System.Drawing.Size(94, 29);
            this.btCancelLogin.TabIndex = 5;
            this.btCancelLogin.Text = "Cancel";
            this.btCancelLogin.UseVisualStyleBackColor = true;
            this.btCancelLogin.Click += new System.EventHandler(this.btCancelLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btCancelLogin);
            this.Controls.Add(this.btLoginLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsernameLogin;
        private TextBox tbPasswordLogin;
        private Button btLoginLogin;
        private Button btCancelLogin;
    }
}