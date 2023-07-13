using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Views
{
    public class VEmployee
    {
        public void DataEmpty()
        {
            Console.WriteLine("Data Not Found!");
        }

        public void Success()
        {
            Console.WriteLine("Success!");
        }

        public void Failure()
        {
            Console.WriteLine("Fail, Id not found!");
        }

        public void Error()
        {
            Console.WriteLine("Error retrieving from database!");
        }

        public void GetAll(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                GetById(employee);
            }
        }

        public void GetById(Employee employee)
        {
            
            Console.WriteLine("ID: " + employee.Id);
            Console.WriteLine("Full Name: " + employee.FirstName + " " + employee.LastName);
            Console.WriteLine("Email: " + employee.Email);
            Console.WriteLine("Phone Number: " + employee.PhoneNumber);
            Console.WriteLine("Hire Date: " + employee.HireDate);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Comission PCT: " + employee.ComissionPCT);
            Console.WriteLine("Manager ID: " + employee.ManagerId);
            Console.WriteLine("Job ID: " + employee.JobId);
            Console.WriteLine("Department ID: " + employee.DepertmentId);
            Console.WriteLine("=====================================");
        }
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table Employee");
            Console.WriteLine("          By Febri Ananda Monza");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Get By Id");
            Console.WriteLine("5. Get All");
            Console.WriteLine("6. Back");
            Console.Write("Input Pilihan = ");
            int pilihan = Int32.Parse(Console.ReadLine());

            return pilihan;
        }

        public Employee InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Name : ");
            string first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            string last_name = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            Console.Write("Phone Number : ");
            string phone = Console.ReadLine();
            Console.Write("Hire Date (MM//DD/YYYY) : ");
            DateTime hire_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Comission PCT : ");
            decimal comission = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Job ID : ");
            string job_id = Console.ReadLine();
            Console.Write("Department ID : ");
            int department_id = Convert.ToInt32(Console.ReadLine());

            return new Employee
            {
                Id = id,
                FirstName = first_name,
                LastName = last_name,
                Email = email,
                PhoneNumber = phone,
                HireDate = hire_date,
                Salary = salary,
                ComissionPCT = comission,
                ManagerId = id,
                JobId = job_id,
                DepertmentId = department_id
            };
        }
        public Employee UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Name : ");
            string first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            string last_name = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            Console.Write("Phone Number : ");
            string phone = Console.ReadLine();
            Console.Write("Hire Date (MM//DD/YYYY) : ");
            DateTime hire_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Comission PCT : ");
            decimal comission = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Job ID : ");
            string job_id = Console.ReadLine();
            Console.Write("Department ID : ");
            int department_id = Convert.ToInt32(Console.ReadLine());

            return new Employee
            {
                Id = id,
                FirstName = first_name,
                LastName = last_name,
                Email = email,
                PhoneNumber = phone,
                HireDate = hire_date,
                Salary = salary,
                ComissionPCT = comission,
                ManagerId = id,
                JobId = job_id,
                DepertmentId = department_id
            };
        }
        public int DeleteMenu()
        {
            Console.Write("Id yang ingin didelete : ");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
    }
}
