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
    public partial class Student_Portal : Form
    {
        public Student_Portal()
        {
            InitializeComponent();
        }

        private void Student_Portal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'signUpDataSet1.UserSignUp' table. You can move, or remove it, as needed.
            this.userSignUpTableAdapter.Fill(this.signUpDataSet1.UserSignUp);
            lblStudent.Text = "Welcome : " + Student_class.username;
        }
    }
}
