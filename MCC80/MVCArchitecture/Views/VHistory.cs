using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVCArchitecture.Views
{
    public class VHistory
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

        public void GetAll(List<History> histories)
        {
            foreach (var history in histories)
            {
                GetById(history);
            }
        }

        public void GetById(History history)
        {

            Console.WriteLine("Start Date: " + history.StartDate);
            Console.WriteLine("Employee Id: " + history.EmployeeId);
            Console.WriteLine("End Date: " + history.EndDate);
            Console.WriteLine("Department Id: " + history.DepartmentId);
            Console.WriteLine("Job Id: " + history.JobId);
            Console.WriteLine("=====================================");
        }
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table History");
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
        public History InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("Start Date : ");
            DateTime start_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Employee ID : ");
            int employee_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("End Date : ");
            DateTime end_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Department ID : ");
            int department_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job ID : ");
            string job_id = Console.ReadLine();

            return new History
            {
                StartDate = start_date,
                EmployeeId = employee_id,
                EndDate = end_date,
                DepartmentId = department_id,
                JobId = job_id
            };
        }
        public History UpdateMenu()
        {
            Console.Write("Employee ID yang ingin diupdate: ");
            int employee_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Start Date yang ingin diupdate : ");
            DateTime start_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("End Date : ");
            DateTime end_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Department ID : ");
            int department_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job ID : ");
            string job_id = Console.ReadLine();

            return new History
            {
                StartDate = start_date,
                EmployeeId = employee_id,
                EndDate = end_date,
                DepartmentId = department_id,
                JobId = job_id
            };
        }
        public void DeleteMenu()
        {
            Console.Write("Employee ID yang ingin didelete: ");
            int employee_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Start Date yang ingin didelete : ");
            string start_date = Console.ReadLine(); 

            
        }
    }
}
