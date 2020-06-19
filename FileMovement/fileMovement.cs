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
    public partial class fileMovement : Form
    {
        public fileMovement()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department_Login dept = new Department_Login();
            dept.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login student = new Student_Login();
            student.Show();
        }

        private void fileMovement_Load(object sender, EventArgs e)
        {

        }
    }
}
