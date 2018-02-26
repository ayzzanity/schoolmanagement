namespace SchoolManagement
{
    partial class frmStudentSubjects
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
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dispID = new System.Windows.Forms.Label();
            this.dispName = new System.Windows.Forms.Label();
            this.dispCourse = new System.Windows.Forms.Label();
            this.dgvStudentSubjects = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(67, 77);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(61, 16);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(19, 51);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 16);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(45, 25);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(83, 16);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID:";
            // 
            // dispID
            // 
            this.dispID.AutoSize = true;
            this.dispID.Location = new System.Drawing.Point(135, 25);
            this.dispID.Name = "dispID";
            this.dispID.Size = new System.Drawing.Size(65, 13);
            this.dispID.TabIndex = 8;
            this.dispID.Text = "<studentID>";
            // 
            // dispName
            // 
            this.dispName.AutoSize = true;
            this.dispName.Location = new System.Drawing.Point(135, 53);
            this.dispName.Name = "dispName";
            this.dispName.Size = new System.Drawing.Size(82, 13);
            this.dispName.TabIndex = 9;
            this.dispName.Text = "<studentName>";
            // 
            // dispCourse
            // 
            this.dispCourse.AutoSize = true;
            this.dispCourse.Location = new System.Drawing.Point(134, 79);
            this.dispCourse.Name = "dispCourse";
            this.dispCourse.Size = new System.Drawing.Size(87, 13);
            this.dispCourse.TabIndex = 10;
            this.dispCourse.Text = "<studentCourse>";
            // 
            // dgvStudentSubjects
            // 
            this.dgvStudentSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentSubjects.Location = new System.Drawing.Point(12, 110);
            this.dgvStudentSubjects.Name = "dgvStudentSubjects";
            this.dgvStudentSubjects.Size = new System.Drawing.Size(534, 171);
            this.dgvStudentSubjects.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(456, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 30);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStudentSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 323);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStudentSubjects);
            this.Controls.Add(this.dispCourse);
            this.Controls.Add(this.dispName);
            this.Controls.Add(this.dispID);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmStudentSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Subjects";
            this.Load += new System.EventHandler(this.frmStudentSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label dispID;
        private System.Windows.Forms.Label dispName;
        private System.Windows.Forms.Label dispCourse;
        private System.Windows.Forms.DataGridView dgvStudentSubjects;
        private System.Windows.Forms.Button btnBack;
    }
}