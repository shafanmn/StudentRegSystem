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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUser.Text;
            string pass = txtPass.Text;
            string q = "SELECT * FROM Users WHERE username = '"+uname+"';";
            Form frm;

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
                        //Show Appropriate Forms
                        int access = dr.GetInt32(3);
                        
                        switch (access)
                        {
                            case 1: frm = new frm_Reg(); frm.Show(); break;
                            case 2: frm = new frm_Prof(); frm.Show(); break;
                            case 3: frm = new frm_Student(); frm.Show(); break;
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
                    txtUser.Select();
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
            txtcont.Clear();
        }
    }
}
