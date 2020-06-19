namespace FileMovement
{
    partial class Student_Portal
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
            this.signUpDataSet1 = new FileMovement.signUpDataSet1();
            this.userSignUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSignUpTableAdapter = new FileMovement.signUpDataSet1TableAdapters.UserSignUpTableAdapter();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnStudentViewFileStatus = new System.Windows.Forms.Button();
            this.btnStudentFileRegis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSignUpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpDataSet1
            // 
            this.signUpDataSet1.DataSetName = "signUpDataSet1";
            this.signUpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSignUpBindingSource
            // 
            this.userSignUpBindingSource.DataMember = "UserSignUp";
            this.userSignUpBindingSource.DataSource = this.signUpDataSet1;
            // 
            // userSignUpTableAdapter
            // 
            this.userSignUpTableAdapter.ClearBeforeFill = true;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.Olive;
            this.lblStudent.Location = new System.Drawing.Point(365, 26);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(85, 31);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "label1";
            // 
            // btnStudentViewFileStatus
            // 
            this.btnStudentViewFileStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentViewFileStatus.Location = new System.Drawing.Point(200, 237);
            this.btnStudentViewFileStatus.Name = "btnStudentViewFileStatus";
            this.btnStudentViewFileStatus.Size = new System.Drawing.Size(250, 33);
            this.btnStudentViewFileStatus.TabIndex = 43;
            this.btnStudentViewFileStatus.Text = "View File Status";
            this.btnStudentViewFileStatus.UseVisualStyleBackColor = true;
            // 
            // btnStudentFileRegis
            // 
            this.btnStudentFileRegis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFileRegis.Location = new System.Drawing.Point(200, 178);
            this.btnStudentFileRegis.Name = "btnStudentFileRegis";
            this.btnStudentFileRegis.Size = new System.Drawing.Size(250, 33);
            this.btnStudentFileRegis.TabIndex = 42;
            this.btnStudentFileRegis.Text = "File Registration";
            this.btnStudentFileRegis.UseVisualStyleBackColor = true;
            // 
            // Student_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.btnStudentViewFileStatus);
            this.Controls.Add(this.btnStudentFileRegis);
            this.Controls.Add(this.lblStudent);
            this.Name = "Student_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Portal";
            this.Load += new System.EventHandler(this.Student_Portal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSignUpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private signUpDataSet1 signUpDataSet1;
        private System.Windows.Forms.BindingSource userSignUpBindingSource;
        private signUpDataSet1TableAdapters.UserSignUpTableAdapter userSignUpTableAdapter;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnStudentViewFileStatus;
        private System.Windows.Forms.Button btnStudentFileRegis;
    }
}