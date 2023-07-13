using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public int ManagerId { get; set; }

        //Get All Department
        public List<Department> GetAll()
        {
            var connection = Connection.Get();

            var departments = new List<Department>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM departments";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Department department = new Department();
                            department.Id = reader.GetInt32(i: 0);
                            department.Name = reader.GetString(i: 1);
                            department.LocationId = reader.GetInt32(i: 2);
                            department.ManagerId = reader.GetInt32(i: 3);
                            
                            departments.Add(department);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                     }
                    return departments;
                
            }
            catch
            {
                return new List<Department>();
            }
        }

        //Insert Deparment
        public int Insert(Department department)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO departments VALUES (@id_department, @nama, @id_location, @id_manager)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = department.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = department.Name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdLoc = new SqlParameter();
                pIdLoc.ParameterName = "@id_location";
                pIdLoc.SqlDbType = System.Data.SqlDbType.Int;
                pIdLoc.Value = department.LocationId;
                sqlCommand.Parameters.Add(pIdLoc);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = department.ManagerId;
                sqlCommand.Parameters.Add(pIdMan);



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

        //Update Deparment
        public int Update(Department department)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE departments SET name = (@nama), location_id = (@id_location), manager_id = (@id_manager) WHERE id = (@id_department)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = department.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = department.Name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdLoc = new SqlParameter();
                pIdLoc.ParameterName = "@id_location";
                pIdLoc.SqlDbType = System.Data.SqlDbType.Int;
                pIdLoc.Value = department.LocationId;
                sqlCommand.Parameters.Add(pIdLoc);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = department.ManagerId;
                sqlCommand.Parameters.Add(pIdMan);



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

        //Delete Deparment
        public int Delete(int id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM departments WHERE id = (@id_department)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
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

        //Get By Id
        public Department GetById(int id)
        {
            var connection = Connection.Get();

            var departments = new List<Department>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM departments WHERE id = '" + id + "'";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    
                        Department department = new Department();
                        department.Id = reader.GetInt32(i: 0);
                        department.Name = reader.GetString(i: 1);
                        department.LocationId = reader.GetInt32(i: 2);
                        department.ManagerId = reader.GetInt32(i: 3);     
                }
                else
                {
                    reader.Close();
                    connection.Close();
                }
                return new Department();

            }
            catch
            {
                return new Department();
            }
        }
    }
}
