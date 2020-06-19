namespace FileMovement
{
    partial class Department_Login
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
            this.btnDeptLogin = new System.Windows.Forms.Button();
            this.btnDeptSignUp = new System.Windows.Forms.Button();
            this.txtDeptPassword = new System.Windows.Forms.TextBox();
            this.txtDeptUsername = new System.Windows.Forms.TextBox();
            this.lblDeptLogin = new System.Windows.Forms.Label();
            this.lblDeptPassword = new System.Windows.Forms.Label();
            this.lblDeptUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeptLogin
            // 
            this.btnDeptLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptLogin.Location = new System.Drawing.Point(158, 237);
            this.btnDeptLogin.Name = "btnDeptLogin";
            this.btnDeptLogin.Size = new System.Drawing.Size(88, 33);
            this.btnDeptLogin.TabIndex = 45;
            this.btnDeptLogin.Text = "Login";
            this.btnDeptLogin.UseVisualStyleBackColor = true;
            this.btnDeptLogin.Click += new System.EventHandler(this.btnDeptLogin_Click);
            // 
            // btnDeptSignUp
            // 
            this.btnDeptSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptSignUp.Location = new System.Drawing.Point(290, 237);
            this.btnDeptSignUp.Name = "btnDeptSignUp";
            this.btnDeptSignUp.Size = new System.Drawing.Size(88, 33);
            this.btnDeptSignUp.TabIndex = 44;
            this.btnDeptSignUp.Text = "Sign Up";
            this.btnDeptSignUp.UseVisualStyleBackColor = true;
            this.btnDeptSignUp.Click += new System.EventHandler(this.btnDeptSignUp_Click);
            // 
            // txtDeptPassword
            // 
            this.txtDeptPassword.Location = new System.Drawing.Point(259, 168);
            this.txtDeptPassword.Name = "txtDeptPassword";
            this.txtDeptPassword.Size = new System.Drawing.Size(186, 20);
            this.txtDeptPassword.TabIndex = 43;
            this.txtDeptPassword.UseSystemPasswordChar = true;
            // 
            // txtDeptUsername
            // 
            this.txtDeptUsername.Location = new System.Drawing.Point(259, 118);
            this.txtDeptUsername.Name = "txtDeptUsername";
            this.txtDeptUsername.Size = new System.Drawing.Size(186, 20);
            this.txtDeptUsername.TabIndex = 42;
            // 
            // lblDeptLogin
            // 
            this.lblDeptLogin.AutoSize = true;
            this.lblDeptLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptLogin.Location = new System.Drawing.Point(152, 38);
            this.lblDeptLogin.Name = "lblDeptLogin";
            this.lblDeptLogin.Size = new System.Drawing.Size(229, 31);
            this.lblDeptLogin.TabIndex = 41;
            this.lblDeptLogin.Text = "Department Login";
            // 
            // lblDeptPassword
            // 
            this.lblDeptPassword.AutoSize = true;
            this.lblDeptPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptPassword.Location = new System.Drawing.Point(109, 164);
            this.lblDeptPassword.Name = "lblDeptPassword";
            this.lblDeptPassword.Size = new System.Drawing.Size(108, 24);
            this.lblDeptPassword.TabIndex = 40;
            this.lblDeptPassword.Text = "Password :";
            // 
            // lblDeptUsername
            // 
            this.lblDeptUsername.AutoSize = true;
            this.lblDeptUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptUsername.Location = new System.Drawing.Point(96, 113);
            this.lblDeptUsername.Name = "lblDeptUsername";
            this.lblDeptUsername.Size = new System.Drawing.Size(121, 24);
            this.lblDeptUsername.TabIndex = 39;
            this.lblDeptUsername.Text = "User Name :";
            // 
            // Department_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnDeptLogin);
            this.Controls.Add(this.btnDeptSignUp);
            this.Controls.Add(this.txtDeptPassword);
            this.Controls.Add(this.txtDeptUsername);
            this.Controls.Add(this.lblDeptLogin);
            this.Controls.Add(this.lblDeptPassword);
            this.Controls.Add(this.lblDeptUsername);
            this.Name = "Department_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department_Login";
            this.Load += new System.EventHandler(this.Department_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeptLogin;
        private System.Windows.Forms.Button btnDeptSignUp;
        private System.Windows.Forms.TextBox txtDeptPassword;
        private System.Windows.Forms.TextBox txtDeptUsername;
        private System.Windows.Forms.Label lblDeptLogin;
        private System.Windows.Forms.Label lblDeptPassword;
        private System.Windows.Forms.Label lblDeptUsername;
    }
}