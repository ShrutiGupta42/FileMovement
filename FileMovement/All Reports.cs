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

namespace FileMovement
{
    public partial class All_Reports : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public All_Reports()
        {
            InitializeComponent();
        }

        private void All_Reports_Load(object sender, EventArgs e)
        {
            string query = "Select * from fileRegistration";

            objDbAccess.readDatathroughAdapter(query,dtUsers);

            dgvAllReports.DataSource = dtUsers;
            objDbAccess.closeConn();

        }

        private void btnAdminPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator_Portal portal = new Administrator_Portal();
            portal.Show();
        }
    }
}
