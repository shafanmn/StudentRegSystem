namespace StudentRegSystem.Forms
{
    partial class frm_Prof
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrEditPr = new System.Windows.Forms.Button();
            this.lblPrnic = new System.Windows.Forms.Label();
            this.lblPrName = new System.Windows.Forms.Label();
            this.lblPrId = new System.Windows.Forms.Label();
            this.txtPrpass = new System.Windows.Forms.TextBox();
            this.txtPrCont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTecName = new System.Windows.Forms.Label();
            this.lblTecId = new System.Windows.Forms.Label();
            this.dgvPrTeach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrTeach = new System.Windows.Forms.Button();
            this.lblSerName = new System.Windows.Forms.Label();
            this.lblSerId = new System.Windows.Forms.Label();
            this.txtPrSch = new System.Windows.Forms.TextBox();
            this.dgvPrSearch = new System.Windows.Forms.DataGridView();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrTeach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 311);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrEditPr);
            this.groupBox1.Controls.Add(this.lblPrnic);
            this.groupBox1.Controls.Add(this.lblPrName);
            this.groupBox1.Controls.Add(this.lblPrId);
            this.groupBox1.Controls.Add(this.txtPrpass);
            this.groupBox1.Controls.Add(this.txtPrCont);
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
            // btnPrEditPr
            // 
            this.btnPrEditPr.Location = new System.Drawing.Point(162, 205);
            this.btnPrEditPr.Name = "btnPrEditPr";
            this.btnPrEditPr.Size = new System.Drawing.Size(62, 30);
            this.btnPrEditPr.TabIndex = 11;
            this.btnPrEditPr.Text = "Edit";
            this.btnPrEditPr.UseVisualStyleBackColor = true;
            this.btnPrEditPr.Click += new System.EventHandler(this.btnStEditPr_Click);
            // 
            // lblPrnic
            // 
            this.lblPrnic.AutoSize = true;
            this.lblPrnic.Location = new System.Drawing.Point(92, 101);
            this.lblPrnic.Name = "lblPrnic";
            this.lblPrnic.Size = new System.Drawing.Size(30, 13);
            this.lblPrnic.TabIndex = 10;
            this.lblPrnic.Text = "N.i.C";
            // 
            // lblPrName
            // 
            this.lblPrName.AutoSize = true;
            this.lblPrName.Location = new System.Drawing.Point(92, 66);
            this.lblPrName.Name = "lblPrName";
            this.lblPrName.Size = new System.Drawing.Size(35, 13);
            this.lblPrName.TabIndex = 9;
            this.lblPrName.Text = "Name";
            // 
            // lblPrId
            // 
            this.lblPrId.AutoSize = true;
            this.lblPrId.Location = new System.Drawing.Point(91, 31);
            this.lblPrId.Name = "lblPrId";
            this.lblPrId.Size = new System.Drawing.Size(58, 13);
            this.lblPrId.TabIndex = 8;
            this.lblPrId.Text = "Student ID";
            // 
            // txtPrpass
            // 
            this.txtPrpass.Enabled = false;
            this.txtPrpass.Location = new System.Drawing.Point(94, 168);
            this.txtPrpass.Name = "txtPrpass";
            this.txtPrpass.Size = new System.Drawing.Size(130, 20);
            this.txtPrpass.TabIndex = 7;
            // 
            // txtPrCont
            // 
            this.txtPrCont.Enabled = false;
            this.txtPrCont.Location = new System.Drawing.Point(94, 133);
            this.txtPrCont.Name = "txtPrCont";
            this.txtPrCont.Size = new System.Drawing.Size(130, 20);
            this.txtPrCont.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teaching";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblTecName);
            this.groupBox3.Controls.Add(this.lblTecId);
            this.groupBox3.Controls.Add(this.dgvPrTeach);
            this.groupBox3.Location = new System.Drawing.Point(262, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 278);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teaching Courses";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "<< Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTecName
            // 
            this.lblTecName.AutoSize = true;
            this.lblTecName.Location = new System.Drawing.Point(68, 227);
            this.lblTecName.Name = "lblTecName";
            this.lblTecName.Size = new System.Drawing.Size(71, 13);
            this.lblTecName.TabIndex = 3;
            this.lblTecName.Text = "Course Name";
            // 
            // lblTecId
            // 
            this.lblTecId.AutoSize = true;
            this.lblTecId.Location = new System.Drawing.Point(6, 227);
            this.lblTecId.Name = "lblTecId";
            this.lblTecId.Size = new System.Drawing.Size(18, 13);
            this.lblTecId.TabIndex = 2;
            this.lblTecId.Text = "ID";
            // 
            // dgvPrTeach
            // 
            this.dgvPrTeach.AllowUserToAddRows = false;
            this.dgvPrTeach.AllowUserToDeleteRows = false;
            this.dgvPrTeach.AllowUserToResizeRows = false;
            this.dgvPrTeach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrTeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrTeach.Location = new System.Drawing.Point(6, 19);
            this.dgvPrTeach.Name = "dgvPrTeach";
            this.dgvPrTeach.ReadOnly = true;
            this.dgvPrTeach.RowHeadersVisible = false;
            this.dgvPrTeach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrTeach.Size = new System.Drawing.Size(224, 201);
            this.dgvPrTeach.TabIndex = 0;
            this.dgvPrTeach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrTeach_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrTeach);
            this.groupBox2.Controls.Add(this.lblSerName);
            this.groupBox2.Controls.Add(this.lblSerId);
            this.groupBox2.Controls.Add(this.txtPrSch);
            this.groupBox2.Controls.Add(this.dgvPrSearch);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Courses";
            // 
            // btnPrTeach
            // 
            this.btnPrTeach.Location = new System.Drawing.Point(162, 248);
            this.btnPrTeach.Name = "btnPrTeach";
            this.btnPrTeach.Size = new System.Drawing.Size(68, 26);
            this.btnPrTeach.TabIndex = 4;
            this.btnPrTeach.Text = "Teach >>";
            this.btnPrTeach.UseVisualStyleBackColor = true;
            this.btnPrTeach.Click += new System.EventHandler(this.btnPrTeach_Click);
            // 
            // lblSerName
            // 
            this.lblSerName.AutoSize = true;
            this.lblSerName.Location = new System.Drawing.Point(47, 227);
            this.lblSerName.Name = "lblSerName";
            this.lblSerName.Size = new System.Drawing.Size(71, 13);
            this.lblSerName.TabIndex = 3;
            this.lblSerName.Text = "Course Name";
            // 
            // lblSerId
            // 
            this.lblSerId.AutoSize = true;
            this.lblSerId.Location = new System.Drawing.Point(6, 227);
            this.lblSerId.Name = "lblSerId";
            this.lblSerId.Size = new System.Drawing.Size(18, 13);
            this.lblSerId.TabIndex = 2;
            this.lblSerId.Text = "ID";
            // 
            // txtPrSch
            // 
            this.txtPrSch.Location = new System.Drawing.Point(6, 19);
            this.txtPrSch.Name = "txtPrSch";
            this.txtPrSch.Size = new System.Drawing.Size(224, 20);
            this.txtPrSch.TabIndex = 1;
            this.txtPrSch.TextChanged += new System.EventHandler(this.txtPrSch_TextChanged);
            // 
            // dgvPrSearch
            // 
            this.dgvPrSearch.AllowUserToAddRows = false;
            this.dgvPrSearch.AllowUserToDeleteRows = false;
            this.dgvPrSearch.AllowUserToResizeRows = false;
            this.dgvPrSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrSearch.Location = new System.Drawing.Point(6, 45);
            this.dgvPrSearch.Name = "dgvPrSearch";
            this.dgvPrSearch.ReadOnly = true;
            this.dgvPrSearch.RowHeadersVisible = false;
            this.dgvPrSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrSearch.Size = new System.Drawing.Size(224, 175);
            this.dgvPrSearch.TabIndex = 0;
            this.dgvPrSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrSearch_MouseClick);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(446, 0);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(62, 31);
            this.btnLogOff.TabIndex = 3;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // frm_Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Prof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor :";
            this.Load += new System.EventHandler(this.frm_Prof_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrTeach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrEditPr;
        private System.Windows.Forms.Label lblPrnic;
        private System.Windows.Forms.Label lblPrName;
        private System.Windows.Forms.Label lblPrId;
        private System.Windows.Forms.TextBox txtPrpass;
        private System.Windows.Forms.TextBox txtPrCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.TextBox txtPrSch;
        private System.Windows.Forms.DataGridView dgvPrSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTecName;
        private System.Windows.Forms.Label lblTecId;
        private System.Windows.Forms.DataGridView dgvPrTeach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrTeach;
        private System.Windows.Forms.Label lblSerName;
        private System.Windows.Forms.Label lblSerId;
    }
}