namespace FileMovement
{
    partial class Student_File_Status_Validation
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
            this.btnStudentCheck = new System.Windows.Forms.Button();
            this.txtStudentFileNumber = new System.Windows.Forms.TextBox();
            this.lblStudentFileNumberValidate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentCheck
            // 
            this.btnStudentCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCheck.Location = new System.Drawing.Point(289, 124);
            this.btnStudentCheck.Name = "btnStudentCheck";
            this.btnStudentCheck.Size = new System.Drawing.Size(75, 23);
            this.btnStudentCheck.TabIndex = 5;
            this.btnStudentCheck.Text = "Check";
            this.btnStudentCheck.UseVisualStyleBackColor = true;
            this.btnStudentCheck.Click += new System.EventHandler(this.btnStudentCheck_Click);
            // 
            // txtStudentFileNumber
            // 
            this.txtStudentFileNumber.Location = new System.Drawing.Point(107, 127);
            this.txtStudentFileNumber.Name = "txtStudentFileNumber";
            this.txtStudentFileNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentFileNumber.TabIndex = 4;
            // 
            // lblStudentFileNumberValidate
            // 
            this.lblStudentFileNumberValidate.AutoSize = true;
            this.lblStudentFileNumberValidate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFileNumberValidate.Location = new System.Drawing.Point(41, 72);
            this.lblStudentFileNumberValidate.Name = "lblStudentFileNumberValidate";
            this.lblStudentFileNumberValidate.Size = new System.Drawing.Size(414, 19);
            this.lblStudentFileNumberValidate.TabIndex = 3;
            this.lblStudentFileNumberValidate.Text = "Please enter the file number that you want to see the Status!!";
            // 
            // Student_File_Status_Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 218);
            this.Controls.Add(this.btnStudentCheck);
            this.Controls.Add(this.txtStudentFileNumber);
            this.Controls.Add(this.lblStudentFileNumberValidate);
            this.Name = "Student_File_Status_Validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_File_Status_Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentCheck;
        private System.Windows.Forms.TextBox txtStudentFileNumber;
        private System.Windows.Forms.Label lblStudentFileNumberValidate;
    }
}