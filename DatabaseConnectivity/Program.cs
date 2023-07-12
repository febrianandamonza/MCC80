using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DatabaseConnectivity
{
    class Program
    {
        private static string _connectionString =
            "Data Source=jenius;" +
            "Database=db_perusahaan;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;";

        private static SqlConnection _connection;

        static void Main(string[] args)
        {
            bool exit = true;
            do
            {
                MenuUtama();
                Console.Write("Input Pilihan = ");
                int pilihan = Convert.ToInt32(Console.ReadLine());  
                    switch (pilihan)
                    {
                        case 1:
                        bool back = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Employee");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan2 = Convert.ToInt32(Console.ReadLine());
                            int id, salary, department_id;
                            string first_name, last_name, email, phone, job_id, hire_date;
                            
                            decimal comission;
                            switch (pilihan2)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("ID : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("First Name : ");
                                        first_name = Console.ReadLine();
                                        Console.Write("Last Name : ");
                                        last_name = Console.ReadLine();
                                        Console.Write("Email : ");
                                        email = Console.ReadLine();
                                        Console.Write("Phone Number : ");
                                        phone = Console.ReadLine();
                                        Console.Write("Hire Date (MM//DD/YYYY) : ");
                                        hire_date = Console.ReadLine();
                                        Console.Write("Salary : ");
                                        salary = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Comission PCT : ");
                                        comission = Convert.ToDecimal(Console.ReadLine());
                                        Console.Write("Job ID : ");
                                        job_id = Console.ReadLine();
                                        Console.Write("Department ID : ");
                                        department_id = Convert.ToInt32(Console.ReadLine());

                                        InsertEmployees(id, first_name, last_name, email, phone, hire_date, salary, comission, id, job_id, department_id);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !");
                                    }
                                   Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("First Name : ");
                                        first_name = Console.ReadLine();
                                        Console.Write("Last Name : ");
                                        last_name = Console.ReadLine();
                                        Console.Write("Email : ");
                                        email = Console.ReadLine();
                                        Console.Write("Phone Number : ");
                                        phone = Console.ReadLine();
                                        Console.Write("Hire Date (MM//DD/YYYY) : ");
                                        hire_date = Console.ReadLine();
                                        Console.Write("Salary : ");
                                        salary = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Comission PCT : ");
                                        comission = Convert.ToDecimal(Console.ReadLine());
                                        Console.Write("Job ID : ");
                                        job_id = Console.ReadLine();
                                        Console.Write("Department ID : ");
                                        department_id = Convert.ToInt32(Console.ReadLine());
                                        UpdateEmployees(id, first_name, last_name, email, phone, hire_date, salary, comission, id, job_id, department_id);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah");
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        DeleteEmployees(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        GetByIdEmployees(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Employee");
                                    GetEmployees();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                        bool back2 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Department");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan3 = Convert.ToInt32(Console.ReadLine());
                            int id, location_id, manager_id;
                            string name;
                            switch (pilihan3)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("ID : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Name : ");
                                        name = Console.ReadLine();
                                        Console.Write("Location ID : ");
                                        location_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Manager ID : ");
                                        manager_id = Convert.ToInt32(Console.ReadLine());

                                        InsertDepartment(id, name, location_id, manager_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Name : ");
                                        name = Console.ReadLine();
                                        Console.Write("Location ID : ");
                                        location_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Manager ID : ");
                                        manager_id = Convert.ToInt32(Console.ReadLine());

                                        UpdateDepartment(id, name, location_id, manager_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        DeleteDepartment(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        GetByIdDepartment(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }
                                    
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Department");
                                    GetDepartment();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back2);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 3:
                        bool back3 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Location");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan4 = Convert.ToInt32(Console.ReadLine());
                            int id;
                            string street_add, postal_c, city, state_prov,country_id;
                            switch (pilihan4)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("ID : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Street Address : ");
                                        street_add = Console.ReadLine();
                                        Console.Write("Postal Code : ");
                                        postal_c = Console.ReadLine();
                                        Console.Write("City : ");
                                        city = Console.ReadLine();
                                        Console.Write("State Province : ");
                                        state_prov = Console.ReadLine();
                                        Console.Write("Country ID : ");
                                        country_id = Console.ReadLine();

                                        InsertLocation(id, street_add,postal_c,city, state_prov, country_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Street Address : ");
                                        street_add = Console.ReadLine();
                                        Console.Write("Postal Code : ");
                                        postal_c = Console.ReadLine();
                                        Console.Write("City : ");
                                        city = Console.ReadLine();
                                        Console.Write("State Province : ");
                                        state_prov = Console.ReadLine();
                                        Console.Write("Country ID : ");
                                        country_id = Console.ReadLine();

                                        UpdateLocation(id, street_add, postal_c, city, state_prov, country_id);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        DeleteLocation(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        GetByIdLocation(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Location");
                                    GetLocation();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back3 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back3);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        bool back4 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Country");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan5 = Convert.ToInt32(Console.ReadLine());
                            int region_id;
                            string id, name;
                            switch (pilihan5)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("ID : ");
                                        id = Console.ReadLine();
                                        Console.Write("Name : ");
                                        name = Console.ReadLine();
                                        Console.Write("Region ID : ");
                                        region_id = Convert.ToInt32(Console.ReadLine());

                                        InsertCountry(id, name, region_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Console.ReadLine();
                                        Console.Write("Name : ");
                                        name = Console.ReadLine();
                                        Console.Write("Region ID : ");
                                        region_id = Convert.ToInt32(Console.ReadLine());

                                        UpdateCountry(id, name, region_id);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Console.ReadLine();
                                       DeleteCountry(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Console.ReadLine();
                                        GetByIdCountry(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Country");
                                    GetCountry();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back4 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back4);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        bool back5 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Regions");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan6 = Convert.ToInt32(Console.ReadLine());
                            int id;
                            string name;
                            switch (pilihan6)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("Name Region : ");
                                        name = Console.ReadLine();

                                        InsertRegions(name);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Name Region : ");
                                        name = Console.ReadLine();

                                        UpdateRegions(id,name);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Convert.ToInt32(Console.ReadLine());
                                        DeleteRegions(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Convert.ToInt32( Console.ReadLine());
                                        GetByIdRegions(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Region");
                                    GetRegions();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back5 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back5);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        bool back6 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table Job");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan7 = Convert.ToInt32(Console.ReadLine());
                            int min,max;
                            string id, title;
                            switch (pilihan7)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("ID : ");
                                        id = Console.ReadLine();
                                        Console.Write("Title Name : ");
                                        title = Console.ReadLine();
                                        Console.Write("Min Salary : ");
                                        min = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Max Salary : ");
                                        max = Convert.ToInt32(Console.ReadLine());

                                        InsertJobs(id, title,min,max);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Id yang ingin diupdate : ");
                                        id = Console.ReadLine();
                                        Console.Write("Title Name : ");
                                        title = Console.ReadLine();
                                        Console.Write("Min Salary : ");
                                        min = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Max Salary : ");
                                        max = Convert.ToInt32(Console.ReadLine());

                                        UpdateJobs(id, title, min, max);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Id yang ingin didelete : ");
                                        id = Console.ReadLine();
                                        DeleteJobs(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Masukkan Id : ");
                                        id = Console.ReadLine();
                                        GetByIdJobs(id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data Job");
                                    GetJobs();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back6 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back6);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case 7:
                        bool back7 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Menu Table History");
                            Console.WriteLine("          By Febri Ananda Monza");
                            Console.WriteLine("=====================================");
                            MenuCRUD();
                            Console.Write("Input Pilihan = ");
                            int pilihan8 = Convert.ToInt32(Console.ReadLine());
                            int employee_id,department_id;
                            string start_date, end_date, job_id; 
                            switch (pilihan8)
                            {
                                case 1:
                                    try
                                    {
                                        Console.WriteLine("Inputkan Data");
                                        Console.Write("Start Date : ");
                                        start_date = Console.ReadLine();
                                        Console.Write("Employee ID : ");
                                        employee_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("End Date : ");
                                        end_date = Console.ReadLine();
                                        Console.Write("Department ID : ");
                                        department_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Job ID : ");
                                        job_id = Console.ReadLine();

                                        InsertHistory(start_date, employee_id, end_date, department_id,job_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah !1");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.Write("Employee ID yang ingin diupdate: ");
                                        employee_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Start Date yang ingin diupdate : ");
                                        start_date = Console.ReadLine();
                                        Console.Write("End Date : ");
                                        end_date = Console.ReadLine();
                                        Console.Write("Department ID : ");
                                        department_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Job ID : ");
                                        job_id = Console.ReadLine();

                                        UpdateHistory(start_date, employee_id, end_date, department_id, job_id);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    try
                                    {
                                        Console.Write("Employee ID yang ingin diupdate: ");
                                        employee_id = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Start Date yang ingin diupdate : ");
                                        start_date = Console.ReadLine();
                                        DeleteHistory(start_date,employee_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    try
                                    {
                                        Console.Write("Employee ID yang ingin diupdate: ");
                                        employee_id = Convert.ToInt32(Console.ReadLine());
                                        GetByIdHistory(employee_id);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Inputan Salah!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Console.WriteLine("Show Data History");
                                    GetHistory();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    back7 = false;
                                    break;
                                default:
                                    Console.WriteLine("Pilihan tidak ada !");
                                    break;
                            }
                        } while (back7);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                            exit = false;
                            Console.WriteLine("Terima Kasih !");
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak ada !");
                            break;
                    }
                
                
            } while (exit);
            
        }

        //Menu Utama
        public static void MenuUtama()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Database Perusahaan");
            Console.WriteLine("          By Febri Ananda Monza");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Department");
            Console.WriteLine("3. Location");
            Console.WriteLine("4. Country");
            Console.WriteLine("5. Region");
            Console.WriteLine("6. Job");
            Console.WriteLine("7. History");
            Console.WriteLine("8. Exit");
        }

        public static void MenuCRUD()
        {
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Get By Id");
            Console.WriteLine("5. Get All");
            Console.WriteLine("6. Back");
        }

        /*======================================================
         * CRUD ALL TABLES FROM DB PERUSAHAAN
         */

        //Get All Region
        public static void GetRegions()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM Regions";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Nama: " + reader.GetString(i: 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No regions found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Insert Region
        public static void InsertRegions(string name)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO Regions VALUES (@nama)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Update Region (insert)
        public static void UpdateRegions(int id, string name)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE Regions SET name=(@nama) WHERE id=(@id_regions)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_regions";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Delete Region (insert)
        public static void DeleteRegions(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM Regions WHERE id=(@id_regions)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_regions";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Get by Id Region (GET)
        public static void GetByIdRegions(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM Regions WHERE id ='"+ id +"'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Nama: " + reader.GetString(i: 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No regions found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }
        
        // CRUD Table Jobs

        //Get All Jobs
        public static void GetJobs()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM jobs";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetString(i: 0));
                            Console.WriteLine("Title: " + reader.GetString(i: 1));
                            Console.WriteLine("Min Salary: " + reader.GetInt32(i: 2));
                            Console.WriteLine("Max Salary: " + reader.GetInt32(i: 3));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Jobs found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Insert Jobs
        public static void InsertJobs(string id, string title, int min, int max)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO jobs VALUES (@id_jobs, @n_title, @min_s, @max_s)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@n_title";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = title;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pMin = new SqlParameter();
                pMin.ParameterName = "@min_s";
                pMin.SqlDbType = System.Data.SqlDbType.Int;
                pMin.Value = min;
                sqlCommand.Parameters.Add(pMin);

                SqlParameter pMax = new SqlParameter();
                pMax.ParameterName = "@max_s";
                pMax.SqlDbType = System.Data.SqlDbType.Int;
                pMax.Value = max;
                sqlCommand.Parameters.Add(pMax);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Update Jobs 
        public static void UpdateJobs(string id, string title, int min, int max)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE jobs SET title = (@n_title), min_salary = (@min_s), max_salary = (@max_s) WHERE id = (@id_jobs)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@n_title";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = title;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pMin = new SqlParameter();
                pMin.ParameterName = "@min_s";
                pMin.SqlDbType = System.Data.SqlDbType.Int;
                pMin.Value = min;
                sqlCommand.Parameters.Add(pMin);

                SqlParameter pMax = new SqlParameter();
                pMax.ParameterName = "@max_s";
                pMax.SqlDbType = System.Data.SqlDbType.Int;
                pMax.Value = max;
                sqlCommand.Parameters.Add(pMax);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete Jobs
        public static void DeleteJobs(string id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM jobs WHERE id = (@id_jobs)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_jobs";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        //Get by Id Jobs
        public static void GetByIdJobs(string id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM Jobs WHERE id = '"+ id + "'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetString(i: 0));
                            Console.WriteLine("Title: " + reader.GetString(i: 1));
                            Console.WriteLine("Min Salary: " + reader.GetInt32(i: 2));
                            Console.WriteLine("Max Salary: " + reader.GetInt32(i: 3));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Jobs found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //CRUD table Countries

        //Get All Countries
        public static void GetCountry()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM countries";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetString(i: 0));
                            Console.WriteLine("Nama Country: " + reader.GetString(i: 1));
                            Console.WriteLine("ID Region: " + reader.GetInt32(i: 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Country found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Insert Country
        public static void InsertCountry(string id, string name, int id_regions)
        {
            _connection = new SqlConnection(_connectionString);
                
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO countries VALUES (@id_country, @nama_country, @id_region)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama_country";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdReg = new SqlParameter();
                pIdReg.ParameterName = "@id_region";
                pIdReg.SqlDbType = System.Data.SqlDbType.Int;
                pIdReg.Value = id_regions;
                sqlCommand.Parameters.Add(pIdReg);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }
        
        //Update Country
        public static void UpdateCountry(string id, string name, int id_regions)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE countries SET name = (@nama_country), region_id = (@id_region) WHERE id = (@id_country) ";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama_country";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdReg = new SqlParameter();
                pIdReg.ParameterName = "@id_region";
                pIdReg.SqlDbType = System.Data.SqlDbType.Int;
                pIdReg.Value = id_regions;
                sqlCommand.Parameters.Add(pIdReg);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete Country
        public static void DeleteCountry(string id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM countries WHERE id = (@id_country)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_country";
                pId.SqlDbType = System.Data.SqlDbType.VarChar;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Get Countries By ID
        public static void GetByIdCountry(string id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM countries WHERE id = '"+ id +"'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetString(i: 0));
                            Console.WriteLine("Nama Country: " + reader.GetString(i: 1));
                            Console.WriteLine("ID Region: " + reader.GetInt32(i: 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Country found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //CRUD table Locations

        //Get All Location
        public static void GetLocation()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM locations";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Street Address: " + reader.GetString(i: 1));
                            Console.WriteLine("Postal Code: " + reader.GetString(i: 2));
                            Console.WriteLine("City: " + reader.GetString(i: 3));
                            
                            Console.WriteLine("State Province: " + reader.GetValue(i: 4) as string);
                            Console.WriteLine("County Id: " + reader.GetString(i: 5));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Location found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }
        
        //Insert Location
        public static void InsertLocation(int id, string street_address, string postal_code, string city, string state_province, string id_country)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO locations VALUES (@id_locations, @street_add, @postal_c, @name_city, @state_prov, @id_countries)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pStreet = new SqlParameter();
                pStreet.ParameterName = "@street_add";
                pStreet.SqlDbType = System.Data.SqlDbType.VarChar;
                pStreet.Value = street_address;
                sqlCommand.Parameters.Add(pStreet);

                SqlParameter pPostal = new SqlParameter();
                pPostal.ParameterName = "@postal_c";
                pPostal.SqlDbType = System.Data.SqlDbType.VarChar;
                pPostal.Value = postal_code;
                sqlCommand.Parameters.Add(pPostal);

                SqlParameter pCity = new SqlParameter();
                pCity.ParameterName = "@name_city";
                pCity.SqlDbType = System.Data.SqlDbType.VarChar;
                pCity.Value = city;
                sqlCommand.Parameters.Add(pCity);

                SqlParameter pState = new SqlParameter();
                pState.ParameterName = "@state_prov";
                pState.SqlDbType = System.Data.SqlDbType.VarChar;
                pState.Value = state_province;
                sqlCommand.Parameters.Add(pState);

                SqlParameter pIdCoun = new SqlParameter();
                pIdCoun.ParameterName = "@id_countries";
                pIdCoun.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdCoun.Value = id_country;
                sqlCommand.Parameters.Add(pIdCoun);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Update Location
        public static void UpdateLocation(int id, string street_address, string postal_code, string city, string state_province, string id_country)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE locations SET street_address = (@street_add), postal_code = (@postal_c), city = (@name_city), state_province = (@state_prov), country_id = (@id_countries)  WHERE id = (@id_locations)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pStreet = new SqlParameter();
                pStreet.ParameterName = "@street_add";
                pStreet.SqlDbType = System.Data.SqlDbType.VarChar;
                pStreet.Value = street_address;
                sqlCommand.Parameters.Add(pStreet);

                SqlParameter pPostal = new SqlParameter();
                pPostal.ParameterName = "@postal_c";
                pPostal.SqlDbType = System.Data.SqlDbType.VarChar;
                pPostal.Value = postal_code;
                sqlCommand.Parameters.Add(pPostal);

                SqlParameter pCity = new SqlParameter();
                pCity.ParameterName = "@name_city";
                pCity.SqlDbType = System.Data.SqlDbType.VarChar;
                pCity.Value = city;
                sqlCommand.Parameters.Add(pCity);

                SqlParameter pState = new SqlParameter();
                pState.ParameterName = "@state_prov";
                pState.SqlDbType = System.Data.SqlDbType.VarChar;
                pState.Value = state_province;
                sqlCommand.Parameters.Add(pState);

                SqlParameter pIdCoun = new SqlParameter();
                pIdCoun.ParameterName = "@id_countries";
                pIdCoun.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdCoun.Value = id_country;
                sqlCommand.Parameters.Add(pIdCoun);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete Location
        public static void DeleteLocation(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM locations WHERE id = (@id_locations)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_locations";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Get Location By ID
        public static void GetByIdLocation(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM locations WHERE id = '" + id +"'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Street Address: " + reader.GetString(i: 1));
                            Console.WriteLine("Postal Code: " + reader.GetString(i: 2));
                            Console.WriteLine("City: " + reader.GetString(i: 3));
                            Console.WriteLine("State Province: " + reader.GetString(i: 4));
                            Console.WriteLine("County Id: " + reader.GetString(i: 5));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Location found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //CRUD table Department

        //Get All Department
        public static void GetDepartment()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM departments";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Name: " + reader.GetString(i: 1));
                            Console.WriteLine("Location ID: " + reader.GetInt32(i: 2));
                            Console.WriteLine("Manager ID: " + reader.GetInt32(i: 3));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Department found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Insert Deparment
        public static void InsertDepartment(int id, string name, int location_id, int manager_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO departments VALUES (@id_department, @nama, @id_location, @id_manager)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdLoc = new SqlParameter();
                pIdLoc.ParameterName = "@id_location";
                pIdLoc.SqlDbType = System.Data.SqlDbType.Int;
                pIdLoc.Value = location_id;
                sqlCommand.Parameters.Add(pIdLoc);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = manager_id;
                sqlCommand.Parameters.Add(pIdMan);



                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Update Deparment
        public static void UpdateDepartment(int id, string name, int location_id, int manager_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE departments SET name = (@nama), location_id = (@id_location), manager_id = (@id_manager) WHERE id = (@id_department)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@nama";
                pName.SqlDbType = System.Data.SqlDbType.VarChar;
                pName.Value = name;
                sqlCommand.Parameters.Add(pName);

                SqlParameter pIdLoc = new SqlParameter();
                pIdLoc.ParameterName = "@id_location";
                pIdLoc.SqlDbType = System.Data.SqlDbType.Int;
                pIdLoc.Value = location_id;
                sqlCommand.Parameters.Add(pIdLoc);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = manager_id;
                sqlCommand.Parameters.Add(pIdMan);



                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete Deparment
        public static void DeleteDepartment(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM departments WHERE id = (@id_department)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_department";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Get Department By Id
        public static void GetByIdDepartment(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM departments WHERE id = '"+ id + "'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Name: " + reader.GetString(i: 1));
                            Console.WriteLine("Location ID: " + reader.GetInt32(i: 2));
                            Console.WriteLine("Manager ID: " + reader.GetInt32(i: 3));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Department found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //CRUD table Employees

        //Get All Employees
        public static void GetEmployees()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM employees";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Full Name: " + reader.GetString(i: 1) + " " + reader.GetString(i: 10));
                            Console.WriteLine("Email: " + reader.GetString(i: 2));
                            Console.WriteLine("Phone Number: " + reader.GetString(i: 3));
                            Console.WriteLine("Hire Date: " + reader.GetDateTime(i: 4));
                            Console.WriteLine("Salary: " + reader.GetInt32(i: 5));
                            Console.WriteLine("Comission PCT: " + reader.GetDecimal(i: 6));
                            Console.WriteLine("Manager ID: " + reader.GetInt32(i: 7));
                            Console.WriteLine("Job ID: " + reader.GetString(i: 8));
                            Console.WriteLine("Department ID: " + reader.GetInt32(i: 9));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employees found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Insert Employees
        public static void InsertEmployees(int id, string first_name, string last_name, string email, string phone_number, String hire_date, int salary, decimal comission_pct, int manager_id, string job_id, int department_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO employees VALUES (@id_employees, @first_nama, @n_email, @phone_num, @hire_d, @n_salary, @comission, @id_manager, @id_job, @id_department, @last_nama)";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pFirstName = new SqlParameter();
                pFirstName.ParameterName = "@first_nama";
                pFirstName.SqlDbType = System.Data.SqlDbType.VarChar;
                pFirstName.Value = first_name;
                sqlCommand.Parameters.Add(pFirstName);

                SqlParameter pLastName = new SqlParameter();
                pLastName.ParameterName = "@last_nama";
                pLastName.SqlDbType = System.Data.SqlDbType.VarChar;
                pLastName.Value = last_name;
                sqlCommand.Parameters.Add(pLastName);

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@n_email";
                pEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                pEmail.Value = email;
                sqlCommand.Parameters.Add(pEmail);

                SqlParameter pPhone = new SqlParameter();
                pPhone.ParameterName = "@phone_num";
                pPhone.SqlDbType = System.Data.SqlDbType.VarChar;
                pPhone.Value = phone_number;
                sqlCommand.Parameters.Add(pPhone);

                SqlParameter pHireDate = new SqlParameter();
                pHireDate.ParameterName = "@hire_d";
                pHireDate.SqlDbType = System.Data.SqlDbType.VarChar;
                pHireDate.Value = hire_date;
                sqlCommand.Parameters.Add(pHireDate);

                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@n_salary";
                pSalary.SqlDbType = System.Data.SqlDbType.Int;
                pSalary.Value = salary;
                sqlCommand.Parameters.Add(pSalary);

                SqlParameter pCom = new SqlParameter();
                pCom.ParameterName = "@comission";
                pCom.SqlDbType = System.Data.SqlDbType.Decimal;
                pCom.Value = comission_pct;
                sqlCommand.Parameters.Add(pCom);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = manager_id;
                sqlCommand.Parameters.Add(pIdMan);

                SqlParameter pJob = new SqlParameter();
                pJob.ParameterName = "@id_job";
                pJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pJob.Value = job_id;
                sqlCommand.Parameters.Add(pJob);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = department_id;
                sqlCommand.Parameters.Add(pIdDep);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Update Employees
        public static void UpdateEmployees(int id, string first_name, string last_name, string email, string phone_number, string hire_date, int salary, decimal comission_pct, int manager_id, string job_id, int department_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE employees SET first_name (@first_nama), email = (@n_email), phone_number = (@phone_num), hire_date = (@hire_d), salary = (@n_salary), comission_pct = (@comission), manager_id = (@id_manager), job_id = (@id_job), department_id = (@id_department), last_name = (@last_nama) WHERE id = (@id_employees))";

            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                SqlParameter pFirstName = new SqlParameter();
                pFirstName.ParameterName = "@first_nama";
                pFirstName.SqlDbType = System.Data.SqlDbType.VarChar;
                pFirstName.Value = first_name;
                sqlCommand.Parameters.Add(pFirstName);

                SqlParameter pLastName = new SqlParameter();
                pLastName.ParameterName = "@last_nama";
                pLastName.SqlDbType = System.Data.SqlDbType.VarChar;
                pLastName.Value = last_name;
                sqlCommand.Parameters.Add(pLastName);

                SqlParameter pEmail = new SqlParameter();
                pEmail.ParameterName = "@n_email";
                pEmail.SqlDbType = System.Data.SqlDbType.VarChar;
                pEmail.Value = email;
                sqlCommand.Parameters.Add(pEmail);

                SqlParameter pPhone = new SqlParameter();
                pPhone.ParameterName = "@phone_num";
                pPhone.SqlDbType = System.Data.SqlDbType.VarChar;
                pPhone.Value = phone_number;
                sqlCommand.Parameters.Add(pPhone);

                SqlParameter pHireDate = new SqlParameter();
                pHireDate.ParameterName = "@hire_d";
                pHireDate.SqlDbType = System.Data.SqlDbType.VarChar;
                pHireDate.Value = hire_date;
                sqlCommand.Parameters.Add(pHireDate);

                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@n_salary";
                pSalary.SqlDbType = System.Data.SqlDbType.Int;
                pSalary.Value = salary;
                sqlCommand.Parameters.Add(pSalary);

                SqlParameter pCom = new SqlParameter();
                pCom.ParameterName = "@comission";
                pCom.SqlDbType = System.Data.SqlDbType.Decimal;
                pCom.Value = comission_pct;
                sqlCommand.Parameters.Add(pCom);

                SqlParameter pIdMan = new SqlParameter();
                pIdMan.ParameterName = "@id_manager";
                pIdMan.SqlDbType = System.Data.SqlDbType.Int;
                pIdMan.Value = manager_id;
                sqlCommand.Parameters.Add(pIdMan);

                SqlParameter pJob = new SqlParameter();
                pJob.ParameterName = "@id_job";
                pJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pJob.Value = job_id;
                sqlCommand.Parameters.Add(pJob);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = department_id;
                sqlCommand.Parameters.Add(pIdDep);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete Employees
        public static void DeleteEmployees(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM employees WHERE id = (@id_employees)";
            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@id_employees";
                pId.SqlDbType = System.Data.SqlDbType.Int;
                pId.Value = id;
                sqlCommand.Parameters.Add(pId);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Get Employees By Id
        public static void GetByIdEmployees(int id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM employees WHERE id = '"+ id+ "'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("ID: " + reader.GetInt32(i: 0));
                            Console.WriteLine("Full Name: " + reader.GetString(i: 1) + " " + reader.GetString(i: 10));
                            Console.WriteLine("Email: " + reader.GetString(i: 2));
                            Console.WriteLine("Phone Number: " + reader.GetString(i: 3));
                            Console.WriteLine("Hire Date: " + reader.GetDateTime(i: 4));
                            Console.WriteLine("Salary: " + reader.GetInt32(i: 5));
                            Console.WriteLine("Comission PCT: " + reader.GetDecimal(i: 6));
                            Console.WriteLine("Manager ID: " + reader.GetInt32(i: 7));
                            Console.WriteLine("Job ID: " + reader.GetString(i: 8));
                            Console.WriteLine("Department ID: " + reader.GetInt32(i: 9));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employees found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //CRUD table History

        //Get All History
        public static void GetHistory()
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM histories";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Start Date: " + reader.GetDateTime(i: 0));
                            Console.WriteLine("Employee ID: " + reader.GetInt32(i: 1));
                            Console.WriteLine("End Date: " + reader.GetDateTime(i: 2));
                            Console.WriteLine("Department ID: " + reader.GetInt32(i: 3));
                            Console.WriteLine("Job ID: " + reader.GetString(i: 4));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No History found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Insert History
        public static void InsertHistory(string start_date, int employee_id, string end_date, int department_id, string job_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "INSERT INTO histories VALUES (@start_d, @id_employee, @end_d, @id_department, @id_job)";
            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
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

                SqlParameter pEndD = new SqlParameter();
                pEndD.ParameterName = "@end_d";
                pEndD.SqlDbType = System.Data.SqlDbType.VarChar;
                pEndD.Value = end_date;
                sqlCommand.Parameters.Add(pEndD);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = department_id;
                sqlCommand.Parameters.Add(pIdDep);

                SqlParameter pIdJob = new SqlParameter();
                pIdJob.ParameterName = "@id_job";
                pIdJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdJob.Value = job_id;
                sqlCommand.Parameters.Add(pIdJob);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Insert Success");
                }
                else
                {
                    Console.WriteLine("Insert Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Update History
        public static void UpdateHistory(string start_date, int employee_id, string end_date, int department_id, string job_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "UPDATE histories SET end_date = (@end_d), department_id = (@id_department), job_id = (@id_job) WHERE employee_id = (@id_employee) AND start_date = (@start_d)";
            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
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

                SqlParameter pEndD = new SqlParameter();
                pEndD.ParameterName = "@end_d";
                pEndD.SqlDbType = System.Data.SqlDbType.VarChar;
                pEndD.Value = end_date;
                sqlCommand.Parameters.Add(pEndD);

                SqlParameter pIdDep = new SqlParameter();
                pIdDep.ParameterName = "@id_department";
                pIdDep.SqlDbType = System.Data.SqlDbType.Int;
                pIdDep.Value = department_id;
                sqlCommand.Parameters.Add(pIdDep);

                SqlParameter pIdJob = new SqlParameter();
                pIdJob.ParameterName = "@id_job";
                pIdJob.SqlDbType = System.Data.SqlDbType.VarChar;
                pIdJob.Value = job_id;
                sqlCommand.Parameters.Add(pIdJob);


                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Update Success");
                }
                else
                {
                    Console.WriteLine("Update Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Delete History
        public static void DeleteHistory(string start_date, int employee_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "DELETE FROM histories WHERE employee_id = (@id_employee) AND start_date = (@start_d)";
            _connection.Open();
            SqlTransaction transaction = _connection.BeginTransaction();
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
                if (result > 0)
                {
                    Console.WriteLine("Delete Success");
                }
                else
                {
                    Console.WriteLine("Delete Failed");
                }
                transaction.Commit();
                _connection.Close();
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Error connecting to database.");
            }
        }

        //Get History By Id Employee
        public static void GetByIdHistory(int employee_id)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = _connection;
            sqlCommand.CommandText = "SELECT * FROM histories WHERE employee_id = '"+ employee_id + "'";

            try
            {
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("=====================================");
                            Console.WriteLine("Start Date: " + reader.GetDateTime(i: 0));
                            Console.WriteLine("Employee ID: " + reader.GetInt32(i: 1));
                            Console.WriteLine("End Date: " + reader.GetDateTime(i: 2));
                            Console.WriteLine("Department ID: " + reader.GetInt32(i: 3));
                            Console.WriteLine("Job ID: " + reader.GetString(i: 4));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No History found.");
                    }
                    reader.Close();
                    _connection.Close();
                }
            }
            catch
            {
                Console.WriteLine("Error connecting to database.");
            }
        }

    }
}

