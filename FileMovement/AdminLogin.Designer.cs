namespace FileMovement
{
    partial class AdminLogin
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnAdminSignUp = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(158, 237);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(88, 33);
            this.btnAdminLogin.TabIndex = 45;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnAdminSignUp
            // 
            this.btnAdminSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSignUp.Location = new System.Drawing.Point(290, 237);
            this.btnAdminSignUp.Name = "btnAdminSignUp";
            this.btnAdminSignUp.Size = new System.Drawing.Size(88, 33);
            this.btnAdminSignUp.TabIndex = 44;
            this.btnAdminSignUp.Text = "Sign Up";
            this.btnAdminSignUp.UseVisualStyleBackColor = true;
            this.btnAdminSignUp.Click += new System.EventHandler(this.btnAdminSignUp_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(259, 168);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(186, 20);
            this.txtAdminPassword.TabIndex = 43;
            this.txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(259, 118);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(186, 20);
            this.txtAdminUsername.TabIndex = 42;
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.Location = new System.Drawing.Point(185, 42);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(168, 31);
            this.lblAdminLogin.TabIndex = 41;
            this.lblAdminLogin.Text = "Admin Login";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(109, 164);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(108, 24);
            this.lblAdminPassword.TabIndex = 40;
            this.lblAdminPassword.Text = "Password :";
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUsername.Location = new System.Drawing.Point(96, 113);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(121, 24);
            this.lblAdminUsername.TabIndex = 39;
            this.lblAdminUsername.Text = "User Name :";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnAdminSignUp);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminUsername);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.lblAdminUsername);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnAdminSignUp;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblAdminUsername;
    }
}