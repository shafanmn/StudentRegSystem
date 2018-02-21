using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegSystem.Forms
{
    public partial class frm_Main : Form
    {
        public int uAccess;
        public Form loginForm;
        public string currentuser;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            TopMost = false;

            this.Text += " : " + currentuser + " Logged In";

            //Visibility of tab pages
            if(this.uAccess == 1)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}
