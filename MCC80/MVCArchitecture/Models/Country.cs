using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

        //Get All Country
        public List<Country> GetAll()
        {
            var connection = Connection.Get();

            var countries = new List<Country>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM countries";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Country country = new Country();
                            country.Id = reader.GetString(i: 0);
                            country.Name = reader.GetString(i: 1);
                            country.RegionId = reader.GetInt32(i: 2);
                            countries.Add(country);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                    return countries;
            }
            catch
            {
                return new List<Country>();
            }
        }

        //Insert Country
        public int Insert(Country country)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO countries VALUES (@id_country, @nama_country, @id_region)";

            connection.Open();
            using SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = country.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama_country";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = country.Name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdReg = new SqlParameter();
                pIdReg.ParameterName = "@id_region";
                pIdReg.SqlDbType = System.Data.SqlDbType.Int;
                pIdReg.Value = country.RegionId;
                sqlCommand.Parameters.Add(pIdReg);


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

        //Update Country
        public int Update(Country country)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE countries SET name = (@nama_country), region_id = (@id_region) WHERE id = (@id_country) ";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = country.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama_country";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = country.Name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdReg = new SqlParameter();
                pIdReg.ParameterName = "@id_region";
                pIdReg.SqlDbType = System.Data.SqlDbType.Int;
                pIdReg.Value = country.RegionId;
                sqlCommand.Parameters.Add(pIdReg);


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

        //Delete Country
        public int Delete(string id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM countries WHERE id = (@id_country)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
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

        //Get All Country
        public Country GetById(string id)
        {
            var connection = Connection.Get();

            var country = new Country();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM countries WHERE id = '" + id + "'";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                            reader.Read();
                            
                            country.Id = reader.GetString(0);
                            country.Name = reader.GetString(1);
                            country.RegionId = reader.GetInt32(2);
                        
                    }
                    
                        reader.Close();
                        connection.Close();

                return country;
            }
            catch
            {
                return new Country();
            }
        }


    }
}
