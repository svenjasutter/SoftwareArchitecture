using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LayeredArchitecture.PersistenceLayer
{
    internal class TaskHelper
    {
        public void GetTasks()
        {
            SqlCommand cmd = new SqlCommand("select * from LayeredArchitecture..Task");
            cmd.Connection = DBConnectionHelper.GetSqlConnection();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Data from Reader:");
                Console.WriteLine(String.Format("{0}", reader[0]));
            }
        }
    }
}
