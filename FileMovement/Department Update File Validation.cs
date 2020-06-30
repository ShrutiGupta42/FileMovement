using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMovement
{
    public partial class Department_Update_File_Validation : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Department_Update_File_Validation()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string fileNumber = txtFileNumber.Text;

            if(fileNumber.Equals(""))
            {
                MessageBox.Show("Please enter file Number!!");
            }
            else
            {
                string query = "Select * from fileRegistration Where FILE_NO= '" + fileNumber + "'";
                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("File Number is valid!!");
                    this.Hide();
                    Department_User_Update_File_Status dept = new Department_User_Update_File_Status();
                    dept.Show();
                }
            }
        }
    }
}
