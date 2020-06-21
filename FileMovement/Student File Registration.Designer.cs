namespace FileMovement
{
    partial class Student_File_Registration
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
            this.btnStudentFileNoGenerator = new System.Windows.Forms.Button();
            this.lblStudentFileNumber = new System.Windows.Forms.Label();
            this.lblStudentFileRegistration = new System.Windows.Forms.Label();
            this.txtStudentFileNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnStudentFileNoGenerator
            // 
            this.btnStudentFileNoGenerator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFileNoGenerator.Location = new System.Drawing.Point(383, 97);
            this.btnStudentFileNoGenerator.Name = "btnStudentFileNoGenerator";
            this.btnStudentFileNoGenerator.Size = new System.Drawing.Size(224, 33);
            this.btnStudentFileNoGenerator.TabIndex = 43;
            this.btnStudentFileNoGenerator.Text = "Generate File Number";
            this.btnStudentFileNoGenerator.UseVisualStyleBackColor = true;
            this.btnStudentFileNoGenerator.Click += new System.EventHandler(this.btnStudentFileNoGenerator_Click);
            // 
            // lblStudentFileNumber
            // 
            this.lblStudentFileNumber.AutoSize = true;
            this.lblStudentFileNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFileNumber.Location = new System.Drawing.Point(33, 102);
            this.lblStudentFileNumber.Name = "lblStudentFileNumber";
            this.lblStudentFileNumber.Size = new System.Drawing.Size(122, 22);
            this.lblStudentFileNumber.TabIndex = 44;
            this.lblStudentFileNumber.Text = "File Number :";
            this.lblStudentFileNumber.Click += new System.EventHandler(this.lblStudentFileNumber_Click);
            // 
            // lblStudentFileRegistration
            // 
            this.lblStudentFileRegistration.AutoSize = true;
            this.lblStudentFileRegistration.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFileRegistration.Location = new System.Drawing.Point(192, 31);
            this.lblStudentFileRegistration.Name = "lblStudentFileRegistration";
            this.lblStudentFileRegistration.Size = new System.Drawing.Size(232, 24);
            this.lblStudentFileRegistration.TabIndex = 45;
            this.lblStudentFileRegistration.Text = "Student File Registration";
            // 
            // txtStudentFileNumber
            // 
            this.txtStudentFileNumber.Location = new System.Drawing.Point(215, 102);
            this.txtStudentFileNumber.Name = "txtStudentFileNumber";
            this.txtStudentFileNumber.Size = new System.Drawing.Size(102, 20);
            this.txtStudentFileNumber.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Subject :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Subject :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // Student_File_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentFileNumber);
            this.Controls.Add(this.lblStudentFileRegistration);
            this.Controls.Add(this.lblStudentFileNumber);
            this.Controls.Add(this.btnStudentFileNoGenerator);
            this.Name = "Student_File_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_File_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentFileNoGenerator;
        private System.Windows.Forms.Label lblStudentFileNumber;
        private System.Windows.Forms.Label lblStudentFileRegistration;
        private System.Windows.Forms.TextBox txtStudentFileNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}