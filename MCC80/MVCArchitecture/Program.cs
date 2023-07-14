using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecture.Controllers;
using MVCArchitecture.Models;
using MVCArchitecture.Views;

namespace MVCArchitecture
{
    public class Program
    {
        public static void Main()
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            bool exit = true;
            do
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
                Console.Write("Input Pilihan = ");
                try
                {
                    int pilihMenu = Int32.Parse(Console.ReadLine());

                    switch (pilihMenu)
                    {
                        case 1:
                            EmployeeMenu();
                            break;
                        case 2:
                            DepartmentMenu();
                            break;
                        case 3:
                            LocationMenu();
                            break;
                        case 4:
                            CountryMenu();
                            break;
                        case 5:
                            RegionMenu();
                            break;
                        case 6:
                            JobMenu();
                            break;
                        case 7:
                            HistoryMenu();
                            break;
                        case 8:
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("Silahkan Pilih Nomor 1-7");
                            PressAnyKey();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Input Hanya diantara 1-7!");
                    PressAnyKey();
                    Console.Clear();
                }
            } while (exit);
        }
        private static void RegionMenu()
        {
            Region region = new Region();
            VRegion vRegion = new VRegion();
            RegionController regionController = new RegionController(region, vRegion);

            bool isTrue = true;
            do
            {
                int pilihMenu = vRegion.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        regionController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        regionController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        regionController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            regionController.GetById(id);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        PressAnyKey();
                        break;

                    case 5:
                        regionController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void CountryMenu()
        {
            Country country = new Country();
            VCountry vCountry = new VCountry();
            CountryController countryController = new CountryController(country, vCountry);

            bool isTrue = true;
            do
            {
                int pilihMenu = vCountry.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        countryController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        countryController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        countryController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            string? id = Console.ReadLine();
                            countryController.GetById(id);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        countryController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void HistoryMenu()
        {
            History history = new History();
            VHistory vHistory = new VHistory();
            HistoryController historyController = new HistoryController(history, vHistory);

            bool isTrue = true;
            do
            {
                int pilihMenu = vHistory.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        historyController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        historyController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        try
                        {
                            Console.Write("Masukkan Employee Id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Start Date : ");
                            string start_date = Console.ReadLine();
                            historyController.Delete(start_date, id);
                        }
                        catch
                        {
                            EmptyInput() ;
                        }
                        
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            int id_employee = Convert.ToInt32(Console.ReadLine());
                            historyController.GetById(id_employee);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        historyController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void EmployeeMenu()
        {
            Employee employee = new Employee();
            VEmployee vEmployee = new VEmployee();
            EmployeeController employeeController = new EmployeeController(employee, vEmployee);

            bool isTrue = true;
            do
            {
                int pilihMenu = vEmployee.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        employeeController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        employeeController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        
                        employeeController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try 
                        {
                            Console.Write("Masukkan Id : ");
                            int id_employee = Convert.ToInt32(Console.ReadLine());
                            employeeController.GetById(id_employee);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        employeeController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void DepartmentMenu()
        {
            Department department = new Department();
            VDepartment vDepartment = new VDepartment();
            DepartmentController departmentController = new DepartmentController(department, vDepartment);

            bool isTrue = true;
            do
            {
                int pilihMenu = vDepartment.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        departmentController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        departmentController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        departmentController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            departmentController.GetById(id);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        departmentController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void JobMenu()
        {
            Job job = new Job();
            VJob vJob = new VJob();
            JobController jobController = new JobController(job, vJob);

            bool isTrue = true;
            do
            {
                int pilihMenu = vJob.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        jobController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        jobController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        jobController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            string id = Console.ReadLine();
                            jobController.GetById(id);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        jobController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void LocationMenu()
        {
            Location location = new Location();
            VLocation vLocation = new VLocation();
            LocationController locationController = new LocationController(location, vLocation);

            bool isTrue = true;
            do
            {
                int pilihMenu = vLocation.Menu();
                switch (pilihMenu)
                {
                    case 1:
                        locationController.Insert();
                        PressAnyKey();
                        break;
                    case 2:
                        locationController.Update();
                        PressAnyKey();
                        break;
                    case 3:
                        locationController.Delete();
                        PressAnyKey();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Masukkan Id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            locationController.GetById(id);
                        }
                        catch
                        {
                            EmptyInput();
                        }
                        
                        PressAnyKey();
                        break;

                    case 5:
                        locationController.GetAll();
                        PressAnyKey();
                        break;
                    case 6:
                        isTrue = false;
                        Console.Clear();
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            } while (isTrue);
        }

        private static void InvalidInput()
        {
            Console.WriteLine("Your input is not valid!");
        }

        private static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void EmptyInput()
        {
            Console.WriteLine("Your input is empty!");
        }
    }
}
