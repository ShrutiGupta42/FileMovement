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
    public partial class File_Status : Form
    {
        public File_Status()
        {
            InitializeComponent();
        }

        private void btnUpdateFileRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal portal = new Student_Portal();
            portal.Show();
        }

        private void File_Status_Load(object sender, EventArgs e)
        {
            txtStudentStatusFileNumber.Text = Student_File_Status_Validation.fN;
            txtStudentStatusFileSubject.Text = Student_File_Status_Validation.subj;
            txtStudentStatusFileDept.Text = Student_File_Status_Validation.depart;
            txtStudentStatusFileSubjectDetails.Text = Student_File_Status_Validation.subjDetails;
            txtStudentStatusFileBrowsed.Text = Student_File_Status_Validation.fileBrow;
            dateStudentStatusFile.Text = Student_File_Status_Validation.datee;
            txtStudentStatusFileName.Text = Student_File_Status_Validation.namee;
            txtStudentStatusFileUser.Text = Student_File_Status_Validation.userr;
            dateStudentStatusFileLastUpdated.Text = Student_File_Status_Validation.dateLastUpdate;
            txtStudentStatusFileAction.Text = Student_File_Status_Validation.actionTakenToFilee;
            txtStudentStatusFileStatus.Text = Student_File_Status_Validation.fileStatuss;

        }
    }
}
