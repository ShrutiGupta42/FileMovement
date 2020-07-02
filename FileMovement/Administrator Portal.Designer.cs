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
            this.btnAdminViewReport = new System.Windows.Forms.Button();
            this.btnAdminCloseFile = new System.Windows.Forms.Button();
            this.btnAdminManageUserInfo = new System.Windows.Forms.Button();
            this.btnAdminLogout = new System.Windows.Forms.Button();
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
            this.lblAdmin.Location = new System.Drawing.Point(364, 28);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(85, 31);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "label1";
            // 
            // btnAdminViewReport
            // 
            this.btnAdminViewReport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminViewReport.Location = new System.Drawing.Point(199, 212);
            this.btnAdminViewReport.Name = "btnAdminViewReport";
            this.btnAdminViewReport.Size = new System.Drawing.Size(250, 33);
            this.btnAdminViewReport.TabIndex = 43;
            this.btnAdminViewReport.Text = "View Report";
            this.btnAdminViewReport.UseVisualStyleBackColor = true;
            this.btnAdminViewReport.Click += new System.EventHandler(this.btnAdminViewReport_Click);
            // 
            // btnAdminCloseFile
            // 
            this.btnAdminCloseFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCloseFile.Location = new System.Drawing.Point(199, 144);
            this.btnAdminCloseFile.Name = "btnAdminCloseFile";
            this.btnAdminCloseFile.Size = new System.Drawing.Size(250, 33);
            this.btnAdminCloseFile.TabIndex = 42;
            this.btnAdminCloseFile.Text = "Close File";
            this.btnAdminCloseFile.UseVisualStyleBackColor = true;
            this.btnAdminCloseFile.Click += new System.EventHandler(this.btnAdminCloseFile_Click);
            // 
            // btnAdminManageUserInfo
            // 
            this.btnAdminManageUserInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageUserInfo.Location = new System.Drawing.Point(199, 279);
            this.btnAdminManageUserInfo.Name = "btnAdminManageUserInfo";
            this.btnAdminManageUserInfo.Size = new System.Drawing.Size(250, 33);
            this.btnAdminManageUserInfo.TabIndex = 44;
            this.btnAdminManageUserInfo.Text = "Managing User Information";
            this.btnAdminManageUserInfo.UseVisualStyleBackColor = true;
            this.btnAdminManageUserInfo.Click += new System.EventHandler(this.btnAdminManageUserInfo_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(493, 327);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(119, 33);
            this.btnAdminLogout.TabIndex = 45;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // Administrator_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.btnAdminManageUserInfo);
            this.Controls.Add(this.btnAdminViewReport);
            this.Controls.Add(this.btnAdminCloseFile);
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
        private System.Windows.Forms.Button btnAdminViewReport;
        private System.Windows.Forms.Button btnAdminCloseFile;
        private System.Windows.Forms.Button btnAdminManageUserInfo;
        private System.Windows.Forms.Button btnAdminLogout;
    }
}