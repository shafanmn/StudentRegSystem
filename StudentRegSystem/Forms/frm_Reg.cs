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
        public string nextPrId = null;
        public string nextStId = null;

        public frm_Reg()
        {
            InitializeComponent();
        }

        public void enabledProfessor(bool s)
        {
            txtPrcontact.Enabled = s;
            txtPrfname.Enabled = s;
            txtPrlname.Enabled = s;
            txtPrnic.Enabled = s;
            txtPrpass.Enabled = s;
        }

        private void enabledStudent(bool s)
        {
            txtStcont.Enabled = s;
            txtStfname.Enabled = s;
            txtStlname.Enabled = s;
            txtStnic.Enabled = s;
            txtStPass.Enabled = s;
        }

        private void enabledCourse(bool s)
        {
            txtCoName.Enabled = s;
            numCoDur.Enabled = s;
            numCoFee.Enabled = s;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void frm_Reg_Load(object sender, EventArgs e)
        {
            //Load DGVs
            fun.LoadToDatagridview(dgvProfessors, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 2;");
            fun.LoadToDatagridview(dgvStudents, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 3;");
            dgvProfessors.Columns[0].Width = 45;
            dgvStudents.Columns[0].Width = 45;

            //Get Next Student & Professor Ids
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
            this.nextPrId = fun.getNextProfessorId(this.conn);
            lblPID.Text = nextPrId;

            this.nextStId = fun.getNextStudentId(this.conn);
            lblSID.Text = nextStId;

            //Disable Student & Professor Fields
            this.enabledProfessor(false);
            this.enabledStudent(false);
        }

       

        private void btnPrClear_Click(object sender, EventArgs e)
        {
            lblPID.Text = nextPrId;
            txtPrfname.Clear();
            txtPrlname.Clear();
            txtPrnic.Clear();
            txtPrpass.Clear();
            txtPrcontact.Clear();
            txtPrfname.Focus();
            btnPrSave.Enabled = false;
        }

        private void dgvProfessors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string pid = dgvProfessors.SelectedCells[0].Value.ToString();
            btnPrSave.Enabled = true;
            enabledProfessor(true);

            string q = "SELECT * FROM Users WHERE Id = '" + pid + "';";
            SqlCommand cmd = new SqlCommand(q, this.conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lblPID.Text = dr[0].ToString();
                    txtPrpass.Text = dr[1].ToString();
                    txtPrfname.Text = dr[3].ToString();
                    txtPrlname.Text = dr[4].ToString();
                    txtPrnic.Text = dr[5].ToString();
                    txtPrcontact.Text = dr[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPrAdd_Click(object sender, EventArgs e)
        {
            if (btnPrAdd.Text == "New")
            {
                enabledProfessor(true);
                btnPrClear_Click(sender, e);
                btnPrSave.Enabled = false;
                btnPrAdd.Text = "Add";
            }
            else
            {
                string fname = txtPrfname.Text;
                string lname = txtPrlname.Text;
                string nic = txtPrnic.Text;
                string contact = txtPrcontact.Text;
                string pass = txtPrpass.Text;

                string q = "INSERT INTO Users(Id,password,access,fname,lname,nic,contact) " +
                            "VALUES(@id,@pass,@acc,@fname,@lname,@nic,@cont);";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", lblPID.Text);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@acc", "2");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@cont", contact);

                try
                {
                    conn.Open();
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Professor Details Added Successfully!");
                        btnPrClear_Click(sender, e);
                        btnPrAdd.Text = "New";
                        btnPrAdd.Enabled = true;
                        fun.LoadToDatagridview(dgvProfessors, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 2;");
                        enabledProfessor(false);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnPrSave_Click(object sender, EventArgs e)
        {
            string fname = txtPrfname.Text;
            string lname = txtPrlname.Text;
            string nic = txtPrnic.Text;
            string contact = txtPrcontact.Text;
            string pass = txtPrpass.Text;

            string q = "UPDATE Users SET password=@pass, fname=@fname, lname=@lname, nic=@nic, contact=@cont WHERE Id=@id;";

            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", lblPID.Text);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@cont", contact);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Professor Details Modified Successfully!");
                    btnPrClear_Click(sender, e);
                    btnPrSave.Enabled = false;
                    fun.LoadToDatagridview(dgvProfessors, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 2;");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnStClear_Click(object sender, EventArgs e)
        {
            lblSID.Text = nextStId;
            txtStcont.Clear();
            txtStfname.Clear();
            txtStlname.Clear();
            txtStnic.Clear();
            txtStPass.Clear();
            txtStfname.Focus();
            btnStSave.Enabled = false;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = dgvStudents.SelectedCells[0].Value.ToString();
            btnStSave.Enabled = true;
            enabledStudent(true);

            string q = "SELECT * FROM Users WHERE Id = '" + sid + "';";
            SqlCommand cmd = new SqlCommand(q, this.conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lblSID.Text = dr[0].ToString();
                    txtStPass.Text = dr[1].ToString();
                    txtStfname.Text = dr[3].ToString();
                    txtStlname.Text = dr[4].ToString();
                    txtStnic.Text = dr[5].ToString();
                    txtStcont.Text = dr[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnStNew_Click(object sender, EventArgs e)
        {
            if (btnStNew.Text == "New")
            {
                enabledStudent(true);
                btnStClear_Click(sender, e);
                btnStSave.Enabled = false;
                btnStNew.Text = "Add";
            }
            else
            {
                string fname = txtStfname.Text;
                string lname = txtStlname.Text;
                string nic = txtStnic.Text;
                string contact = txtStcont.Text;
                string pass = txtStPass.Text;

                string q = "INSERT INTO Users(Id,password,access,fname,lname,nic,contact) " +
                            "VALUES(@id,@pass,@acc,@fname,@lname,@nic,@cont);";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", lblSID.Text);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@acc", "3");
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@cont", contact);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Student Details Added Successfully!");
                        btnStClear_Click(sender, e);
                        btnStNew.Text = "New";
                        btnStNew.Enabled = true;
                        fun.LoadToDatagridview(dgvStudents, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 3;");
                        enabledStudent(false);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnStSave_Click(object sender, EventArgs e)
        {
            string fname = txtStfname.Text;
            string lname = txtStlname.Text;
            string nic = txtStnic.Text;
            string contact = txtStcont.Text;
            string pass = txtStPass.Text;

            string q = "UPDATE Users SET password=@pass, fname=@fname, lname=@lname, nic=@nic, contact=@cont WHERE Id=@id;";

            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", lblSID.Text);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@cont", contact);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Student Details Modified Successfully!");
                    btnStClear_Click(sender, e);
                    btnStSave.Enabled = false;
                    fun.LoadToDatagridview(dgvStudents, "SELECT Id AS 'ID', fname AS 'NAME' FROM Users WHERE access = 3;");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                fun.LoadToDatagridview(dgvCourses, "SELECT Id 'ID', name 'Name', duration 'Months', CONVERT(varchar,CAST(fee AS Money),1) 'Fee' FROM Course ;");
                dgvCourses.Columns[0].Width = 35;   //Id
                dgvCourses.Columns[2].Width = 25;   //Months
                dgvCourses.Columns[3].Width = 65;   //Fee
                lblCoId.Text = fun.getNextCourseId(this.conn);
            }
        }

        private void btnCoNew_Click(object sender, EventArgs e)
        {
            if(btnCoNew.Text == "New")
            {
                btnCoClear_Click(sender, e);
                enabledCourse(true);
                btnCoNew.Text = "Add";
                btnCoClear.Enabled = false;
                btnCoSave.Enabled = false;
            }
            else
            {
                string name = txtCoName.Text;
                string dur = numCoDur.Value.ToString();
                string fee = numCoFee.Value.ToString();
                string id = lblCoId.Text;

                string q = "INSERT INTO Course(Id,name,duration,fee) " +
                            "VALUES(@id,@name,@dur,@fee);";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@fee", fee);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Course Details Added Successfully!");
                        btnCoNew.Text = "New";
                        btnCoNew.Enabled = true;
                        fun.LoadToDatagridview(dgvCourses, "SELECT Id 'ID', name 'Name', duration 'Months', CONVERT(varchar,CAST(fee AS Money),1) 'Fee' FROM Course ;");
                        enabledCourse(false);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                    btnCoClear_Click(sender, e);
                }
            }
        }

        private void btnCoClear_Click(object sender, EventArgs e)
        {
            lblCoId.Text = fun.getNextCourseId(this.conn);
            txtCoName.Clear();
            numCoDur.Value = numCoDur.Minimum;
            numCoFee.Value = numCoFee.Minimum;
            txtCoName.Focus();
            btnCoSave.Enabled = false;
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            if(btnSearchCourse.Text == "Search")
            {
                btnSearchCourse.Text = "Clear";
                string key = txtCoSearch.Text;
                txtCoSearch.Enabled = false;
                string q = "SELECT Id 'ID', name 'Name', duration 'Months', CONVERT(varchar,CAST(fee AS Money),1) 'Fee' FROM Course WHERE Id like '%"+key+"%' OR name like '%"+key+"%' ;";
                fun.LoadToDatagridview(dgvCourses, q);
            }
            else
            {
                txtCoSearch.Focus();
                txtCoSearch.SelectAll();
                txtCoSearch.Clear();
                fun.LoadToDatagridview(dgvCourses, "SELECT Id 'ID', name 'Name', duration 'Months', CONVERT(varchar,CAST(fee AS Money),1) 'Fee' FROM Course ;");
                btnSearchCourse.Text = "Search";
                txtCoSearch.Enabled = true;
            }
        }

        private void dgvCourses_Click(object sender, EventArgs e)
        {
            string cid = dgvCourses.SelectedCells[0].Value.ToString();
            btnCoSave.Enabled = true;
            enabledCourse(true);

            string q = "SELECT * FROM Course WHERE Id = '" + cid + "';";
            SqlCommand cmd = new SqlCommand(q, this.conn);

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lblCoId.Text = dr[0].ToString();
                    txtCoName.Text = dr[1].ToString();
                    numCoDur.Value = Convert.ToDecimal(dr[2].ToString());
                    numCoFee.Value = Convert.ToDecimal(dr[3].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
