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
    public partial class Department_File_Registration : Form
    {
        public Department_File_Registration()
        {
            InitializeComponent();
        }

        private void btnStudentFileNoGenerator_Click(object sender, EventArgs e)
        {

        }

        private void btnDeptFileNoGenerator_Click(object sender, EventArgs e)
        {
            char[] letters = "1234567890".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 4; i++)
            {
                randomString += letters[r.Next(0, 9)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void btnDeptFileRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
