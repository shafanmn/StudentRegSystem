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

                fun.updateTable("UPDATE Users SET contact='" + cont + "', password='" + pass + "' WHERE Id='"+this.studentId+"';");

                txtStCont.Enabled = false;
                txtStpass.Enabled = false;
                btnStEditPr.Text = "Edit";

            }
        }
    }//End Class
}//End Namespace
