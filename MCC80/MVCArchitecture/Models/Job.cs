using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }


        //Get All Jobs
        public List<Job> GetAll()
        {
            var connection = Connection.Get();
            var jobs = new List<Job>();   

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM jobs";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.Id = reader.GetString(i: 0);
                            job.Title = reader.GetString(i: 1);
                            job.MinSalary = reader.GetInt32(i: 2);
                            job.MaxSalary = reader.GetInt32(i: 3);

                            jobs.Add(job);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                    
                return jobs;
            }
            catch
            {
                return new List<Job>();
            }
        }

        //Insert Jobs
        public int Insert(Job job)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO jobs VALUES (@id_jobs, @n_title, @min_s, @max_s)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = job.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@n_title";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = job.Title;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pMin = new SqlParameter();
                pMin.ParameterName = "@min_s";
                pMin.SqlDbType = System.Data.SqlDbType.Int;
                pMin.Value = job.MinSalary;
                sqlCommand.Parameters.Add(pMin);

                SqlParameter pMax = new SqlParameter();
                pMax.ParameterName = "@max_s";
                pMax.SqlDbType = System.Data.SqlDbType.Int;
                pMax.Value = job.MaxSalary;
                sqlCommand.Parameters.Add(pMax);

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

        //Update Jobs
        public int Update(Job job)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE jobs SET title = (@n_title), min_salary = (@min_s), max_salary = (@max_s) WHERE id = (@id_jobs)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = job.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@n_title";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = job.Title;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pMin = new SqlParameter();
                pMin.ParameterName = "@min_s";
                pMin.SqlDbType = System.Data.SqlDbType.Int;
                pMin.Value = job.MinSalary;
                sqlCommand.Parameters.Add(pMin);

                SqlParameter pMax = new SqlParameter();
                pMax.ParameterName = "@max_s";
                pMax.SqlDbType = System.Data.SqlDbType.Int;
                pMax.Value = job.MaxSalary;
                sqlCommand.Parameters.Add(pMax);

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

        //Delete Jobs
        public int Delete(string id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM jobs WHERE id = (@id_jobs)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

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

        //Get By Id Jobs
        public Job GetById(string id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM Jobs WHERE id = '" + id + "'";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())

                    if (reader.HasRows)
                    {
                        
                            Job job = new Job();
                            job.Id = reader.GetString(i: 0);
                            job.Title = reader.GetString(i: 1);
                            job.MinSalary = reader.GetInt32(i: 2);
                            job.MaxSalary = reader.GetInt32(i: 3);

                        
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }

                return new Job();
            }
            catch
            {
                return new Job();
            }
        }
    }
}
