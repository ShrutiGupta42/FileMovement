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
    public partial class Student_Login : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public Student_Login()
        {
            InitializeComponent();
        }

        private void btnStudentSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up signUp = new Sign_up();
            signUp.Show();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string userName = txtStudentUsername.Text;
            string userPassword = txtStudentPassword.Text;

            if(userName.Equals(""))
            {
                MessageBox.Show("Please enter your Username!");
            }
            else if(userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password!");
            }
            else
            {
                string query = "Select * from UserSignUp Where Username= '" + userName + "' AND Password = '" + userPassword + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    Student_class.username = dtUsers.Rows[0]["Username"].ToString();
                    MessageBox.Show("Congratulations, You are logged in Successfully!!");
                    objDbAccess.closeConn();

                    this.Hide();
                    Student_Portal student = new Student_Portal();
                    student.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!!. Provide Correct Username and Password");
                }
            }
        }

        private void Student_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
