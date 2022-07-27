using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LayeredArchitecture.PersistenceLayer
{
    internal static class DBConnectionHelper
    {
        private static SqlConnection con;
        public static SqlConnection CreateSqlConnection()
        {
            string ConnectionString = "Server=localhost;Initial Catalog=LayeredArchitecture;Integrated Security=true";
            con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }

        public static SqlConnection GetSqlConnection()
        {
            return con;
        }
        public static void CloseSqlConnection()
        {
            con.Close();
        }
    }
}
