using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class frmStudentSubjects : Form
    {
        public int studentID;
        public frmStudentSubjects()
        {
            InitializeComponent();
        }

        CourseTransactions ct = new CourseTransactions();
        SubjectTransactions subt = new SubjectTransactions();
        private void frmStudentSubjects_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = subt.getStudentSubject(studentID);
            dgvStudentSubjects.DataSource = ds.Tables[0];

            DataSet ds2 = new DataSet();
            ds2 = ct.searchByStudentId(studentID);

            dispID.Text = ds2.Tables[0].Rows[0].ItemArray[0].ToString();
            dispName.Text = ds2.Tables[0].Rows[0].ItemArray[1].ToString() + " " + ds2.Tables[0].Rows[0].ItemArray[2].ToString() + " " + ds2.Tables[0].Rows[0].ItemArray[3].ToString();
            dispCourse.Text = ds2.Tables[0].Rows[0].ItemArray[9].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
            this.Hide();
        }
    }
}
