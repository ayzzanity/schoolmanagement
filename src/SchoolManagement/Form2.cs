using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmSearchProfile : Form
    {


        public frmSearchProfile()
        {
            InitializeComponent();
        }
        StudentTransactions st = new StudentTransactions();

          private void LoadStudent()
        {
            DataSet ds = new DataSet();
            ds = st.search(txtSearch.Text);
            dgvStudents.DataSource = ds.Tables[0];

            DataSet ds2 = new DataSet();
            ds2 = st.checkNotEnrolled(txtSearch.Text);
            dgvNotEnrolled.DataSource = ds.Tables[0];
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

        private void tabNotEnrolled_Click(object sender, EventArgs e)
        {
            
        }
    }
}
