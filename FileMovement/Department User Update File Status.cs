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
    public partial class Department_User_Update_File_Status : Form
    {
        DBAccess objDbAccess = new DBAccess();
        public Department_User_Update_File_Status()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnUpdateFileBrowsed_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtUpdateFileBrowsed.Text = ofd.FileName;
            }
        }

        private void Department_User_Update_File_Status_Load(object sender, EventArgs e)
        {
            txtUpdateFileNumber.Text = Department_Update_File_Validation.fileNo;
            txtUpdateFileSubject.Text = Department_Update_File_Validation.sub;
            txtUpdateFileDept.Text = Department_Update_File_Validation.department;
            txtUpdateFileSubjectDetails.Text = Department_Update_File_Validation.subDetails;
            txtUpdateFileBrowsed.Text = Department_Update_File_Validation.fileBrowsed;
            dateUpdateFile.Text = Department_Update_File_Validation.date;
            txtUpdateFileName.Text = Department_Update_File_Validation.name;
            txtUpdateFileUser.Text = Department_Update_File_Validation.user;
            dateUpdateFileLastUpdated.Text = Department_Update_File_Validation.dateLastUpdated;
            txtUpdateFileAction.Text = Department_Update_File_Validation.actionTakenToFile;
            txtUpdateFileStatus.Text = Department_Update_File_Validation.fileStatus;
        }

        private void btnUpdateFileRegister_Click(object sender, EventArgs e)
        {
            string fileNumber = txtUpdateFileNumber.Text;
            string newSubject = txtUpdateFileSubject.Text;
            string newSubDetails = txtUpdateFileSubjectDetails.Text;
            string newFileBrowsed = txtUpdateFileBrowsed.Text;
            string newDateLastUpdated = dateUpdateFileLastUpdated.Text;
            string newActionTakenToFile = txtUpdateFileAction.Text;
            string newFilesstatus = txtUpdateFileStatus.Text;

            if(newSubject.Equals(""))
            {
                MessageBox.Show("Please enter the Subject!!");
            }
            else if(newSubDetails.Equals(""))
            {
                MessageBox.Show("Please enter the Subject Details!!");
            }
            else if(newFileBrowsed.Equals(""))
            {
                MessageBox.Show("Please choose your File!!");
            }
            else if(newActionTakenToFile.Equals(""))
            {
                MessageBox.Show("Please enter the number of actions taken to file!!");
            }
            else if(newFilesstatus.Equals(""))
            {
                MessageBox.Show("Please enter the status of the File!!");
            }
            else
            {
                string query = "Update fileRegistration SET SUBJECT = '" + @newSubject + "',SUB_DETAILS = '" + @newSubDetails + "',FILE_BROWSED = '" + @newFileBrowsed + "',F_LAST_UPDATED = '" + @newDateLastUpdated + "',TOT_ACTION = '" + @newActionTakenToFile + "',FILE_STATUS = '" + @newFilesstatus + "' where FILE_NO = '" + fileNumber + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newSubject", @newSubject);
                updateCommand.Parameters.AddWithValue("@newSubDetails", @newSubDetails);
                updateCommand.Parameters.AddWithValue("@newFileBrowsed", @newFileBrowsed);
                updateCommand.Parameters.AddWithValue("@newDateLastUpdated", @newDateLastUpdated);
                updateCommand.Parameters.AddWithValue("@newActionTakenToFile", @newActionTakenToFile);
                updateCommand.Parameters.AddWithValue("@newFilesstatus", newFilesstatus);

                int row = objDbAccess.executeQuery(updateCommand);

                if(row == 1)
                {
                    MessageBox.Show("File is Successfully Updated!!");

                    this.Hide();
                    Department_Portal dept = new Department_Portal();
                    dept.Show();
                }
                else
                {
                    MessageBox.Show("Error occured while updating the File!.. Please try again!!");
                }

            }
        }

        private void btnDeptPortalUpdateFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department_Portal portal = new Department_Portal();
            portal.Show();
        }
    }
}
