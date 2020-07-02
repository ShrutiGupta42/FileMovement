namespace FileMovement
{
    partial class Remove_File
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
            this.btnAdminRemoveFile = new System.Windows.Forms.Button();
            this.txtAdminRemoveFile = new System.Windows.Forms.TextBox();
            this.lblAdminRemoveFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminRemoveFile
            // 
            this.btnAdminRemoveFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRemoveFile.Location = new System.Drawing.Point(288, 124);
            this.btnAdminRemoveFile.Name = "btnAdminRemoveFile";
            this.btnAdminRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btnAdminRemoveFile.TabIndex = 8;
            this.btnAdminRemoveFile.Text = "Remove";
            this.btnAdminRemoveFile.UseVisualStyleBackColor = true;
            this.btnAdminRemoveFile.Click += new System.EventHandler(this.btnAdminRemoveFile_Click);
            // 
            // txtAdminRemoveFile
            // 
            this.txtAdminRemoveFile.Location = new System.Drawing.Point(106, 127);
            this.txtAdminRemoveFile.Name = "txtAdminRemoveFile";
            this.txtAdminRemoveFile.Size = new System.Drawing.Size(100, 20);
            this.txtAdminRemoveFile.TabIndex = 7;
            // 
            // lblAdminRemoveFile
            // 
            this.lblAdminRemoveFile.AutoSize = true;
            this.lblAdminRemoveFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRemoveFile.Location = new System.Drawing.Point(64, 72);
            this.lblAdminRemoveFile.Name = "lblAdminRemoveFile";
            this.lblAdminRemoveFile.Size = new System.Drawing.Size(376, 19);
            this.lblAdminRemoveFile.TabIndex = 6;
            this.lblAdminRemoveFile.Text = "Please enter the file number that you want to Remove!!";
            // 
            // Remove_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 218);
            this.Controls.Add(this.btnAdminRemoveFile);
            this.Controls.Add(this.txtAdminRemoveFile);
            this.Controls.Add(this.lblAdminRemoveFile);
            this.Name = "Remove_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminRemoveFile;
        private System.Windows.Forms.TextBox txtAdminRemoveFile;
        private System.Windows.Forms.Label lblAdminRemoveFile;
    }
}