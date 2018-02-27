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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.txtCoSearch = new System.Windows.Forms.TextBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchCourse);
            this.groupBox3.Controls.Add(this.txtCoSearch);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.dgvCourses);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 302);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Courses";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(101, 231);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(232, 232);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "ID  :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Course Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Duration (Months)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "label1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(162, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Course Fee";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(6, 45);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(394, 139);
            this.dgvCourses.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 20);
            this.textBox5.TabIndex = 7;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(697, 3);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(61, 31);
            this.btnLogoff.TabIndex = 1;
            this.btnLogoff.Text = "Log Off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // txtCoSearch
            // 
            this.txtCoSearch.Location = new System.Drawing.Point(6, 19);
            this.txtCoSearch.Name = "txtCoSearch";
            this.txtCoSearch.Size = new System.Drawing.Size(316, 20);
            this.txtCoSearch.TabIndex = 18;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(328, 19);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(72, 20);
            this.btnSearchCourse.TabIndex = 19;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            // 
            // frm_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 359);
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
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.TextBox txtCoSearch;
    }
}