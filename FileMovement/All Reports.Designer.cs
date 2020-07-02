namespace FileMovement
{
    partial class All_Reports
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
            this.dgvAllReports = new System.Windows.Forms.DataGridView();
            this.btnAdminPortal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllReports
            // 
            this.dgvAllReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReports.Location = new System.Drawing.Point(12, 23);
            this.dgvAllReports.Name = "dgvAllReports";
            this.dgvAllReports.Size = new System.Drawing.Size(776, 326);
            this.dgvAllReports.TabIndex = 2;
            // 
            // btnAdminPortal
            // 
            this.btnAdminPortal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPortal.Location = new System.Drawing.Point(523, 384);
            this.btnAdminPortal.Name = "btnAdminPortal";
            this.btnAdminPortal.Size = new System.Drawing.Size(232, 42);
            this.btnAdminPortal.TabIndex = 3;
            this.btnAdminPortal.Text = "Administrator Portal";
            this.btnAdminPortal.UseVisualStyleBackColor = true;
            this.btnAdminPortal.Click += new System.EventHandler(this.btnAdminPortal_Click);
            // 
            // All_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminPortal);
            this.Controls.Add(this.dgvAllReports);
            this.Name = "All_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Reports";
            this.Load += new System.EventHandler(this.All_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReports;
        private System.Windows.Forms.Button btnAdminPortal;
    }
}