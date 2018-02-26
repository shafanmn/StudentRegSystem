using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace StudentRegSystem.Classes
{
    class functions
    {

        public string getNextStudentId(SqlConnection conn)
        {
            string next = "ST";
            string q = "SELECT RIGHT(CONCAT('000',SUBSTRING(Id,3,3)+1),3) FROM Users WHERE Id like 'ST%' ORDER BY Id DESC;";
            SqlCommand cmd = new SqlCommand(q, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    next += dr.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return next;
        }

        public string getNextProfessorId(SqlConnection conn)
        {
            string next = "PR";
            string q = "SELECT RIGHT(CONCAT('000',SUBSTRING(Id,3,3)+1),3) FROM Users WHERE Id like 'PR%' ORDER BY Id DESC;";
            SqlCommand cmd = new SqlCommand(q, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    next += dr.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return next;
        }

        public void LoadToDatagridview(DataGridView dgv, string q)
        {
            SqlConnection c = dbConnect.getConnection();
            var dataAdapter = new SqlDataAdapter(q, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv.ReadOnly = true;
            dgv.DataSource = ds.Tables[0];
        }

    }//End of Class
}
