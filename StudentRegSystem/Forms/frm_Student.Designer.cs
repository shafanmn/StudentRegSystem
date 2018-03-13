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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(544, 3);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 290);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 264);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enroll";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 309);
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
    }
}