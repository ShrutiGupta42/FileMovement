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
    public partial class Student_File_Registration : Form
    {
        public Student_File_Registration()
        {
            InitializeComponent();
        }

        private void btnStudentFileNoGenerator_Click(object sender, EventArgs e)
        {
            char[] letters = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for(int i = 0; i < 4; i++)
            {
                randomString += letters[r.Next(0, 35)].ToString();
            }
            MessageBox.Show(randomString);  
        }

        private void lblStudentFileNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
