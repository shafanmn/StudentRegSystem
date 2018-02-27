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
        public frm_Student()
        {
            InitializeComponent();
        }

        private void frm_Student_Load(object sender, EventArgs e)
        {
            this.Text += this.studentId + " Logged In";


        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
