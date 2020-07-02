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
    public partial class Student_File_Status_Validation : Form
    {
        public static string fN, subj, depart, subjDetails, fileBrow, datee, namee, userr, dateLastUpdate, actionTakenToFilee, fileStatuss;

        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Student_File_Status_Validation()
        {
            InitializeComponent();
        }

        private void btnStudentCheck_Click(object sender, EventArgs e)
        {
            string fileNumber = txtStudentFileNumber.Text;

            if(fileNumber.Equals(""))
            {
                MessageBox.Show("Please enter your File Number!!");
            }
            else
            {
                string query = "Select * from fileRegistration Where FILE_NO = '" + fileNumber + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    fN = dtUsers.Rows[0]["FILE_NO"].ToString();
                    subj = dtUsers.Rows[0]["SUBJECT"].ToString();
                    depart = dtUsers.Rows[0]["DEPT"].ToString();
                    subjDetails = dtUsers.Rows[0]["SUB_DETAILS"].ToString();
                    fileBrow = dtUsers.Rows[0]["FILE_BROWSED"].ToString();
                    datee = dtUsers.Rows[0]["DATE"].ToString();
                    namee = dtUsers.Rows[0]["NAME"].ToString();
                    userr = dtUsers.Rows[0]["USER"].ToString();
                    dateLastUpdate = dtUsers.Rows[0]["F_LAST_UPDATED"].ToString();
                    actionTakenToFilee = dtUsers.Rows[0]["TOT_ACTION"].ToString();
                    fileStatuss = dtUsers.Rows[0]["FILE_STATUS"].ToString();

                    MessageBox.Show("File Number is valid!!");
                    objDbAccess.closeConn();

                    this.Hide();
                    File_Status status = new File_Status();
                    status.Show();
                }
                else
                {
                    MessageBox.Show("File number is Incorrect.. Please Recheck once and try again!!");
                }
            }
        }
    }
}
