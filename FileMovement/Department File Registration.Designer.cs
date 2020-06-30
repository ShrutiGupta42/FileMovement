namespace FileMovement
{
    partial class Department_File_Registration
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
            this.btnDeptFileRegister = new System.Windows.Forms.Button();
            this.lblDeptTypeOfUser = new System.Windows.Forms.Label();
            this.txtDeptFileBrowsed = new System.Windows.Forms.TextBox();
            this.lblDeptFileBrowsed = new System.Windows.Forms.Label();
            this.txtDeptFileUser = new System.Windows.Forms.TextBox();
            this.lblDeptFileUser = new System.Windows.Forms.Label();
            this.txtDeptFileName = new System.Windows.Forms.TextBox();
            this.lblDeptFileName = new System.Windows.Forms.Label();
            this.lblDeptFileDate = new System.Windows.Forms.Label();
            this.txtDeptFileDept = new System.Windows.Forms.TextBox();
            this.txtDeptFileSubjectDetails = new System.Windows.Forms.TextBox();
            this.lblDeptFileSubjectDetails = new System.Windows.Forms.Label();
            this.dateDeptFile = new System.Windows.Forms.DateTimePicker();
            this.lblDeptFileDept = new System.Windows.Forms.Label();
            this.txtDeptFileSubject = new System.Windows.Forms.TextBox();
            this.lblDeptFileSubject = new System.Windows.Forms.Label();
            this.txtDeptFileNumber = new System.Windows.Forms.TextBox();
            this.lblDeptFileRegistration = new System.Windows.Forms.Label();
            this.lblDeptFileNumber = new System.Windows.Forms.Label();
            this.btnDeptFileNoGenerator = new System.Windows.Forms.Button();
            this.btndeptFileBrowsed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeptFileRegister
            // 
            this.btnDeptFileRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptFileRegister.Location = new System.Drawing.Point(647, 589);
            this.btnDeptFileRegister.Name = "btnDeptFileRegister";
            this.btnDeptFileRegister.Size = new System.Drawing.Size(95, 32);
            this.btnDeptFileRegister.TabIndex = 82;
            this.btnDeptFileRegister.Text = "Register";
            this.btnDeptFileRegister.UseVisualStyleBackColor = true;
            this.btnDeptFileRegister.Click += new System.EventHandler(this.btnDeptFileRegister_Click);
            // 
            // lblDeptTypeOfUser
            // 
            this.lblDeptTypeOfUser.AutoSize = true;
            this.lblDeptTypeOfUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptTypeOfUser.Location = new System.Drawing.Point(542, 546);
            this.lblDeptTypeOfUser.Name = "lblDeptTypeOfUser";
            this.lblDeptTypeOfUser.Size = new System.Drawing.Size(85, 15);
            this.lblDeptTypeOfUser.TabIndex = 81;
            this.lblDeptTypeOfUser.Text = "// Type of User";
            // 
            // txtDeptFileBrowsed
            // 
            this.txtDeptFileBrowsed.Location = new System.Drawing.Point(254, 364);
            this.txtDeptFileBrowsed.Multiline = true;
            this.txtDeptFileBrowsed.Name = "txtDeptFileBrowsed";
            this.txtDeptFileBrowsed.Size = new System.Drawing.Size(388, 20);
            this.txtDeptFileBrowsed.TabIndex = 80;
            // 
            // lblDeptFileBrowsed
            // 
            this.lblDeptFileBrowsed.AutoSize = true;
            this.lblDeptFileBrowsed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileBrowsed.Location = new System.Drawing.Point(34, 365);
            this.lblDeptFileBrowsed.Name = "lblDeptFileBrowsed";
            this.lblDeptFileBrowsed.Size = new System.Drawing.Size(128, 22);
            this.lblDeptFileBrowsed.TabIndex = 79;
            this.lblDeptFileBrowsed.Text = "File Browsed :";
            // 
            // txtDeptFileUser
            // 
            this.txtDeptFileUser.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Department User"});
            this.txtDeptFileUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDeptFileUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDeptFileUser.Location = new System.Drawing.Point(254, 543);
            this.txtDeptFileUser.Name = "txtDeptFileUser";
            this.txtDeptFileUser.Size = new System.Drawing.Size(209, 20);
            this.txtDeptFileUser.TabIndex = 78;
            // 
            // lblDeptFileUser
            // 
            this.lblDeptFileUser.AutoSize = true;
            this.lblDeptFileUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileUser.Location = new System.Drawing.Point(33, 543);
            this.lblDeptFileUser.Name = "lblDeptFileUser";
            this.lblDeptFileUser.Size = new System.Drawing.Size(58, 22);
            this.lblDeptFileUser.TabIndex = 77;
            this.lblDeptFileUser.Text = "User :";
            // 
            // txtDeptFileName
            // 
            this.txtDeptFileName.Location = new System.Drawing.Point(254, 495);
            this.txtDeptFileName.Name = "txtDeptFileName";
            this.txtDeptFileName.Size = new System.Drawing.Size(209, 20);
            this.txtDeptFileName.TabIndex = 76;
            // 
            // lblDeptFileName
            // 
            this.lblDeptFileName.AutoSize = true;
            this.lblDeptFileName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileName.Location = new System.Drawing.Point(33, 495);
            this.lblDeptFileName.Name = "lblDeptFileName";
            this.lblDeptFileName.Size = new System.Drawing.Size(68, 22);
            this.lblDeptFileName.TabIndex = 75;
            this.lblDeptFileName.Text = "Name :";
            // 
            // lblDeptFileDate
            // 
            this.lblDeptFileDate.AutoSize = true;
            this.lblDeptFileDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileDate.Location = new System.Drawing.Point(33, 440);
            this.lblDeptFileDate.Name = "lblDeptFileDate";
            this.lblDeptFileDate.Size = new System.Drawing.Size(59, 22);
            this.lblDeptFileDate.TabIndex = 74;
            this.lblDeptFileDate.Text = "Date :";
            // 
            // txtDeptFileDept
            // 
            this.txtDeptFileDept.AutoCompleteCustomSource.AddRange(new string[] {
            "Library Department",
            "Computer Laboratory Department"});
            this.txtDeptFileDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDeptFileDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDeptFileDept.Location = new System.Drawing.Point(254, 230);
            this.txtDeptFileDept.Name = "txtDeptFileDept";
            this.txtDeptFileDept.Size = new System.Drawing.Size(209, 20);
            this.txtDeptFileDept.TabIndex = 73;
            // 
            // txtDeptFileSubjectDetails
            // 
            this.txtDeptFileSubjectDetails.Location = new System.Drawing.Point(254, 283);
            this.txtDeptFileSubjectDetails.Multiline = true;
            this.txtDeptFileSubjectDetails.Name = "txtDeptFileSubjectDetails";
            this.txtDeptFileSubjectDetails.Size = new System.Drawing.Size(507, 47);
            this.txtDeptFileSubjectDetails.TabIndex = 72;
            // 
            // lblDeptFileSubjectDetails
            // 
            this.lblDeptFileSubjectDetails.AutoSize = true;
            this.lblDeptFileSubjectDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileSubjectDetails.Location = new System.Drawing.Point(33, 283);
            this.lblDeptFileSubjectDetails.Name = "lblDeptFileSubjectDetails";
            this.lblDeptFileSubjectDetails.Size = new System.Drawing.Size(143, 22);
            this.lblDeptFileSubjectDetails.TabIndex = 71;
            this.lblDeptFileSubjectDetails.Text = "Subject Details :";
            // 
            // dateDeptFile
            // 
            this.dateDeptFile.Location = new System.Drawing.Point(254, 440);
            this.dateDeptFile.Name = "dateDeptFile";
            this.dateDeptFile.Size = new System.Drawing.Size(200, 20);
            this.dateDeptFile.TabIndex = 70;
            // 
            // lblDeptFileDept
            // 
            this.lblDeptFileDept.AutoSize = true;
            this.lblDeptFileDept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileDept.Location = new System.Drawing.Point(33, 230);
            this.lblDeptFileDept.Name = "lblDeptFileDept";
            this.lblDeptFileDept.Size = new System.Drawing.Size(117, 22);
            this.lblDeptFileDept.TabIndex = 69;
            this.lblDeptFileDept.Text = "Department :";
            // 
            // txtDeptFileSubject
            // 
            this.txtDeptFileSubject.Location = new System.Drawing.Point(254, 151);
            this.txtDeptFileSubject.Multiline = true;
            this.txtDeptFileSubject.Name = "txtDeptFileSubject";
            this.txtDeptFileSubject.Size = new System.Drawing.Size(507, 47);
            this.txtDeptFileSubject.TabIndex = 68;
            // 
            // lblDeptFileSubject
            // 
            this.lblDeptFileSubject.AutoSize = true;
            this.lblDeptFileSubject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileSubject.Location = new System.Drawing.Point(33, 151);
            this.lblDeptFileSubject.Name = "lblDeptFileSubject";
            this.lblDeptFileSubject.Size = new System.Drawing.Size(81, 22);
            this.lblDeptFileSubject.TabIndex = 67;
            this.lblDeptFileSubject.Text = "Subject :";
            // 
            // txtDeptFileNumber
            // 
            this.txtDeptFileNumber.Location = new System.Drawing.Point(254, 95);
            this.txtDeptFileNumber.Name = "txtDeptFileNumber";
            this.txtDeptFileNumber.Size = new System.Drawing.Size(102, 20);
            this.txtDeptFileNumber.TabIndex = 66;
            // 
            // lblDeptFileRegistration
            // 
            this.lblDeptFileRegistration.AutoSize = true;
            this.lblDeptFileRegistration.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileRegistration.Location = new System.Drawing.Point(265, 32);
            this.lblDeptFileRegistration.Name = "lblDeptFileRegistration";
            this.lblDeptFileRegistration.Size = new System.Drawing.Size(270, 24);
            this.lblDeptFileRegistration.TabIndex = 65;
            this.lblDeptFileRegistration.Text = "Department File Registration";
            // 
            // lblDeptFileNumber
            // 
            this.lblDeptFileNumber.AutoSize = true;
            this.lblDeptFileNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptFileNumber.Location = new System.Drawing.Point(33, 95);
            this.lblDeptFileNumber.Name = "lblDeptFileNumber";
            this.lblDeptFileNumber.Size = new System.Drawing.Size(122, 22);
            this.lblDeptFileNumber.TabIndex = 64;
            this.lblDeptFileNumber.Text = "File Number :";
            // 
            // btnDeptFileNoGenerator
            // 
            this.btnDeptFileNoGenerator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptFileNoGenerator.Location = new System.Drawing.Point(498, 90);
            this.btnDeptFileNoGenerator.Name = "btnDeptFileNoGenerator";
            this.btnDeptFileNoGenerator.Size = new System.Drawing.Size(224, 33);
            this.btnDeptFileNoGenerator.TabIndex = 83;
            this.btnDeptFileNoGenerator.Text = "Generate File Number";
            this.btnDeptFileNoGenerator.UseVisualStyleBackColor = true;
            this.btnDeptFileNoGenerator.Click += new System.EventHandler(this.btnDeptFileNoGenerator_Click);
            // 
            // btndeptFileBrowsed
            // 
            this.btndeptFileBrowsed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptFileBrowsed.Location = new System.Drawing.Point(686, 354);
            this.btndeptFileBrowsed.Name = "btndeptFileBrowsed";
            this.btndeptFileBrowsed.Size = new System.Drawing.Size(75, 36);
            this.btndeptFileBrowsed.TabIndex = 84;
            this.btndeptFileBrowsed.Text = "Open";
            this.btndeptFileBrowsed.UseVisualStyleBackColor = true;
            this.btndeptFileBrowsed.Click += new System.EventHandler(this.btndeptFileBrowsed_Click);
            // 
            // Department_File_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.btndeptFileBrowsed);
            this.Controls.Add(this.btnDeptFileNoGenerator);
            this.Controls.Add(this.btnDeptFileRegister);
            this.Controls.Add(this.lblDeptTypeOfUser);
            this.Controls.Add(this.txtDeptFileBrowsed);
            this.Controls.Add(this.lblDeptFileBrowsed);
            this.Controls.Add(this.txtDeptFileUser);
            this.Controls.Add(this.lblDeptFileUser);
            this.Controls.Add(this.txtDeptFileName);
            this.Controls.Add(this.lblDeptFileName);
            this.Controls.Add(this.lblDeptFileDate);
            this.Controls.Add(this.txtDeptFileDept);
            this.Controls.Add(this.txtDeptFileSubjectDetails);
            this.Controls.Add(this.lblDeptFileSubjectDetails);
            this.Controls.Add(this.dateDeptFile);
            this.Controls.Add(this.lblDeptFileDept);
            this.Controls.Add(this.txtDeptFileSubject);
            this.Controls.Add(this.lblDeptFileSubject);
            this.Controls.Add(this.txtDeptFileNumber);
            this.Controls.Add(this.lblDeptFileRegistration);
            this.Controls.Add(this.lblDeptFileNumber);
            this.Name = "Department_File_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department_File_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeptFileRegister;
        private System.Windows.Forms.Label lblDeptTypeOfUser;
        private System.Windows.Forms.TextBox txtDeptFileBrowsed;
        private System.Windows.Forms.Label lblDeptFileBrowsed;
        private System.Windows.Forms.TextBox txtDeptFileUser;
        private System.Windows.Forms.Label lblDeptFileUser;
        private System.Windows.Forms.TextBox txtDeptFileName;
        private System.Windows.Forms.Label lblDeptFileName;
        private System.Windows.Forms.Label lblDeptFileDate;
        private System.Windows.Forms.TextBox txtDeptFileDept;
        private System.Windows.Forms.TextBox txtDeptFileSubjectDetails;
        private System.Windows.Forms.Label lblDeptFileSubjectDetails;
        private System.Windows.Forms.DateTimePicker dateDeptFile;
        private System.Windows.Forms.Label lblDeptFileDept;
        private System.Windows.Forms.TextBox txtDeptFileSubject;
        private System.Windows.Forms.Label lblDeptFileSubject;
        private System.Windows.Forms.TextBox txtDeptFileNumber;
        private System.Windows.Forms.Label lblDeptFileRegistration;
        private System.Windows.Forms.Label lblDeptFileNumber;
        private System.Windows.Forms.Button btnDeptFileNoGenerator;
        private System.Windows.Forms.Button btndeptFileBrowsed;
    }
}