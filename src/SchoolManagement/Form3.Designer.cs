namespace WindowsFormsApplication2
{
    partial class frmEnrollStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblDateEnrolled = new System.Windows.Forms.Label();
            this.dtpEnrolled = new System.Windows.Forms.DateTimePicker();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(56, 59);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(83, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(30, 100);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 16);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.Location = new System.Drawing.Point(146, 59);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(15, 16);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "_";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(145, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "_";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(78, 145);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(61, 16);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course:";
            // 
            // lblDateEnrolled
            // 
            this.lblDateEnrolled.AutoSize = true;
            this.lblDateEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnrolled.Location = new System.Drawing.Point(32, 182);
            this.lblDateEnrolled.Name = "lblDateEnrolled";
            this.lblDateEnrolled.Size = new System.Drawing.Size(107, 16);
            this.lblDateEnrolled.TabIndex = 5;
            this.lblDateEnrolled.Text = "Date Enrolled:";
            // 
            // dtpEnrolled
            // 
            this.dtpEnrolled.Location = new System.Drawing.Point(149, 182);
            this.dtpEnrolled.Name = "dtpEnrolled";
            this.dtpEnrolled.Size = new System.Drawing.Size(199, 20);
            this.dtpEnrolled.TabIndex = 6;
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Items.AddRange(new object[] {
            "BS CpE",
            "BS ECE",
            "BS EE",
            "BS CE",
            "BS SE",
            "BS IE",
            "BS ME",
            "BS GE",
            "BS ENE"});
            this.cboCourse.Location = new System.Drawing.Point(149, 145);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(199, 21);
            this.cboCourse.TabIndex = 7;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(240, 253);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(108, 39);
            this.btnEnroll.TabIndex = 22;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(126, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 39);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEnrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 327);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.dtpEnrolled);
            this.Controls.Add(this.lblDateEnrolled);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmEnrollStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enroll Student";
            this.Load += new System.EventHandler(this.frmEnrollStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblDateEnrolled;
        private System.Windows.Forms.DateTimePicker dtpEnrolled;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnBack;
    }
}