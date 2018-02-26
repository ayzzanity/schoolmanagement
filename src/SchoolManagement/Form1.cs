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
    public partial class frmStudentProfile : Form
    {
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        public int studentID;
        StudentTransactions st = new StudentTransactions();
        private void frmStudentProfile_Load(object sender, EventArgs e)
        {
            if (studentID != 0) {
                DataSet ds = new DataSet();
                ds = st.getStudentByID(studentID);
                txtFirstname.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                txtMiddlename.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                txtLastname.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                txtAge.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                cboGender.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                btnSave.Text = "UPDATE";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("SAVE"))
            {
                st.insertStudent(txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, Convert.ToInt32(txtAge.Text), cboGender.Text);
                MessageBox.Show("New student successfully saved.");
            }
            else {
                st.updateStudent(studentID, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, Convert.ToInt32(txtAge.Text), cboGender.Text);
                MessageBox.Show("Student successfully updated.");
                btnSave.Text = "SAVE";
            }
            this.Hide();
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchProfile frm = new frmSearchProfile();
            frm.Show();
        }
    }
}
