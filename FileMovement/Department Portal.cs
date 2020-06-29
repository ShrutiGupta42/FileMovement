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
    public partial class Department_Portal : Form
    {
        public Department_Portal()
        {
            InitializeComponent();
        }

        private void Department_Portal_Load(object sender, EventArgs e)
        {
            lblDept.Text = "Welcome : " + Dept_class.username;
        }

        private void btnDeptFileRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department_File_Registration dept = new Department_File_Registration();
            dept.Show();
        }
    }
}
