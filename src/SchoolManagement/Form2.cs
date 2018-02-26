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
    public partial class frmSearchProfile : Form
    {


        public frmSearchProfile()
        {
            InitializeComponent();
        }
        StudentTransactions st = new StudentTransactions();
        CourseTransactions ct = new CourseTransactions();

          private void LoadStudent()
        {
            DataSet ds = new DataSet();
            ds = st.search(txtSearch.Text);
            dgvStudents.DataSource = ds.Tables[0];

            DataSet count = new DataSet();
            count = st.getStudentCount();
            lblStudentCount.Text = count.Tables[0].Rows[0].ItemArray[0].ToString();

        }

        private void frmSearchProfile_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStudentProfile frm = new frmStudentProfile();
            frm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStudentProfile frm = new frmStudentProfile();
            frm.studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            st.deleteStudent(Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value.ToString())); //typecasting
            MessageBox.Show("Student succesfully deleted.");
            LoadStudent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            frmEnrollStudent frm = new frmEnrollStudent();
            frm.studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
            this.Hide();
        }

        private void tabAll_Enter(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void tabNotEnrolled_Enter(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            ds2 = ct.searchNotEnrolled(txtSearch.Text);
            dgvNotEnrolled.DataSource = ds2.Tables[0];

            DataSet count = new DataSet();
            count = ct.getNotEnrolledCount();
            lblStudentCount.Text = count.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void tabEnrolled_Enter(object sender, EventArgs e)
        {
            DataSet ds3 = new DataSet();
            ds3 = ct.searchEnrolled(txtSearch.Text);
            dgvEnrolled.DataSource = ds3.Tables[0];

            DataSet count = new DataSet();
            count = ct.getEnrolledCount();
            lblStudentCount.Text = count.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            frmSubjects frm = new frmSubjects();
            frm.Show();
            this.Hide();
        }
    }
}
