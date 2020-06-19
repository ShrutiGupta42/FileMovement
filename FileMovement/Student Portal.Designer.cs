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
            this.lblStudent.Location = new System.Drawing.Point(204, 42);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(85, 31);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "label1";
            // 
            // Student_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 304);
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
    }
}