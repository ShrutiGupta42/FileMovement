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
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.Olive;
            this.lblDept.Location = new System.Drawing.Point(213, 36);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(85, 31);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "label1";
            // 
            // Department_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 304);
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
    }
}