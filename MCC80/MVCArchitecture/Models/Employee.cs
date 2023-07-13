using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public decimal ComissionPCT { get; set; }
        public int ManagerId { get; set; }
        public string JobId { get; set; }
        public int DepertmentId { get; set; }


        //Get All Employees
        public List<Employee> GetAll()
        {
            var connection = Connection.Get();

            var employees = new List<Employee>();

            using SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM employees";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(i: 0);
                            employee.FirstName = reader.GetString(i: 1);
                            employee.Email = reader.GetString(i: 2);
                            employee.PhoneNumber = reader.GetString(i: 3);
                            employee.HireDate = reader.GetDateTime(i: 4);
                            employee.Salary = reader.GetInt32(i: 5);
                            employee.ComissionPCT = reader.GetDecimal(i: 6);
                            employee.ManagerId = reader.GetInt32(i: 7);
                            employee.JobId = reader.GetString(i: 8);
                            employee.DepertmentId = reader.GetInt32(i: 9);
                            employee.LastName = reader.GetString(i: 10);
                            
                            employees.Add(employee);
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                    return employees;
                
            }
            catch
            {
                return  new List<Employee>();
            }
        }

        //Insert Employees
        public int Insert(Employee employee)
        {
            var connection = Connection.Get();

            using SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO employees VALUES (@id_employees, @first_nama, @n_email, @phone_num, @hire_d, @n_salary, @comission, @id_manager, @id_job, @id_department, @last_nama)";

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = employee.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pFirstName = new SqlParameter();
                pFirstName.ParameterName = "@first_nama";
                pFirstName.SqlDbType = System.Data.SqlDbType.VarChar;
                pFirstName.Value = employee.FirstName;
                sqlCommand.Parameters.Add(pFirstName);

                SqlParameter pLastName = new SqlParameter();
                pLastName.ParameterName = "@last_nama";
                pLastName.SqlDbType = System.Data.SqlDbType.VarChar;
                pLastName.Value = employee.LastName;
                sqlCommand.Parameters.Add(pLastName);

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@n_email";
                pEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                pEmail.Value = employee.Email;
                sqlCommand.Parameters.Add(pEmail);

                SqlParameter pPhone = new SqlParameter();
                pPhone.ParameterName = "@phone_num";
                pPhone.SqlDbType = System.Data.SqlDbType.VarChar;
                pPhone.Value = employee.PhoneNumber;
                sqlCommand.Parameters.Add(pPhone);

                SqlParameter pHireDate = new SqlParameter();
                pHireDate.ParameterName = "@hire_d";
                pHireDate.SqlDbType = System.Data.SqlDbType.VarChar;
                pHireDate.Value = employee.HireDate;
                sqlCommand.Parameters.Add(pHireDate);

                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@n_salary";
                pSalary.SqlDbType = System.Data.SqlDbType.Int;
                pSalary.Value = employee.Salary;
                sqlCommand.Parameters.Add(pSalary);

                SqlParameter pCom = new SqlParameter();
                pCom.ParameterName = "@comission";
                pCom.SqlDbType = System.Data.SqlDbType.Decimal;
                pCom.Value = employee.ComissionPCT;
                sqlCommand.Parameters.Add(pCom);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = employee.ManagerId;
                sqlCommand.Parameters.Add(pIdMan);

                SqlParameter pJob = new SqlParameter();
                pJob.ParameterName = "@id_job";
                pJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pJob.Value = employee.JobId;
                sqlCommand.Parameters.Add(pJob);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = employee.DepertmentId;
                sqlCommand.Parameters.Add(pIdDep);

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

        //Update Employees
        public int Update(Employee employee)
        {
            var connection = Connection.Get();

            using SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "UPDATE employees SET first_name = (@first_nama), email = (@n_email), phone_number = (@phone_num)," +
                "hire_date = (@hire_d), salary = (@n_salary), comission_pct = (@comission), manager_id = (@id_manager), job_id = (@id_job), " +
                "department_id = (@id_department), last_name = (@last_nama) WHERE id = (@id_employees)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = employee.Id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pFirstName = new SqlParameter();
                pFirstName.ParameterName = "@first_nama";
                pFirstName.SqlDbType = System.Data.SqlDbType.VarChar;
                pFirstName.Value = employee.FirstName;
                sqlCommand.Parameters.Add(pFirstName);

                SqlParameter pLastName = new SqlParameter();
                pLastName.ParameterName = "@last_nama";
                pLastName.SqlDbType = System.Data.SqlDbType.VarChar;
                pLastName.Value = employee.LastName;
                sqlCommand.Parameters.Add(pLastName);

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@n_email";
                pEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                pEmail.Value = employee.Email;
                sqlCommand.Parameters.Add(pEmail);

                SqlParameter pPhone = new SqlParameter();
                pPhone.ParameterName = "@phone_num";
                pPhone.SqlDbType = System.Data.SqlDbType.VarChar;
                pPhone.Value = employee.PhoneNumber;
                sqlCommand.Parameters.Add(pPhone);

                SqlParameter pHireDate = new SqlParameter();
                pHireDate.ParameterName = "@hire_d";
                pHireDate.SqlDbType = System.Data.SqlDbType.VarChar;
                pHireDate.Value = employee.HireDate;
                sqlCommand.Parameters.Add(pHireDate);

                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@n_salary";
                pSalary.SqlDbType = System.Data.SqlDbType.Int;
                pSalary.Value = employee.Salary;
                sqlCommand.Parameters.Add(pSalary);

                SqlParameter pCom = new SqlParameter();
                pCom.ParameterName = "@comission";
                pCom.SqlDbType = System.Data.SqlDbType.Decimal;
                pCom.Value = employee.ComissionPCT;
                sqlCommand.Parameters.Add(pCom);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = employee.ManagerId;
                sqlCommand.Parameters.Add(pIdMan);

                SqlParameter pJob = new SqlParameter();
                pJob.ParameterName = "@id_job";
                pJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pJob.Value = employee.JobId;
                sqlCommand.Parameters.Add(pJob);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = employee.DepertmentId;
                sqlCommand.Parameters.Add(pIdDep);

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

        //Delete Employees
        public int Delete(int id)
        {
            var connection = Connection.Get();

            using SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "DELETE FROM employees WHERE id = (@id_employees)";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
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

        //Get By Id Employees
        public Employee GetById(int id)
        {
            var connection = Connection.Get();

            var employee = new Employee();

            using SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT * FROM employees WHERE id = '" + id + "'";

            try
            {
                connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())

                    if (reader.HasRows)
                    {
                        
                            reader.Read();
                            employee.Id = reader.GetInt32(i: 0);
                            employee.FirstName = reader.GetString(i: 1);
                            employee.Email = reader.GetString(i: 2);
                            employee.PhoneNumber = reader.GetString(i: 3);
                            employee.HireDate = reader.GetDateTime(i: 4);
                            employee.Salary = reader.GetInt32(i: 5);
                            employee.ComissionPCT = reader.GetDecimal(i: 6);
                            employee.ManagerId = reader.GetInt32(i: 7);
                            employee.JobId = reader.GetString(i: 8);
                            employee.DepertmentId = reader.GetInt32(i: 9);
                            employee.LastName = reader.GetString(i: 10);

                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                    }
                return employee;

            }
            catch
            {
                return new Employee();
            }
        }





    }
}
