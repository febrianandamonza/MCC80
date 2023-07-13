using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryId { get; set; }

        //Get All Location
        public List<Location> GetAll()
        {
            var connection = Connection.Get();

            var locations = new List<Location>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM locations";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Location location = new Location();
                            location.Id = reader.GetInt32(i: 0);
                            location.StreetAddress = reader.GetString(i: 1);
                            location.PostalCode = reader.GetString(i: 2);
                            location.City = reader.GetString(i: 3);
                            location.StateProvince = reader.GetString(i: 4);
                            location.CountryId = reader.GetString(i: 5);
                            
                            locations.Add(location);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                    
                    return locations;
                }
            }
            catch
            {
                return new List<Location>();
            }
        }

        //Insert Location
        public int Insert(Location location)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO locations VALUES (@id_locations, @street_add, @postal_c, @name_city, @state_prov, @id_countries)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = location.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pStreet = new SqlParameter();
                pStreet.ParameterName = "@street_add";
                pStreet.SqlDbType = System.Data.SqlDbType.VarChar;
                pStreet.Value = location.StreetAddress;
                sqlCommand.Parameters.Add(pStreet);

                SqlParameter pPostal = new SqlParameter();
                pPostal.ParameterName = "@postal_c";
                pPostal.SqlDbType = System.Data.SqlDbType.VarChar;
                pPostal.Value = location.PostalCode;
                sqlCommand.Parameters.Add(pPostal);

                SqlParameter pCity = new SqlParameter();
                pCity.ParameterName = "@name_city";
                pCity.SqlDbType = System.Data.SqlDbType.VarChar;
                pCity.Value = location.City;
                sqlCommand.Parameters.Add(pCity);

                SqlParameter pState = new SqlParameter();
                pState.ParameterName = "@state_prov";
                pState.SqlDbType = System.Data.SqlDbType.VarChar;
                pState.Value = location.StateProvince;
                sqlCommand.Parameters.Add(pState);

                SqlParameter pIdCoun = new SqlParameter();
                pIdCoun.ParameterName = "@id_countries";
                pIdCoun.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdCoun.Value = location.CountryId;
                sqlCommand.Parameters.Add(pIdCoun);


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

        //Update Location
        public int Update(Location location)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE locations SET street_address = (@street_add), postal_code = (@postal_c), city = (@name_city), state_province = (@state_prov), country_id = (@id_countries)  WHERE id = (@id_locations)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = location.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pStreet = new SqlParameter();
                pStreet.ParameterName = "@street_add";
                pStreet.SqlDbType = System.Data.SqlDbType.VarChar;
                pStreet.Value = location.StreetAddress;
                sqlCommand.Parameters.Add(pStreet);

                SqlParameter pPostal = new SqlParameter();
                pPostal.ParameterName = "@postal_c";
                pPostal.SqlDbType = System.Data.SqlDbType.VarChar;
                pPostal.Value = location.PostalCode;
                sqlCommand.Parameters.Add(pPostal);

                SqlParameter pCity = new SqlParameter();
                pCity.ParameterName = "@name_city";
                pCity.SqlDbType = System.Data.SqlDbType.VarChar;
                pCity.Value = location.City;
                sqlCommand.Parameters.Add(pCity);

                SqlParameter pState = new SqlParameter();
                pState.ParameterName = "@state_prov";
                pState.SqlDbType = System.Data.SqlDbType.VarChar;
                pState.Value = location.StateProvince;
                sqlCommand.Parameters.Add(pState);

                SqlParameter pIdCoun = new SqlParameter();
                pIdCoun.ParameterName = "@id_countries";
                pIdCoun.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdCoun.Value = location.CountryId;
                sqlCommand.Parameters.Add(pIdCoun);


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

        //Delete Location
        public int Delete(int id)
        {
            var connection = Connection.Get();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM locations WHERE id = (@id_locations)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
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

        //Get By Id Location
        public Location GetById(int id)
        {
            var connection = Connection.Get();

            var location = new Location();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM locations WHERE id = '" + id + "'";

            try
            {
                connection.Open();
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                {
                    if (reader.HasRows)
                    {
                            reader.Read();
                            location.Id = reader.GetInt32(0);
                            location.StreetAddress = reader.GetString(1);
                            location.PostalCode = reader.GetString(2);
                            location.City = reader.GetString(3);
                            location.StateProvince = reader.GetString(4);
                            location.CountryId = reader.GetString(5);

                    }
                    
                        reader.Close();
                        connection.Close();
                    

                    return location;
                }
            }
            catch
            {
                return new Location();
            }
        }
    }
}
