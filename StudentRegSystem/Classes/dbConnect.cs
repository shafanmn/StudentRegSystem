using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegSystem.Classes
{
    class dbConnect
    {
        private static SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\StudentRegSystem\\StudentRegSystem\\SUdb.mdf;MultipleActiveResultSets=true;Integrated Security = True");
        public static SqlConnection getConnection()
        {
            return conn;
        }
    }
}
