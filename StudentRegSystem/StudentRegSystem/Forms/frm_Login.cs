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

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUdbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sUdbDataSet.Users);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = cmbUser.Text;
            string pass = txtPass.Text;
            string q = "SELECT * FROM Users WHERE username = '"+uname+"';";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if(dr.GetString(2) == pass)
                    {
                        MessageBox.Show(uname + " Logged in Successfully!");
                        txtPass.Text = "";
                        this.Hide();
                        Forms.frm_Main m = new frm_Main();
                        m.uAccess = dr.GetInt32(3);
                        m.loginForm = this;
                        m.currentuser = uname;
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username and/or Password is incorrect!");
                        txtPass.Focus();
                        txtPass.SelectAll();
                    }
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
    }
}
