namespace FileMovement
{
    partial class Department_Portal
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
            this.lblDept = new System.Windows.Forms.Label();
            this.btnDeptForwardFile = new System.Windows.Forms.Button();
            this.btnDeptUpdateFileStatus = new System.Windows.Forms.Button();
            this.btnDeptFileRegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.Olive;
            this.lblDept.Location = new System.Drawing.Point(360, 39);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(85, 31);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "label1";
            // 
            // btnDeptForwardFile
            // 
            this.btnDeptForwardFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptForwardFile.Location = new System.Drawing.Point(195, 282);
            this.btnDeptForwardFile.Name = "btnDeptForwardFile";
            this.btnDeptForwardFile.Size = new System.Drawing.Size(250, 33);
            this.btnDeptForwardFile.TabIndex = 40;
            this.btnDeptForwardFile.Text = "Forward File";
            this.btnDeptForwardFile.UseVisualStyleBackColor = true;
            // 
            // btnDeptUpdateFileStatus
            // 
            this.btnDeptUpdateFileStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptUpdateFileStatus.Location = new System.Drawing.Point(195, 223);
            this.btnDeptUpdateFileStatus.Name = "btnDeptUpdateFileStatus";
            this.btnDeptUpdateFileStatus.Size = new System.Drawing.Size(250, 33);
            this.btnDeptUpdateFileStatus.TabIndex = 39;
            this.btnDeptUpdateFileStatus.Text = "Update File Status";
            this.btnDeptUpdateFileStatus.UseVisualStyleBackColor = true;
            this.btnDeptUpdateFileStatus.Click += new System.EventHandler(this.btnDeptUpdateFileStatus_Click);
            // 
            // btnDeptFileRegis
            // 
            this.btnDeptFileRegis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptFileRegis.Location = new System.Drawing.Point(195, 163);
            this.btnDeptFileRegis.Name = "btnDeptFileRegis";
            this.btnDeptFileRegis.Size = new System.Drawing.Size(250, 33);
            this.btnDeptFileRegis.TabIndex = 38;
            this.btnDeptFileRegis.Text = "File Registration";
            this.btnDeptFileRegis.UseVisualStyleBackColor = true;
            this.btnDeptFileRegis.Click += new System.EventHandler(this.btnDeptFileRegis_Click);
            // 
            // Department_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.btnDeptForwardFile);
            this.Controls.Add(this.btnDeptUpdateFileStatus);
            this.Controls.Add(this.btnDeptFileRegis);
            this.Controls.Add(this.lblDept);
            this.Name = "Department_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department_Portal";
            this.Load += new System.EventHandler(this.Department_Portal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Button btnDeptForwardFile;
        private System.Windows.Forms.Button btnDeptUpdateFileStatus;
        private System.Windows.Forms.Button btnDeptFileRegis;
    }
}