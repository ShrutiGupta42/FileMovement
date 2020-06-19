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
    public partial class All_Users_Details : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public All_Users_Details()
        {
            InitializeComponent();
        }

        private void All_Users_Details_Load(object sender, EventArgs e)
        {
            string query = "Select * from UserSignUp";

            objDbAccess.readDatathroughAdapter(query, dtUsers);
            dataGridView1.DataSource = dtUsers;
            objDbAccess.closeConn();

        }

        private void btnManageUserAccounts_Click(object sender, EventArgs e)
        {
            string query = "Select * from UserSignUp";

            int changes = objDbAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("Count = " + changes);
        }
    }
}
