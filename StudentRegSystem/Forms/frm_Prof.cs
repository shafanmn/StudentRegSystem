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

                fun.executeQuery("UPDATE Users SET contact='" + cont + "', password='" + pass + "' WHERE Id='" + this.profId + "';");

                txtPrCont.Enabled = false;
                txtPrpass.Enabled = false;
                btnPrEditPr.Text = "Edit";

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                //Load Search Courses
                fun.LoadToDatagridview(dgvPrSearch, "SELECT Id 'ID', name 'Course Name' FROM Course WHERE Id NOT IN (SELECT courseId FROM Teaching);");
                dgvPrSearch.Columns[0].Width = 40;

                //Load Teaching Courses
                fun.LoadToDatagridview(dgvPrTeach, "select c.Id 'ID', c.name 'Course Name' from Teaching t, Course c, Users u WHERE t.courseId = c.Id and t.professorId = u.Id and u.Id = '"+this.profId+"';");
                dgvPrTeach.Columns[0].Width = 40;
            }
        }

        private void txtPrSch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtPrSch.Text;
            fun.LoadToDatagridview(dgvPrSearch, "SELECT Id 'ID', name 'Course Name' From Course WHERE Id like '%"+txt+"%' OR name like '%"+txt+"%';");
            dgvPrSearch.Columns[0].Width = 40;
        }
                
        private void dgvPrTeach_MouseClick(object sender, MouseEventArgs e)
        {
            string cid = dgvPrTeach.SelectedCells[0].Value.ToString();
            //Get Course Details
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = fun.getDetails("SELECT * FROM Course WHERE Id = '" + cid + "'");
            while (dr.Read())
            {
                lblTecId.Text = dr[0].ToString();
                lblTecName.Text = dr[1].ToString();
            }
            conn.Close();
            btnPrRemove.Enabled = true;
        }

        private void dgvPrSearch_MouseClick(object sender, MouseEventArgs e)
        {
            string cid = dgvPrSearch.SelectedCells[0].Value.ToString();
            //Get Course Details
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = fun.getDetails("SELECT * FROM Course WHERE Id = '" + cid + "'");
            while (dr.Read())
            {
                lblSerId.Text = dr[0].ToString();
                lblSerName.Text = dr[1].ToString();
            }
            conn.Close();
            btnPrTeach.Enabled = true;
        }

        private void btnPrTeach_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Are you sure you want to teach\n" + lblSerId.Text + " - " + lblSerName.Text,"Confirm",MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                string cid = lblSerId.Text;
                fun.executeQuery("INSERT INTO Teaching(professorId,courseId) VALUES('"+this.profId+"','"+cid+"');");
                tabControl1_SelectedIndexChanged(sender, e);
                lblSerId.Text = "ID";
                lblSerName.Text = "Course Name";
                btnPrTeach.Enabled = false;
            }
        }

        private void btnPrRemove_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to Remove\n" + lblTecId.Text + " - " + lblTecName.Text +" From your teaching list?", "Confirm", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                string cid = lblTecId.Text;
                fun.executeQuery("DELETE FROM Teaching WHERE courseId = '"+cid+"';");
                tabControl1_SelectedIndexChanged(sender, e);
                lblTecId.Text = "ID";
                lblTecName.Text = "Course Name";
                btnPrRemove.Enabled = false;
            }
        }
    }
}
