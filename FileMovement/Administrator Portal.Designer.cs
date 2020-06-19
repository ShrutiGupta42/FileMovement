namespace FileMovement
{
    partial class Administrator_Portal
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
            this.components = new System.ComponentModel.Container();
            this.signUpDataSet = new FileMovement.signUpDataSet();
            this.userSignUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSignUpTableAdapter = new FileMovement.signUpDataSetTableAdapters.UserSignUpTableAdapter();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnUserManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSignUpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpDataSet
            // 
            this.signUpDataSet.DataSetName = "signUpDataSet";
            this.signUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSignUpBindingSource
            // 
            this.userSignUpBindingSource.DataMember = "UserSignUp";
            this.userSignUpBindingSource.DataSource = this.signUpDataSet;
            // 
            // userSignUpTableAdapter
            // 
            this.userSignUpTableAdapter.ClearBeforeFill = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Olive;
            this.lblAdmin.Location = new System.Drawing.Point(386, 28);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(85, 31);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "label1";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(202, 322);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(250, 33);
            this.btnUserManagement.TabIndex = 32;
            this.btnUserManagement.Text = "Managing User Information";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // Administrator_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.lblAdmin);
            this.Name = "Administrator_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator_Portal";
            this.Load += new System.EventHandler(this.Administrator_Portal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSignUpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private signUpDataSet signUpDataSet;
        private System.Windows.Forms.BindingSource userSignUpBindingSource;
        private signUpDataSetTableAdapters.UserSignUpTableAdapter userSignUpTableAdapter;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnUserManagement;
    }
}