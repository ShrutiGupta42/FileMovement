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
using System.Data.SqlClient;

namespace FileMovement
{
    public partial class AdminLogin : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up signUp = new Sign_up();
            signUp.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string userName = txtAdminUsername.Text;
            string userPassword = txtAdminPassword.Text;

            if(userName.Equals(""))
            {
                MessageBox.Show("Please enter your Username");
            }
            else if(userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password");
            }
            else
            {
                string query = "Select * from UserSignUp Where Username= '" + userName +"' AND Password = '" + userPassword + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    Admin_class.username = dtUsers.Rows[0]["Username"].ToString(); 
                    MessageBox.Show("Congratulations, You are logged in Successfully!!");
                    objDbAccess.closeConn();

                    this.Hide();
                    Administrator_Portal admin = new Administrator_Portal();
                    admin.Show();
                      
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!!. Provide Correct Username and Password");
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
