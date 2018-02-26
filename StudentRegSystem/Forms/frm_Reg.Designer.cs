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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProfessors = new System.Windows.Forms.DataGridView();
            this.lblPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrfname = new System.Windows.Forms.TextBox();
            this.txtPrlname = new System.Windows.Forms.TextBox();
            this.txtPrnic = new System.Windows.Forms.TextBox();
            this.txtPrcontact = new System.Windows.Forms.TextBox();
            this.txtPrpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrAdd = new System.Windows.Forms.Button();
            this.btnPrSave = new System.Windows.Forms.Button();
            this.btnPrClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(654, 3);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(61, 31);
            this.btnLogoff.TabIndex = 1;
            this.btnLogoff.Text = "Log Off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professors";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(379, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // dgvProfessors
            // 
            this.dgvProfessors.AllowUserToAddRows = false;
            this.dgvProfessors.AllowUserToDeleteRows = false;
            this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessors.Location = new System.Drawing.Point(6, 19);
            this.dgvProfessors.Name = "dgvProfessors";
            this.dgvProfessors.ReadOnly = true;
            this.dgvProfessors.RowHeadersVisible = false;
            this.dgvProfessors.Size = new System.Drawing.Size(175, 247);
            this.dgvProfessors.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID  :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact No";
            // 
            // txtPrfname
            // 
            this.txtPrfname.Location = new System.Drawing.Point(253, 60);
            this.txtPrfname.Name = "txtPrfname";
            this.txtPrfname.Size = new System.Drawing.Size(108, 20);
            this.txtPrfname.TabIndex = 7;
            // 
            // txtPrlname
            // 
            this.txtPrlname.Location = new System.Drawing.Point(253, 94);
            this.txtPrlname.Name = "txtPrlname";
            this.txtPrlname.Size = new System.Drawing.Size(108, 20);
            this.txtPrlname.TabIndex = 8;
            // 
            // txtPrnic
            // 
            this.txtPrnic.Location = new System.Drawing.Point(253, 128);
            this.txtPrnic.Name = "txtPrnic";
            this.txtPrnic.Size = new System.Drawing.Size(108, 20);
            this.txtPrnic.TabIndex = 9;
            // 
            // txtPrcontact
            // 
            this.txtPrcontact.Location = new System.Drawing.Point(253, 162);
            this.txtPrcontact.Name = "txtPrcontact";
            this.txtPrcontact.Size = new System.Drawing.Size(108, 20);
            this.txtPrcontact.TabIndex = 10;
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
            // btnPrAdd
            // 
            this.btnPrAdd.Location = new System.Drawing.Point(187, 243);
            this.btnPrAdd.Name = "btnPrAdd";
            this.btnPrAdd.Size = new System.Drawing.Size(50, 23);
            this.btnPrAdd.TabIndex = 13;
            this.btnPrAdd.Text = "Add";
            this.btnPrAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrSave
            // 
            this.btnPrSave.Location = new System.Drawing.Point(249, 243);
            this.btnPrSave.Name = "btnPrSave";
            this.btnPrSave.Size = new System.Drawing.Size(50, 23);
            this.btnPrSave.TabIndex = 14;
            this.btnPrSave.Text = "Save";
            this.btnPrSave.UseVisualStyleBackColor = true;
            // 
            // btnPrClear
            // 
            this.btnPrClear.Location = new System.Drawing.Point(311, 243);
            this.btnPrClear.Name = "btnPrClear";
            this.btnPrClear.Size = new System.Drawing.Size(50, 23);
            this.btnPrClear.TabIndex = 15;
            this.btnPrClear.Text = "Clear";
            this.btnPrClear.UseVisualStyleBackColor = true;
            this.btnPrClear.Click += new System.EventHandler(this.btnPrClear_Click);
            // 
            // frm_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 390);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Registrar";
            this.Load += new System.EventHandler(this.frm_Reg_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}