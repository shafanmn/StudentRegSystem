using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegSystem.Classes;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StudentRegSystem.Forms
{
    public partial class frm_Student : Form
    {
        public string studentId = null;
        public Form loginForm;
        SqlConnection conn = dbConnect.getConnection();
        Classes.functions fun = new Classes.functions();
        public frm_Student()
        {
            InitializeComponent();
        }

        private void frm_Student_Load(object sender, EventArgs e)
        {
            this.Text += this.studentId + " Logged In";

            //Get Student Details
            if(conn.State == ConnectionState.Closed)
                conn.Open();   
            SqlDataReader dr =  fun.getDetails("SELECT * FROM Users WHERE Id = '" + this.studentId + "'");
            lblStId.Text = this.studentId;
            while (dr.Read())
            {
                lblStName.Text = dr[3].ToString() + " "+ dr[4].ToString();
                lblStnic.Text = dr[5].ToString();
                txtStCont.Text = dr[6].ToString();
                txtStpass.Text = dr[1].ToString();
            }
            conn.Close();

            //Get Pending Amount                
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dr = fun.getDetails("SELECT CONVERT(varchar,CAST(SUM(balance) AS Money),1) FROM Enroll WHERE studentId = '" + this.studentId + "';");
            while (dr.Read())
                lblStPending.Text = dr[0].ToString();

            /* Alternate Method to get pendig amount
            double totPending = 0;
            for (int i = 0; i < dgvStPayPending.RowCount; i++)
                totPending += Convert.ToDouble(dgvStPayPending.Rows[i].Cells[3].Value);
            lblStPending.Text = totPending.ToString();
            */

            //Load Enroleld Table
            fun.LoadToDatagridview(dgvStEnrolled, "SELECT c.Id 'ID', c.name 'Name', c.duration 'Months' FROM Enroll e, Course c WHERE c.Id = e.courseId AND e.studentId = '" + this.studentId + "' AND e.balance = 0");
            dgvStEnrolled.Columns[0].Width = 40;
            dgvStEnrolled.Columns[2].Width = 40;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnStEditPr_Click(object sender, EventArgs e)
        {
            if(btnStEditPr.Text == "Edit")
            {
                txtStCont.Enabled = true;
                txtStpass.Enabled = true;
                btnStEditPr.Text = "Save";
            }
            else
            {
                string cont = txtStCont.Text;
                string pass = txtStpass.Text;

                fun.executeQuery("UPDATE Users SET contact='" + cont + "', password='" + pass + "' WHERE Id='"+this.studentId+"';");

                txtStCont.Enabled = false;
                txtStpass.Enabled = false;
                btnStEditPr.Text = "Edit";

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1) //Enroll Tab
            {
                //Load Search Courses
                fun.LoadToDatagridview(dgvStSearch, "SELECT c.Id 'ID', c.name 'Course Name' FROM Course c WHERE c.Id NOT IN (SELECT courseId FROM Enroll WHERE studentId = '"+this.studentId+"');");
                dgvStSearch.Columns[0].Width = 40;
                //Load Payment Pending Table
                fun.LoadToDatagridview(dgvStPayPending, "SELECT c.Id 'ID', c.name 'Name', CONVERT(varchar,CAST(c.fee AS money),1) 'Amount', CONVERT(varchar,CAST(e.balance AS money),1) 'Pending' FROm Enroll e, Course c WHERE c.Id = e.courseId AND e.studentId = '"+this.studentId+"' AND e.balance > 0");
                dgvStPayPending.Columns[0].Width = 40;
                dgvStPayPending.Columns[2].Width = 70;
                dgvStPayPending.Columns[3].Width = 70;
                
                
            }else if(tabControl1.SelectedIndex == 0)
            {
                //Get Student Details
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataReader dr = fun.getDetails("SELECT * FROM Users WHERE Id = '" + this.studentId + "'");
                lblStId.Text = this.studentId;
                while (dr.Read())
                {
                    lblStName.Text = dr[3].ToString() + " " + dr[4].ToString();
                    lblStnic.Text = dr[5].ToString();
                    txtStCont.Text = dr[6].ToString();
                    txtStpass.Text = dr[1].ToString();
                }
                conn.Close();

                //Get Pending Amount                
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                dr = fun.getDetails("SELECT CONVERT(varchar,CAST(SUM(balance) AS Money),1) FROM Enroll WHERE studentId = '" + this.studentId + "';");
                while (dr.Read())
                    lblStPending.Text = dr[0].ToString();

                /* Alternate Method to get pendig amount
                double totPending = 0;
                for (int i = 0; i < dgvStPayPending.RowCount; i++)
                    totPending += Convert.ToDouble(dgvStPayPending.Rows[i].Cells[3].Value);
                lblStPending.Text = totPending.ToString();
                */

                //Load Enroleld Table
                fun.LoadToDatagridview(dgvStEnrolled, "SELECT c.Id 'ID', c.name 'Name', c.duration 'Months' FROM Enroll e, Course c WHERE c.Id = e.courseId AND e.studentId = '" + this.studentId + "' AND e.balance = 0");
                dgvStEnrolled.Columns[0].Width = 40;
                dgvStEnrolled.Columns[2].Width = 40;
            }
        }

        private void txtStSch_TextChanged(object sender, EventArgs e)
        {
            fun.LoadToDatagridview(dgvStSearch, "SELECT c.Id 'ID', c.name 'Course Name' FROM Course c WHERE c.Id NOT IN (SELECT courseId FROM Enroll WHERE studentId = '" + this.studentId + "');");
            dgvStSearch.Columns[0].Width = 40;
        }

        private void dgvStSearch_MouseClick(object sender, MouseEventArgs e)
        {
            string cid = dgvStSearch.SelectedCells[0].Value.ToString();
            //Get Course Details
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = fun.getDetails("SELECT *, CONVERT(varchar,CAST(fee AS Money),1) FROM Course WHERE Id = '" + cid + "'");
            while (dr.Read())
            {
                lblStEnID.Text = dr[0].ToString();
                lblStEnName.Text = dr[1].ToString();
                lblStEnDuration.Text = dr[2].ToString() +" Months";
                lblStEnFee.Text = dr[4].ToString().ToString();
            }
            conn.Close();
            btnStApplyCourse.Enabled = true;
        }

        private void btnStApplyCourse_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to Apply for\n" + lblStEnID.Text + " - " + lblStEnName.Text +"?\nThe Course fee is " +lblStEnFee.Text, "Confirm", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                string cid = lblStEnID.Text;
                double amount = double.Parse(lblStEnFee.Text);
                
                fun.executeQuery("INSERT INTO Enroll(studentId,courseId,amount,balance) VALUES('" + this.studentId + "','" + cid + "',"+amount+","+amount+");");
                tabControl1_SelectedIndexChanged(sender, e);
                lblStEnID.Text = "--";
                lblStEnName.Text = "--";
                lblStEnDuration.Text = "--";
                lblStEnFee.Text = "--";
                btnStApplyCourse.Enabled = false;
                
            }
        }

        private void dgvStPayPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnStCancelApp.Enabled = true;

        }

        private void btnStCancelApp_Click(object sender, EventArgs e)
        {
            string cid = dgvStPayPending.SelectedCells[0].Value.ToString();
            string cname = dgvStPayPending.SelectedCells[1].Value.ToString();

            DialogResult rs = MessageBox.Show("Are you sure you want to cancel your application for course\n" + cid + " " + cname + "?","Confirm",MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                fun.executeQuery("DELETE FROM Enroll WHERE studentId = '" + this.studentId + "' AND courseId = '" + cid + "';");
                btnStCancelApp.Enabled = false;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }
    }//End Class
}//End Namespace
