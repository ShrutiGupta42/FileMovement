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
    public partial class Student_File_Registration : Form
    {
        DBAccess objDbAccess = new DBAccess();
        public Student_File_Registration()
        {
            InitializeComponent();
        }

        private void btnStudentFileNoGenerator_Click(object sender, EventArgs e)
        {
            char[] letters = "1234567890".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for(int i = 0; i < 4; i++)
            {
                randomString += letters[r.Next(0, 9)].ToString();
            }
            MessageBox.Show(randomString);  
        }

        private void lblStudentFileNumber_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Student_File_Registration_Load(object sender, EventArgs e)
        {

        }

        private void lblStudentFileRegistration_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentFileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileNumber = txtStudentFileNumber.Text;
            string subject = txtStudentFileSubject.Text;
            string department = txtStudentFileDept.Text;
            string subjectDetails = txtStudentFileSubjectDetails.Text;
            string fileBrowsed = txtStudentFileBrowsed.Text;
            string date = dateStudentFile.Text;
            string name = txtStudentFileName.Text;
            string user = txtStudentFileUser.Text;
            string dateLastUpdated = dateStudentFileLastUpdated.Text;
            string actionTakenToFile = txtStudentFileAction.Text;
            string fileStatus = txtStudentFileStatus.Text;

            if(fileNumber.Equals(""))
            {
                MessageBox.Show("Please enter your File Number!!");
            }
            else if (subject.Equals(""))
            {
                MessageBox.Show("Please enter your Subject!!");
            }
            else if (department.Equals(""))
            {
                MessageBox.Show("Please enter your Department!!");
            }
            else if (subjectDetails.Equals(""))
            {
                MessageBox.Show("Please enter subject details of file!!");
            }
            else if (date.Equals(""))
            {
                MessageBox.Show("Please enter Date!!");
            }
            else if (name.Equals(""))
            {
                MessageBox.Show("Please enter your Name!!");
            }
            else if (user.Equals(""))
            {
                MessageBox.Show("Please enter type of User!!");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into fileRegistration(FILE_NO,SUBJECT,DEPT,SUB_DETAILS,FILE_BROWSED,DATE,NAME,[USER],F_LAST_UPDATED,TOT_ACTION,FILE_STATUS) values(@fileNumber, @subject, @department, @subjectDetails, @fileBrowsed, @date, @name, @user, @dateLastUpdated, @actionTakenToFile, @fileStatus)");

                insertCommand.Parameters.AddWithValue("@fileNumber", fileNumber);
                insertCommand.Parameters.AddWithValue("@subject", subject);
                insertCommand.Parameters.AddWithValue("@department", department);
                insertCommand.Parameters.AddWithValue("@subjectDetails", subjectDetails);
                insertCommand.Parameters.AddWithValue("@fileBrowsed", fileBrowsed);
                insertCommand.Parameters.AddWithValue("@date", date);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@user", user);
                insertCommand.Parameters.AddWithValue("@dateLastUpdated", dateLastUpdated);
                insertCommand.Parameters.AddWithValue("@actionTakenToFile", actionTakenToFile);
                insertCommand.Parameters.AddWithValue("@fileStatus", fileStatus);

                int row = objDbAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Your file is Registered Successfully!!");
                }
                else
                {
                    MessageBox.Show("Error Occured While Registering your file!!.. Please Try Again!!");
                }
            }

        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnStudentFileBrowsed_Click(object sender, EventArgs e)
        {
           if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtStudentFileBrowsed.Text = ofd.FileName;
            }
        }

        private void btnStudentPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal portal = new Student_Portal();
            portal.Show();
        }
    }
}
