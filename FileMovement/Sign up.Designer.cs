namespace FileMovement
{
    partial class Sign_up
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpUserName = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.lblSignUpUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(357, 237);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(88, 33);
            this.btnSignUp.TabIndex = 37;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Location = new System.Drawing.Point(259, 168);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(186, 20);
            this.txtSignUpPassword.TabIndex = 36;
            this.txtSignUpPassword.UseSystemPasswordChar = true;
            // 
            // txtSignUpUserName
            // 
            this.txtSignUpUserName.Location = new System.Drawing.Point(259, 118);
            this.txtSignUpUserName.Name = "txtSignUpUserName";
            this.txtSignUpUserName.Size = new System.Drawing.Size(186, 20);
            this.txtSignUpUserName.TabIndex = 35;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(211, 43);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(107, 31);
            this.lblSignUp.TabIndex = 34;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUpWelcome_Click);
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpPassword.Location = new System.Drawing.Point(109, 164);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(108, 24);
            this.lblSignUpPassword.TabIndex = 33;
            this.lblSignUpPassword.Text = "Password :";
            // 
            // lblSignUpUserName
            // 
            this.lblSignUpUserName.AutoSize = true;
            this.lblSignUpUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpUserName.Location = new System.Drawing.Point(96, 113);
            this.lblSignUpUserName.Name = "lblSignUpUserName";
            this.lblSignUpUserName.Size = new System.Drawing.Size(121, 24);
            this.lblSignUpUserName.TabIndex = 32;
            this.lblSignUpUserName.Text = "User Name :";
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtSignUpPassword);
            this.Controls.Add(this.txtSignUpUserName);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblSignUpPassword);
            this.Controls.Add(this.lblSignUpUserName);
            this.Name = "Sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtSignUpUserName;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.Label lblSignUpUserName;
    }
}