namespace StudentRegSystem.Forms
{
    partial class frm_Student
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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStEditPr = new System.Windows.Forms.Button();
            this.lblStnic = new System.Windows.Forms.Label();
            this.lblStName = new System.Windows.Forms.Label();
            this.lblStId = new System.Windows.Forms.Label();
            this.txtStpass = new System.Windows.Forms.TextBox();
            this.txtStCont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStPending = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvStPayPending = new System.Windows.Forms.DataGridView();
            this.dgvStEnrolled = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStApplyCourse = new System.Windows.Forms.Button();
            this.lblStEnFee = new System.Windows.Forms.Label();
            this.lblStEnDuration = new System.Windows.Forms.Label();
            this.lblStEnName = new System.Windows.Forms.Label();
            this.lblStEnID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStSearch = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStPayPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStEnrolled)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(673, 3);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(61, 31);
            this.btnLogoff.TabIndex = 0;
            this.btnLogoff.Text = "Log Off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 290);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStEditPr);
            this.groupBox1.Controls.Add(this.lblStnic);
            this.groupBox1.Controls.Add(this.lblStName);
            this.groupBox1.Controls.Add(this.lblStId);
            this.groupBox1.Controls.Add(this.txtStpass);
            this.groupBox1.Controls.Add(this.txtStCont);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Details";
            // 
            // btnStEditPr
            // 
            this.btnStEditPr.Location = new System.Drawing.Point(162, 205);
            this.btnStEditPr.Name = "btnStEditPr";
            this.btnStEditPr.Size = new System.Drawing.Size(62, 30);
            this.btnStEditPr.TabIndex = 11;
            this.btnStEditPr.Text = "Edit";
            this.btnStEditPr.UseVisualStyleBackColor = true;
            this.btnStEditPr.Click += new System.EventHandler(this.btnStEditPr_Click);
            // 
            // lblStnic
            // 
            this.lblStnic.AutoSize = true;
            this.lblStnic.Location = new System.Drawing.Point(92, 101);
            this.lblStnic.Name = "lblStnic";
            this.lblStnic.Size = new System.Drawing.Size(30, 13);
            this.lblStnic.TabIndex = 10;
            this.lblStnic.Text = "N.i.C";
            // 
            // lblStName
            // 
            this.lblStName.AutoSize = true;
            this.lblStName.Location = new System.Drawing.Point(92, 66);
            this.lblStName.Name = "lblStName";
            this.lblStName.Size = new System.Drawing.Size(35, 13);
            this.lblStName.TabIndex = 9;
            this.lblStName.Text = "Name";
            // 
            // lblStId
            // 
            this.lblStId.AutoSize = true;
            this.lblStId.Location = new System.Drawing.Point(91, 31);
            this.lblStId.Name = "lblStId";
            this.lblStId.Size = new System.Drawing.Size(58, 13);
            this.lblStId.TabIndex = 8;
            this.lblStId.Text = "Student ID";
            // 
            // txtStpass
            // 
            this.txtStpass.Enabled = false;
            this.txtStpass.Location = new System.Drawing.Point(94, 168);
            this.txtStpass.Name = "txtStpass";
            this.txtStpass.Size = new System.Drawing.Size(130, 20);
            this.txtStpass.TabIndex = 7;
            // 
            // txtStCont
            // 
            this.txtStCont.Enabled = false;
            this.txtStCont.Location = new System.Drawing.Point(94, 133);
            this.txtStCont.Name = "txtStCont";
            this.txtStCont.Size = new System.Drawing.Size(130, 20);
            this.txtStCont.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N.i.C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.lblStPending);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvStPayPending);
            this.tabPage2.Controls.Add(this.dgvStEnrolled);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enroll";
            // 
            // lblStPending
            // 
            this.lblStPending.Location = new System.Drawing.Point(599, 6);
            this.lblStPending.Name = "lblStPending";
            this.lblStPending.Size = new System.Drawing.Size(129, 16);
            this.lblStPending.TabIndex = 7;
            this.lblStPending.Text = "amount";
            this.lblStPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Enrolled";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Payment Pending";
            // 
            // dgvStPayPending
            // 
            this.dgvStPayPending.AllowUserToAddRows = false;
            this.dgvStPayPending.AllowUserToDeleteRows = false;
            this.dgvStPayPending.AllowUserToResizeRows = false;
            this.dgvStPayPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStPayPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStPayPending.Location = new System.Drawing.Point(417, 25);
            this.dgvStPayPending.Name = "dgvStPayPending";
            this.dgvStPayPending.ReadOnly = true;
            this.dgvStPayPending.RowHeadersVisible = false;
            this.dgvStPayPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStPayPending.Size = new System.Drawing.Size(311, 110);
            this.dgvStPayPending.TabIndex = 4;
            // 
            // dgvStEnrolled
            // 
            this.dgvStEnrolled.AllowUserToAddRows = false;
            this.dgvStEnrolled.AllowUserToDeleteRows = false;
            this.dgvStEnrolled.AllowUserToResizeRows = false;
            this.dgvStEnrolled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStEnrolled.Location = new System.Drawing.Point(417, 151);
            this.dgvStEnrolled.Name = "dgvStEnrolled";
            this.dgvStEnrolled.ReadOnly = true;
            this.dgvStEnrolled.RowHeadersVisible = false;
            this.dgvStEnrolled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStEnrolled.Size = new System.Drawing.Size(311, 109);
            this.dgvStEnrolled.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStApplyCourse);
            this.groupBox2.Controls.Add(this.lblStEnFee);
            this.groupBox2.Controls.Add(this.lblStEnDuration);
            this.groupBox2.Controls.Add(this.lblStEnName);
            this.groupBox2.Controls.Add(this.lblStEnID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvStSearch);
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Courses";
            // 
            // btnStApplyCourse
            // 
            this.btnStApplyCourse.Enabled = false;
            this.btnStApplyCourse.Location = new System.Drawing.Point(223, 209);
            this.btnStApplyCourse.Name = "btnStApplyCourse";
            this.btnStApplyCourse.Size = new System.Drawing.Size(83, 29);
            this.btnStApplyCourse.TabIndex = 9;
            this.btnStApplyCourse.Text = "Apply Course";
            this.btnStApplyCourse.UseVisualStyleBackColor = true;
            this.btnStApplyCourse.Click += new System.EventHandler(this.btnStApplyCourse_Click);
            // 
            // lblStEnFee
            // 
            this.lblStEnFee.AutoSize = true;
            this.lblStEnFee.Location = new System.Drawing.Point(279, 148);
            this.lblStEnFee.Name = "lblStEnFee";
            this.lblStEnFee.Size = new System.Drawing.Size(19, 13);
            this.lblStEnFee.TabIndex = 8;
            this.lblStEnFee.Text = "- - ";
            // 
            // lblStEnDuration
            // 
            this.lblStEnDuration.AutoSize = true;
            this.lblStEnDuration.Location = new System.Drawing.Point(279, 108);
            this.lblStEnDuration.Name = "lblStEnDuration";
            this.lblStEnDuration.Size = new System.Drawing.Size(19, 13);
            this.lblStEnDuration.TabIndex = 7;
            this.lblStEnDuration.Text = "- - ";
            // 
            // lblStEnName
            // 
            this.lblStEnName.AutoSize = true;
            this.lblStEnName.Location = new System.Drawing.Point(279, 68);
            this.lblStEnName.Name = "lblStEnName";
            this.lblStEnName.Size = new System.Drawing.Size(16, 13);
            this.lblStEnName.TabIndex = 6;
            this.lblStEnName.Text = "- -";
            // 
            // lblStEnID
            // 
            this.lblStEnID.AutoSize = true;
            this.lblStEnID.Location = new System.Drawing.Point(279, 28);
            this.lblStEnID.Name = "lblStEnID";
            this.lblStEnID.Size = new System.Drawing.Size(13, 13);
            this.lblStEnID.TabIndex = 5;
            this.lblStEnID.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Course Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // dgvStSearch
            // 
            this.dgvStSearch.AllowUserToAddRows = false;
            this.dgvStSearch.AllowUserToDeleteRows = false;
            this.dgvStSearch.AllowUserToResizeRows = false;
            this.dgvStSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStSearch.Location = new System.Drawing.Point(6, 19);
            this.dgvStSearch.Name = "dgvStSearch";
            this.dgvStSearch.ReadOnly = true;
            this.dgvStSearch.RowHeadersVisible = false;
            this.dgvStSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStSearch.Size = new System.Drawing.Size(210, 219);
            this.dgvStSearch.TabIndex = 0;
            this.dgvStSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvStSearch_MouseClick);
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student :";
            this.Load += new System.EventHandler(this.frm_Student_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStPayPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStEnrolled)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStEditPr;
        private System.Windows.Forms.Label lblStnic;
        private System.Windows.Forms.Label lblStName;
        private System.Windows.Forms.Label lblStId;
        private System.Windows.Forms.TextBox txtStpass;
        private System.Windows.Forms.TextBox txtStCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStApplyCourse;
        private System.Windows.Forms.Label lblStEnFee;
        private System.Windows.Forms.Label lblStEnDuration;
        private System.Windows.Forms.Label lblStEnName;
        private System.Windows.Forms.Label lblStEnID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStPending;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvStPayPending;
        private System.Windows.Forms.DataGridView dgvStEnrolled;
    }
}