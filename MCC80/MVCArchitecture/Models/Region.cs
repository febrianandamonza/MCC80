using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Get All Region
        public List<Region> GetAll()
        {
            var connection = Connection.Get();
            var regions = new List<Region>(); 

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM regions";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Region region = new Region();
                            region.Id = reader.GetInt32(i: 0);
                            region.Name = reader.GetString(i: 1);

                            regions.Add(region);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                    
                return regions;
            }
            catch
            {
                return new List<Region>();
            }
        }

        //Insert Region
        public int Insert(Region region)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO regions VALUES (@nama)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = region.Name;
                sqlCommand.Parameters.Add(pName);

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

        //Update Region
        public int Update(Region region)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE regions SET name=(@nama) WHERE id=(@id_regions)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_regions";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = region.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = region.Name;
                sqlCommand.Parameters.Add(pName);

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

        //Delete Region
        public int Delete(int id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM Regions WHERE id=(@id_regions)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_regions";
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

        //Get By Id Region
        public Region GetById(int id)
        {

            var region = new Region();

            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM regions WHERE id ='" + id + "'";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                            region.Id = reader.GetInt32(0);
                            region.Name = reader.GetString(1);
                        
                    }
                    
                        reader.Close();
                        connection.Close();
                return region;
            }
            catch
            {
                return new Region();
            }
        }
    }
}
