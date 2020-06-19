namespace FileMovement
{
    partial class Student_Login
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
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.btnStudentSignUp = new System.Windows.Forms.Button();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtStudentUsername = new System.Windows.Forms.TextBox();
            this.lblStudentLogin = new System.Windows.Forms.Label();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.Location = new System.Drawing.Point(158, 237);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(88, 33);
            this.btnStudentLogin.TabIndex = 45;
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // btnStudentSignUp
            // 
            this.btnStudentSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSignUp.Location = new System.Drawing.Point(290, 237);
            this.btnStudentSignUp.Name = "btnStudentSignUp";
            this.btnStudentSignUp.Size = new System.Drawing.Size(88, 33);
            this.btnStudentSignUp.TabIndex = 44;
            this.btnStudentSignUp.Text = "Sign Up";
            this.btnStudentSignUp.UseVisualStyleBackColor = true;
            this.btnStudentSignUp.Click += new System.EventHandler(this.btnStudentSignUp_Click);
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Location = new System.Drawing.Point(259, 168);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(186, 20);
            this.txtStudentPassword.TabIndex = 43;
            this.txtStudentPassword.UseSystemPasswordChar = true;
            // 
            // txtStudentUsername
            // 
            this.txtStudentUsername.Location = new System.Drawing.Point(259, 118);
            this.txtStudentUsername.Name = "txtStudentUsername";
            this.txtStudentUsername.Size = new System.Drawing.Size(186, 20);
            this.txtStudentUsername.TabIndex = 42;
            // 
            // lblStudentLogin
            // 
            this.lblStudentLogin.AutoSize = true;
            this.lblStudentLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLogin.Location = new System.Drawing.Point(172, 42);
            this.lblStudentLogin.Name = "lblStudentLogin";
            this.lblStudentLogin.Size = new System.Drawing.Size(179, 31);
            this.lblStudentLogin.TabIndex = 41;
            this.lblStudentLogin.Text = "Student Login";
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPassword.Location = new System.Drawing.Point(109, 164);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(108, 24);
            this.lblStudentPassword.TabIndex = 40;
            this.lblStudentPassword.Text = "Password :";
            // 
            // lblStudentUsername
            // 
            this.lblStudentUsername.AutoSize = true;
            this.lblStudentUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentUsername.Location = new System.Drawing.Point(96, 113);
            this.lblStudentUsername.Name = "lblStudentUsername";
            this.lblStudentUsername.Size = new System.Drawing.Size(121, 24);
            this.lblStudentUsername.TabIndex = 39;
            this.lblStudentUsername.Text = "User Name :";
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.btnStudentSignUp);
            this.Controls.Add(this.txtStudentPassword);
            this.Controls.Add(this.txtStudentUsername);
            this.Controls.Add(this.lblStudentLogin);
            this.Controls.Add(this.lblStudentPassword);
            this.Controls.Add(this.lblStudentUsername);
            this.Name = "Student_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Login";
            this.Load += new System.EventHandler(this.Student_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Button btnStudentSignUp;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.TextBox txtStudentUsername;
        private System.Windows.Forms.Label lblStudentLogin;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentUsername;
    }
}