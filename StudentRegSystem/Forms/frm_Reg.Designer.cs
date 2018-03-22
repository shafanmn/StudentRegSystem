namespace StudentRegSystem.Forms
{
    partial class frm_Reg
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStClear = new System.Windows.Forms.Button();
            this.btnStSave = new System.Windows.Forms.Button();
            this.btnStNew = new System.Windows.Forms.Button();
            this.txtStPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStcont = new System.Windows.Forms.TextBox();
            this.txtStnic = new System.Windows.Forms.TextBox();
            this.txtStlname = new System.Windows.Forms.TextBox();
            this.txtStfname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrClear = new System.Windows.Forms.Button();
            this.btnPrSave = new System.Windows.Forms.Button();
            this.btnPrAdd = new System.Windows.Forms.Button();
            this.txtPrpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrcontact = new System.Windows.Forms.TextBox();
            this.txtPrnic = new System.Windows.Forms.TextBox();
            this.txtPrlname = new System.Windows.Forms.TextBox();
            this.txtPrfname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.txtCrName = new System.Windows.Forms.TabPage();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.txtCoSearch = new System.Windows.Forms.TextBox();
            this.numCoDur = new System.Windows.Forms.NumericUpDown();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.numCoFee = new System.Windows.Forms.NumericUpDown();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.btnCoClear = new System.Windows.Forms.Button();
            this.btnCoNew = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCoSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCoId = new System.Windows.Forms.Label();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgvRegPayment = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.txtCrName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoDur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.txtCrName);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 340);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStClear);
            this.groupBox2.Controls.Add(this.btnStSave);
            this.groupBox2.Controls.Add(this.btnStNew);
            this.groupBox2.Controls.Add(this.txtStPass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStcont);
            this.groupBox2.Controls.Add(this.txtStnic);
            this.groupBox2.Controls.Add(this.txtStlname);
            this.groupBox2.Controls.Add(this.txtStfname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblSID);
            this.groupBox2.Controls.Add(this.dgvStudents);
            this.groupBox2.Location = new System.Drawing.Point(378, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 302);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // btnStClear
            // 
            this.btnStClear.Location = new System.Drawing.Point(307, 236);
            this.btnStClear.Name = "btnStClear";
            this.btnStClear.Size = new System.Drawing.Size(50, 30);
            this.btnStClear.TabIndex = 15;
            this.btnStClear.Text = "Clear";
            this.btnStClear.UseVisualStyleBackColor = true;
            this.btnStClear.Click += new System.EventHandler(this.btnStClear_Click);
            // 
            // btnStSave
            // 
            this.btnStSave.Enabled = false;
            this.btnStSave.Location = new System.Drawing.Point(247, 236);
            this.btnStSave.Name = "btnStSave";
            this.btnStSave.Size = new System.Drawing.Size(50, 30);
            this.btnStSave.TabIndex = 14;
            this.btnStSave.Text = "Save";
            this.btnStSave.UseVisualStyleBackColor = true;
            this.btnStSave.Click += new System.EventHandler(this.btnStSave_Click);
            // 
            // btnStNew
            // 
            this.btnStNew.Location = new System.Drawing.Point(187, 236);
            this.btnStNew.Name = "btnStNew";
            this.btnStNew.Size = new System.Drawing.Size(50, 30);
            this.btnStNew.TabIndex = 13;
            this.btnStNew.Text = "New";
            this.btnStNew.UseVisualStyleBackColor = true;
            this.btnStNew.Click += new System.EventHandler(this.btnStNew_Click);
            // 
            // txtStPass
            // 
            this.txtStPass.Location = new System.Drawing.Point(253, 194);
            this.txtStPass.Name = "txtStPass";
            this.txtStPass.Size = new System.Drawing.Size(108, 20);
            this.txtStPass.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // txtStcont
            // 
            this.txtStcont.Location = new System.Drawing.Point(253, 162);
            this.txtStcont.Name = "txtStcont";
            this.txtStcont.Size = new System.Drawing.Size(108, 20);
            this.txtStcont.TabIndex = 10;
            // 
            // txtStnic
            // 
            this.txtStnic.Location = new System.Drawing.Point(253, 128);
            this.txtStnic.Name = "txtStnic";
            this.txtStnic.Size = new System.Drawing.Size(108, 20);
            this.txtStnic.TabIndex = 9;
            // 
            // txtStlname
            // 
            this.txtStlname.Location = new System.Drawing.Point(253, 94);
            this.txtStlname.Name = "txtStlname";
            this.txtStlname.Size = new System.Drawing.Size(108, 20);
            this.txtStlname.TabIndex = 8;
            // 
            // txtStfname
            // 
            this.txtStfname.Location = new System.Drawing.Point(253, 60);
            this.txtStfname.Name = "txtStfname";
            this.txtStfname.Size = new System.Drawing.Size(108, 20);
            this.txtStfname.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contact No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "N.I.C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "ID  :";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(255, 29);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(35, 13);
            this.lblSID.TabIndex = 1;
            this.lblSID.Text = "label1";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(6, 19);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(175, 247);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrClear);
            this.groupBox1.Controls.Add(this.btnPrSave);
            this.groupBox1.Controls.Add(this.btnPrAdd);
            this.groupBox1.Controls.Add(this.txtPrpass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrcontact);
            this.groupBox1.Controls.Add(this.txtPrnic);
            this.groupBox1.Controls.Add(this.txtPrlname);
            this.groupBox1.Controls.Add(this.txtPrfname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPID);
            this.groupBox1.Controls.Add(this.dgvProfessors);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professors";
            // 
            // btnPrClear
            // 
            this.btnPrClear.Location = new System.Drawing.Point(307, 236);
            this.btnPrClear.Name = "btnPrClear";
            this.btnPrClear.Size = new System.Drawing.Size(50, 30);
            this.btnPrClear.TabIndex = 15;
            this.btnPrClear.Text = "Clear";
            this.btnPrClear.UseVisualStyleBackColor = true;
            this.btnPrClear.Click += new System.EventHandler(this.btnPrClear_Click);
            // 
            // btnPrSave
            // 
            this.btnPrSave.Enabled = false;
            this.btnPrSave.Location = new System.Drawing.Point(247, 236);
            this.btnPrSave.Name = "btnPrSave";
            this.btnPrSave.Size = new System.Drawing.Size(50, 30);
            this.btnPrSave.TabIndex = 14;
            this.btnPrSave.Text = "Save";
            this.btnPrSave.UseVisualStyleBackColor = true;
            this.btnPrSave.Click += new System.EventHandler(this.btnPrSave_Click);
            // 
            // btnPrAdd
            // 
            this.btnPrAdd.Location = new System.Drawing.Point(187, 236);
            this.btnPrAdd.Name = "btnPrAdd";
            this.btnPrAdd.Size = new System.Drawing.Size(50, 30);
            this.btnPrAdd.TabIndex = 13;
            this.btnPrAdd.Text = "New";
            this.btnPrAdd.UseVisualStyleBackColor = true;
            this.btnPrAdd.Click += new System.EventHandler(this.btnPrAdd_Click);
            // 
            // txtPrpass
            // 
            this.txtPrpass.Location = new System.Drawing.Point(253, 194);
            this.txtPrpass.Name = "txtPrpass";
            this.txtPrpass.Size = new System.Drawing.Size(108, 20);
            this.txtPrpass.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // txtPrcontact
            // 
            this.txtPrcontact.Location = new System.Drawing.Point(253, 162);
            this.txtPrcontact.Name = "txtPrcontact";
            this.txtPrcontact.Size = new System.Drawing.Size(108, 20);
            this.txtPrcontact.TabIndex = 10;
            // 
            // txtPrnic
            // 
            this.txtPrnic.Location = new System.Drawing.Point(253, 128);
            this.txtPrnic.Name = "txtPrnic";
            this.txtPrnic.Size = new System.Drawing.Size(108, 20);
            this.txtPrnic.TabIndex = 9;
            // 
            // txtPrlname
            // 
            this.txtPrlname.Location = new System.Drawing.Point(253, 94);
            this.txtPrlname.Name = "txtPrlname";
            this.txtPrlname.Size = new System.Drawing.Size(108, 20);
            this.txtPrlname.TabIndex = 8;
            // 
            // txtPrfname
            // 
            this.txtPrfname.Location = new System.Drawing.Point(253, 60);
            this.txtPrfname.Name = "txtPrfname";
            this.txtPrfname.Size = new System.Drawing.Size(108, 20);
            this.txtPrfname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "N.I.C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID  :";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(255, 29);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(35, 13);
            this.lblPID.TabIndex = 1;
            this.lblPID.Text = "label1";
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.AllowUserToAddRows = false;
            this.dgvProfessors.AllowUserToDeleteRows = false;
            this.dgvProfessors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Location = new System.Drawing.Point(6, 19);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.ReadOnly = true;
            this.dgvProfessors.RowHeadersVisible = false;
            this.dgvProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessors.Size = new System.Drawing.Size(175, 247);
            this.dgvProfessors.TabIndex = 0;
            this.dgvProfessors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessors_CellClick);
            // 
            // txtCrName
            // 
            this.txtCrName.BackColor = System.Drawing.Color.Silver;
            this.txtCrName.Controls.Add(this.btnSearchCourse);
            this.txtCrName.Controls.Add(this.txtCoSearch);
            this.txtCrName.Controls.Add(this.numCoDur);
            this.txtCrName.Controls.Add(this.txtCoName);
            this.txtCrName.Controls.Add(this.numCoFee);
            this.txtCrName.Controls.Add(this.dgvCourses);
            this.txtCrName.Controls.Add(this.btnCoClear);
            this.txtCrName.Controls.Add(this.btnCoNew);
            this.txtCrName.Controls.Add(this.label18);
            this.txtCrName.Controls.Add(this.label15);
            this.txtCrName.Controls.Add(this.label17);
            this.txtCrName.Controls.Add(this.btnCoSave);
            this.txtCrName.Controls.Add(this.label16);
            this.txtCrName.Controls.Add(this.lblCoId);
            this.txtCrName.Location = new System.Drawing.Point(4, 22);
            this.txtCrName.Name = "txtCrName";
            this.txtCrName.Padding = new System.Windows.Forms.Padding(3);
            this.txtCrName.Size = new System.Drawing.Size(750, 314);
            this.txtCrName.TabIndex = 1;
            this.txtCrName.Text = "Courses";
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(328, 19);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(72, 26);
            this.btnSearchCourse.TabIndex = 19;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // txtCoSearch
            // 
            this.txtCoSearch.Location = new System.Drawing.Point(6, 22);
            this.txtCoSearch.Name = "txtCoSearch";
            this.txtCoSearch.Size = new System.Drawing.Size(316, 20);
            this.txtCoSearch.TabIndex = 18;
            // 
            // numCoDur
            // 
            this.numCoDur.Enabled = false;
            this.numCoDur.Location = new System.Drawing.Point(515, 128);
            this.numCoDur.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCoDur.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCoDur.Name = "numCoDur";
            this.numCoDur.Size = new System.Drawing.Size(50, 20);
            this.numCoDur.TabIndex = 17;
            this.numCoDur.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtCoName
            // 
            this.txtCoName.Enabled = false;
            this.txtCoName.Location = new System.Drawing.Point(515, 88);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(215, 20);
            this.txtCoName.TabIndex = 7;
            // 
            // numCoFee
            // 
            this.numCoFee.DecimalPlaces = 2;
            this.numCoFee.Enabled = false;
            this.numCoFee.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCoFee.Location = new System.Drawing.Point(515, 175);
            this.numCoFee.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numCoFee.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCoFee.Name = "numCoFee";
            this.numCoFee.Size = new System.Drawing.Size(98, 20);
            this.numCoFee.TabIndex = 16;
            this.numCoFee.ThousandsSeparator = true;
            this.numCoFee.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(6, 51);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(394, 257);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.Click += new System.EventHandler(this.dgvCourses_Click);
            // 
            // btnCoClear
            // 
            this.btnCoClear.Enabled = false;
            this.btnCoClear.Location = new System.Drawing.Point(635, 238);
            this.btnCoClear.Name = "btnCoClear";
            this.btnCoClear.Size = new System.Drawing.Size(50, 30);
            this.btnCoClear.TabIndex = 15;
            this.btnCoClear.Text = "Clear";
            this.btnCoClear.UseVisualStyleBackColor = true;
            this.btnCoClear.Click += new System.EventHandler(this.btnCoClear_Click);
            // 
            // btnCoNew
            // 
            this.btnCoNew.Location = new System.Drawing.Point(515, 238);
            this.btnCoNew.Name = "btnCoNew";
            this.btnCoNew.Size = new System.Drawing.Size(50, 30);
            this.btnCoNew.TabIndex = 13;
            this.btnCoNew.Text = "New";
            this.btnCoNew.UseVisualStyleBackColor = true;
            this.btnCoNew.Click += new System.EventHandler(this.btnCoNew_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(417, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "ID  :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(417, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Course Fee";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(417, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Course Name";
            // 
            // btnCoSave
            // 
            this.btnCoSave.Enabled = false;
            this.btnCoSave.Location = new System.Drawing.Point(575, 238);
            this.btnCoSave.Name = "btnCoSave";
            this.btnCoSave.Size = new System.Drawing.Size(50, 30);
            this.btnCoSave.TabIndex = 14;
            this.btnCoSave.Text = "Save";
            this.btnCoSave.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(417, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Duration (Months)";
            // 
            // lblCoId
            // 
            this.lblCoId.AutoSize = true;
            this.lblCoId.Location = new System.Drawing.Point(512, 51);
            this.lblCoId.Name = "lblCoId";
            this.lblCoId.Size = new System.Drawing.Size(35, 13);
            this.lblCoId.TabIndex = 1;
            this.lblCoId.Text = "label1";
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(697, 3);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(61, 30);
            this.btnLogoff.TabIndex = 1;
            this.btnLogoff.Text = "Log Off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.dgvRegPayment);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 314);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Payments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Student Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Student Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(86, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Student Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(86, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "ST";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Amount";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dgvRegPayment
            // 
            this.dgvRegPayment.AllowUserToAddRows = false;
            this.dgvRegPayment.AllowUserToDeleteRows = false;
            this.dgvRegPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegPayment.Location = new System.Drawing.Point(11, 109);
            this.dgvRegPayment.Name = "dgvRegPayment";
            this.dgvRegPayment.RowHeadersVisible = false;
            this.dgvRegPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegPayment.Size = new System.Drawing.Size(347, 146);
            this.dgvRegPayment.TabIndex = 7;
            // 
            // frm_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Registrar";
            this.Load += new System.EventHandler(this.frm_Reg_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.txtCrName.ResumeLayout(false);
            this.txtCrName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoDur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage txtCrName;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProfessors;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtPrcontact;
        private System.Windows.Forms.TextBox txtPrnic;
        private System.Windows.Forms.TextBox txtPrlname;
        private System.Windows.Forms.TextBox txtPrfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrClear;
        private System.Windows.Forms.Button btnPrSave;
        private System.Windows.Forms.Button btnPrAdd;
        private System.Windows.Forms.TextBox txtPrpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStClear;
        private System.Windows.Forms.Button btnStSave;
        private System.Windows.Forms.Button btnStNew;
        private System.Windows.Forms.TextBox txtStPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStcont;
        private System.Windows.Forms.TextBox txtStnic;
        private System.Windows.Forms.TextBox txtStlname;
        private System.Windows.Forms.TextBox txtStfname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.NumericUpDown numCoDur;
        private System.Windows.Forms.NumericUpDown numCoFee;
        private System.Windows.Forms.Button btnCoClear;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCoId;
        private System.Windows.Forms.Button btnCoSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCoNew;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtCoSearch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRegPayment;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}