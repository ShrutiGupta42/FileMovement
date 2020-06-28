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

        }
    }
}
