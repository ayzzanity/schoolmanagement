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
    public partial class frmEnrollStudent : Form
    {
        public int studentID;
        public int courseID;
        StudentTransactions st = new StudentTransactions();
        CourseTransactions ct = new CourseTransactions();

        public frmEnrollStudent()
        {
            InitializeComponent();
        }

        private void frmEnrollStudent_Load(object sender, EventArgs e)
        {
            if(studentID != 0)
            {
                DataSet ds = new DataSet();
                ds = st.getStudentByID(studentID);

                lblUid.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                lblName.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString() + " " + ds.Tables[0].Rows[0].ItemArray[2].ToString() + " " + ds.Tables[0].Rows[0].ItemArray[3].ToString();
              
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = ct.getCourseByCode(cboCourse.SelectedItem.ToString());
            courseID = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

            ct.enrollStudent(studentID, courseID, dtpEnrolled.Value.ToShortDateString());
            MessageBox.Show("Student Enrolled!");
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
            this.Hide();
        }


    }
}
