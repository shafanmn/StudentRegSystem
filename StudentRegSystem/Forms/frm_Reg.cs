using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegSystem.Forms
{
    public partial class frm_Reg : Form
    {

        public Form loginForm;
        Classes.functions fun = new Classes.functions();
        SqlConnection conn = Classes.dbConnect.getConnection();

        public frm_Reg()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void frm_Reg_Load(object sender, EventArgs e)
        {
            
            //Load Professors DGV
            fun.LoadToDatagridview(dgvProfessors, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 2;");

            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            lblPID.Text = fun.getNextProfessorId(this.conn);
        }

        private void btnPrClear_Click(object sender, EventArgs e)
        {
            lblPID.Text = fun.getNextProfessorId(this.conn);
            txtPrfname.Clear();
            txtPrlname.Clear();
            txtPrnic.Clear();
            txtPrpass.Clear();
            txtPrcontact.Clear();
            txtPrfname.Focus();
        }
    }
}
