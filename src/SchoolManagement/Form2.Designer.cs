namespace WindowsFormsApplication2
{
    partial class frmSearchProfile
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.tabStudents = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.tabNotEnrolled = new System.Windows.Forms.TabPage();
            this.dgvNotEnrolled = new System.Windows.Forms.DataGridView();
            this.tabEnrolled = new System.Windows.Forms.TabPage();
            this.dgvEnrolled = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabStudents.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.tabNotEnrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolled)).BeginInit();
            this.tabEnrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolled)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(471, 170);
            this.dgvStudents.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(120, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(189, 305);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 39);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(303, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 39);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(417, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 39);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(75, 305);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(108, 39);
            this.btnEnroll.TabIndex = 21;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.tabAll);
            this.tabStudents.Controls.Add(this.tabNotEnrolled);
            this.tabStudents.Controls.Add(this.tabEnrolled);
            this.tabStudents.Location = new System.Drawing.Point(40, 82);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.SelectedIndex = 0;
            this.tabStudents.Size = new System.Drawing.Size(485, 202);
            this.tabStudents.TabIndex = 22;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.dgvStudents);
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(477, 176);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "All Students";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // tabNotEnrolled
            // 
            this.tabNotEnrolled.Controls.Add(this.dgvNotEnrolled);
            this.tabNotEnrolled.Location = new System.Drawing.Point(4, 22);
            this.tabNotEnrolled.Name = "tabNotEnrolled";
            this.tabNotEnrolled.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotEnrolled.Size = new System.Drawing.Size(477, 176);
            this.tabNotEnrolled.TabIndex = 1;
            this.tabNotEnrolled.Text = "Not Enrolled";
            this.tabNotEnrolled.UseVisualStyleBackColor = true;
            this.tabNotEnrolled.Click += new System.EventHandler(this.tabNotEnrolled_Click);
            // 
            // dgvNotEnrolled
            // 
            this.dgvNotEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotEnrolled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotEnrolled.Location = new System.Drawing.Point(3, 3);
            this.dgvNotEnrolled.Name = "dgvNotEnrolled";
            this.dgvNotEnrolled.Size = new System.Drawing.Size(471, 170);
            this.dgvNotEnrolled.TabIndex = 16;
            // 
            // tabEnrolled
            // 
            this.tabEnrolled.Controls.Add(this.dgvEnrolled);
            this.tabEnrolled.Location = new System.Drawing.Point(4, 22);
            this.tabEnrolled.Name = "tabEnrolled";
            this.tabEnrolled.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnrolled.Size = new System.Drawing.Size(477, 176);
            this.tabEnrolled.TabIndex = 2;
            this.tabEnrolled.Text = "Enrolled";
            this.tabEnrolled.UseVisualStyleBackColor = true;
            // 
            // dgvEnrolled
            // 
            this.dgvEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrolled.Location = new System.Drawing.Point(3, 3);
            this.dgvEnrolled.Name = "dgvEnrolled";
            this.dgvEnrolled.Size = new System.Drawing.Size(471, 170);
            this.dgvEnrolled.TabIndex = 17;
            // 
            // frmSearchProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 372);
            this.Controls.Add(this.tabStudents);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmSearchProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.frmSearchProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabStudents.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.tabNotEnrolled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotEnrolled)).EndInit();
            this.tabEnrolled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.TabControl tabStudents;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabNotEnrolled;
        private System.Windows.Forms.TabPage tabEnrolled;
        private System.Windows.Forms.DataGridView dgvNotEnrolled;
        private System.Windows.Forms.DataGridView dgvEnrolled;
    }
}