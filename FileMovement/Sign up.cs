using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileMovement
{
    public partial class Sign_up : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public Sign_up()
        {
            InitializeComponent();
        }

        private void lblSignUpWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtSignUpUserName.Text;
            string userPassword = txtSignUpPassword.Text;

            if(userName.Equals(""))
            {
                MessageBox.Show("Please enter your Username..!!");
            }
            else if(userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password..!!");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into UserSignUp(Username,Password) values(@userName,@userPassword)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                

                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account is created to successfully..!!");

                    this.Hide();
                    fileMovement home = new fileMovement();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Error Occured while creating your account.Try again..!!");
                }
            }
        }
    }
}
