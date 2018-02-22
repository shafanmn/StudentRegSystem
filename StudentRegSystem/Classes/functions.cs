using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRegSystem.Classes
{
    class functions
    {
        public string getNextStudentId(SqlConnection conn)
        {
            string next = null;
            string q = "SELECT RIGHT(CONCAT('000',SUBSTRING(Id,3,3)+1),3) FROM Users WHERE Id like 'ST%' ORDER BY Id DESC;";
            SqlCommand cmd = new SqlCommand(q, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    next = dr.GetString(0);
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
    }
}
