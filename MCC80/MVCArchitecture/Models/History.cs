using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class History
    {
        public DateTime StartDate { get; set; }
        public int EmployeeId { get; set; }
        public DateTime EndDate { get; set; }
        public int DepartmentId { get; set; }
        public string JobId { get; set; }


        //Get All History
        public List<History> GetAll()
        {
            var connection = Connection.Get();

            var histories = new List<History>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM histories";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            History history = new History();
                            history.StartDate = reader.GetDateTime(i: 0);
                            history.EmployeeId = reader.GetInt32(i: 1);
                            history.EndDate = reader.GetDateTime(i: 2);
                            history.DepartmentId = reader.GetInt32(i: 3);
                            history.JobId = reader.GetString(i: 4);

                            histories.Add(history);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }

                return histories;
                
            }
            catch
            {
                return new List<History>();
            }
        }

        // Insert History
        public int Insert (History history)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO histories VALUES (@start_d, @id_employee, @end_d, @id_department, @id_job)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pStartD = new SqlParameter();
                pStartD.ParameterName = "@start_d";
                pStartD.SqlDbType = System.Data.SqlDbType.VarChar;
                pStartD.Value = history.StartDate;
                sqlCommand.Parameters.Add(pStartD);

                SqlParameter pIdEm = new SqlParameter();
                pIdEm.ParameterName = "@id_employee";
                pIdEm.SqlDbType = System.Data.SqlDbType.Int;
                pIdEm.Value = history.EmployeeId;
                sqlCommand.Parameters.Add(pIdEm);

                SqlParameter pEndD = new SqlParameter();
                pEndD.ParameterName = "@end_d";
                pEndD.SqlDbType = System.Data.SqlDbType.VarChar;
                pEndD.Value = history.EndDate;
                sqlCommand.Parameters.Add(pEndD);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = history.DepartmentId;
                sqlCommand.Parameters.Add(pIdDep);

                SqlParameter pIdJob = new SqlParameter();
                pIdJob.ParameterName = "@id_job";
                pIdJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdJob.Value = history.JobId;
                sqlCommand.Parameters.Add(pIdJob);


                int result = sqlCommand.ExecuteNonQuery();
                
                transaction.Commit();
                connection.Close();

                return result;
            }
            catch
            {
                transaction.Rollback();
                return -1;
            }
        }

        //Update History
        public int Update(History history)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE histories SET end_date = (@end_d), department_id = (@id_department), " +
                "job_id = (@id_job) WHERE employee_id = (@id_employee) AND start_date = (@start_d)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pStartD = new SqlParameter();
                pStartD.ParameterName = "@start_d";
                pStartD.SqlDbType = System.Data.SqlDbType.VarChar;
                pStartD.Value = history.StartDate;
                sqlCommand.Parameters.Add(pStartD);

                SqlParameter pIdEm = new SqlParameter();
                pIdEm.ParameterName = "@id_employee";
                pIdEm.SqlDbType = System.Data.SqlDbType.Int;
                pIdEm.Value = history.EmployeeId;
                sqlCommand.Parameters.Add(pIdEm);

                SqlParameter pEndD = new SqlParameter();
                pEndD.ParameterName = "@end_d";
                pEndD.SqlDbType = System.Data.SqlDbType.VarChar;
                pEndD.Value = history.EndDate;
                sqlCommand.Parameters.Add(pEndD);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = history.DepartmentId;
                sqlCommand.Parameters.Add(pIdDep);

                SqlParameter pIdJob = new SqlParameter();
                pIdJob.ParameterName = "@id_job";
                pIdJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdJob.Value = history.JobId;
                sqlCommand.Parameters.Add(pIdJob);


                int result = sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                return result;
            }
            catch
            {
                transaction.Rollback();
                return -1;
            }
        }

        //Delete History
        public int Delete(string start_date, int employee_id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM histories WHERE employee_id = (@id_employee) AND start_date = (@start_d)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pStartD = new SqlParameter();
                pStartD.ParameterName = "@start_d";
                pStartD.SqlDbType = System.Data.SqlDbType.VarChar;
                pStartD.Value = start_date;
                sqlCommand.Parameters.Add(pStartD);

                SqlParameter pIdEm = new SqlParameter();
                pIdEm.ParameterName = "@id_employee";
                pIdEm.SqlDbType = System.Data.SqlDbType.Int;
                pIdEm.Value = employee_id;
                sqlCommand.Parameters.Add(pIdEm);


                int result = sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                connection.Close();

                return result;
            }
            catch
            {
                transaction.Rollback();
                return -1;
            }
        }

        //Get By Id History
        public History GetById(int employee_id)
        {
            var connection = Connection.Get();

            var history = new History();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM histories WHERE employee_id = '" + employee_id + "'";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {                   
                            reader.Read();
                            history.StartDate = reader.GetDateTime(0);
                            history.EmployeeId = reader.GetInt32(1);
                            history.EndDate = reader.GetDateTime(2);
                            history.DepartmentId = reader.GetInt32(3);
                            history.JobId = reader.GetString(4);
                    }
                    
                        reader.Close();
                        connection.Close();
                    

                return history;

            }
            catch
            {
                return new History();
            }
        }


    }
}
