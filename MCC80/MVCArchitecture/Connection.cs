using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVCArchitecture
{
    internal class Connection
    {
        private static string _connectionString = "Data Source=jenius;Database=db_perusahaan;Integrated Security=True;Connect Timeout=30;";

        private static SqlConnection _connection;

        public static SqlConnection Get()
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                return _connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
