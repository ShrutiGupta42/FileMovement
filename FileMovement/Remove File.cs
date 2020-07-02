using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseProject;

namespace FileMovement
{
    public partial class Remove_File : Form
    {
        DBAccess objDbAccess = new DBAccess();
        public Remove_File()
        {
            InitializeComponent();
        }

        private void btnAdminRemoveFile_Click(object sender, EventArgs e)
        {
            string fileNumber = txtAdminRemoveFile.Text; 

            DialogResult dialog = MessageBox.Show("Are you sure you want to Close this file?", "Remove File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(dialog == DialogResult.Yes)
            {
                string query = "DELETE from fileRegistration Where FILE_NO = '" + fileNumber + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDbAccess.executeQuery(deleteCommand);

                if(row == 1)
                {
                    MessageBox.Show("The File is Closed successfully!!");

                    this.Hide();
                    Administrator_Portal portal = new Administrator_Portal();
                    portal.Show();
                }
                else
                {
                    MessageBox.Show("Error Occured while removing the file.. Please try again!!");
                }

            }
        }
    }
}
