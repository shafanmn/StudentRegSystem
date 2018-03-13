using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentRegSystem.Classes;
using System.Windows.Forms;

namespace StudentRegSystem.Forms
{
    public partial class frm_Prof : Form
    {
        public string profId = null;
        public Form loginForm;
        SqlConnection conn = dbConnect.getConnection();
        Classes.functions fun = new Classes.functions();
        public frm_Prof()
        {
            InitializeComponent();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void frm_Prof_Load(object sender, EventArgs e)
        {
            this.Text += this.profId + " Logged In";

            //Get Student Details
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = fun.getDetails("SELECT * FROM Users WHERE Id = '" + this.profId + "'");
            lblPrId.Text = this.profId;
            while (dr.Read())
            {
                lblPrName.Text = dr[3].ToString() + " " + dr[4].ToString();
                lblPrnic.Text = dr[5].ToString();
                txtPrCont.Text = dr[6].ToString();
                txtPrpass.Text = dr[1].ToString();
            }
            conn.Close();
        }

        private void btnStEditPr_Click(object sender, EventArgs e)
        {
            if (btnPrEditPr.Text == "Edit")
            {
                txtPrCont.Enabled = true;
                txtPrpass.Enabled = true;
                btnPrEditPr.Text = "Save";
            }
            else
            {
                string cont = txtPrCont.Text;
                string pass = txtPrpass.Text;

                fun.updateTable("UPDATE Users SET contact='" + cont + "', password='" + pass + "' WHERE Id='" + this.profId + "';");

                txtPrCont.Enabled = false;
                txtPrpass.Enabled = false;
                btnPrEditPr.Text = "Edit";

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                fun.LoadToDatagridview()
            }
        }
    }
}
