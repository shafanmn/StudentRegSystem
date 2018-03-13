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
    public partial class frm_Login : Form
    {
        SqlConnection conn = Classes.dbConnect.getConnection();
        Classes.functions func = new functions();
        string nextId = null;

        public frm_Login()
        {
            InitializeComponent();
        }

        

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //Get Next Student Id
            nextId = func.getNextStudentId(this.conn);
            //MessageBox.Show("Next Id is " + nextId);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtLogin.Text;
            string pass = txtPass.Text;
            string q = "SELECT * FROM Users WHERE Id = '"+id+"';";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if(dr.GetString(1) == pass)
                    {
                        MessageBox.Show(dr.GetString(3) + " " + dr.GetString(4) + " Logged in Successfully!");
                        txtPass.Text = "";
                        this.Hide();
                        //Show Appropriate Forms
                        int access = dr.GetInt32(2);
                        
                        switch (access)
                        {
                            case 1: Forms.frm_Reg re = new frm_Reg(); re.Show(); re.loginForm = this; break;
                            case 2: Forms.frm_Prof pr = new frm_Prof(); pr.profId = dr.GetString(0); pr.loginForm = this; pr.Show() ; break;
                            case 3: Forms.frm_Student st = new frm_Student(); st.studentId = dr.GetString(0); st.loginForm = this; st.Show(); break;
                        }

                            
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                        txtPass.Focus();
                        txtPass.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Username and/or password is incorrect!");
                    txtLogin.Select();
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfname.Select();
            txtfname.Clear();
            txtlname.Clear();
            txtnic.Clear();
            txtcont.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string nic = txtnic.Text;
            string cont = txtcont.Text;

            string q = "INSERT INTO Users(Id,password,access,fname,lname,nic,contact) "+
                       "VALUES(@id,@pass,@access,@fname,@lname,@nic,@cont);";
            SqlCommand cmd = new SqlCommand(q, conn);

            cmd.Parameters.AddWithValue("@id", nextId);
            cmd.Parameters.AddWithValue("@pass", nic);
            cmd.Parameters.AddWithValue("@access", 3);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@nic", nic);
            cmd.Parameters.AddWithValue("@cont", cont);

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Student Registered Successfully!\n Your Login Id is " + nextId + " and use your NIC as password for first login.");
                    txtLogin.Text = nextId;
                    conn.Close();
                    nextId = func.getNextStudentId(this.conn);
                    btnClear_Click(sender, e);
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
