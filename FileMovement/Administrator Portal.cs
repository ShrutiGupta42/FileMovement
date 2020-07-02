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
    public partial class Administrator_Portal : Form
    {
        public Administrator_Portal()
        {
            InitializeComponent();
        }

        private void Administrator_Portal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'signUpDataSet.UserSignUp' table. You can move, or remove it, as needed.
            this.userSignUpTableAdapter.Fill(this.signUpDataSet.UserSignUp);
            lblAdmin.Text = "Welcome : " + Admin_class.username;
        }

        private void btnAdminManageUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Users_Details users = new All_Users_Details();
            users.Show();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fileMovement file = new fileMovement();
            file.Show();
        }

        private void btnAdminCloseFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_File remove = new Remove_File();
            remove.Show();
        }

        private void btnAdminViewReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Reports reports = new All_Reports();
            reports.Show();
        }
    }
}
