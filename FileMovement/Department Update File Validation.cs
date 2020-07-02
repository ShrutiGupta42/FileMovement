using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMovement
{
    public partial class Department_Update_File_Validation : Form
    {
        public static string fileNo, sub, department, subDetails, fileBrowsed, date, name, user, dateLastUpdated, actionTakenToFile, fileStatus;

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
                    fileNo = dtUsers.Rows[0]["FILE_NO"].ToString();
                    sub = dtUsers.Rows[0]["SUBJECT"].ToString();
                    department = dtUsers.Rows[0]["DEPT"].ToString();
                    subDetails = dtUsers.Rows[0]["SUB_DETAILS"].ToString();
                    fileBrowsed = dtUsers.Rows[0]["FILE_BROWSED"].ToString();
                    date = dtUsers.Rows[0]["DATE"].ToString();
                    name = dtUsers.Rows[0]["NAME"].ToString();
                    user = dtUsers.Rows[0]["USER"].ToString();
                    dateLastUpdated = dtUsers.Rows[0]["F_LAST_UPDATED"].ToString();
                    actionTakenToFile = dtUsers.Rows[0]["TOT_ACTION"].ToString();
                    fileStatus = dtUsers.Rows[0]["FILE_STATUS"].ToString();

                    MessageBox.Show("File Number is valid!!");
                    objDbAccess.closeConn();
                    this.Hide();
                    Department_User_Update_File_Status dept = new Department_User_Update_File_Status();
                    dept.Show();
                }
                else
                {
                    MessageBox.Show("File number is Incorrect.. Please Recheck once and try again!!");
                }
            }
        }
    }
}
