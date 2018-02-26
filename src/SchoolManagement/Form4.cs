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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }
        SubjectTransactions st = new SubjectTransactions();
        CourseTransactions ct = new CourseTransactions();

        public string courseID;
        private void frmSubjects_Load(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            ds = st.getSubjects("","", "");
            dgvSubjects.DataSource = ds.Tables[0];

            DataSet ds2 = new DataSet();
            ds2 = ct.getCourses();
            cboCourse.DataSource = ds2.Tables[0];
            cboCourse.DisplayMember = "Description";
            cboCourse.SelectedIndex = -1;
        }

        private void cboCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void cboYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }
        private void cboSem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            DataSet ds = new DataSet();
            ds = ct.getCourseByDesc(cboCourse.GetItemText(cboCourse.SelectedItem));
            courseID = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            ds = st.getSubjects(courseID, cboYear.GetItemText(cboYear.SelectedItem), cboSem.GetItemText(cboSem.SelectedItem));
            dgvSubjects.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
            this.Hide();
        }
    }
        
}
