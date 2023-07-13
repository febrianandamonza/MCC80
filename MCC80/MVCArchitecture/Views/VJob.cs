using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Views
{
    public class VJob
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

        public void GetAll(List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                GetById(job);
            }
        }
        public void GetById(Job job)
        {

            Console.WriteLine("Id: " + job.Id);
            Console.WriteLine("Title: " + job.Title);
            Console.WriteLine("Min Salary: " + job.MinSalary);
            Console.WriteLine("Max Salary: " + job.MaxSalary);
            Console.WriteLine("=====================================");
        }

        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table Job");
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

        public Job InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("ID : ");
            string id = Console.ReadLine();
            Console.Write("Title Name : ");
            string title = Console.ReadLine();
            Console.Write("Min Salary : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max Salary : ");
            int max = Convert.ToInt32(Console.ReadLine());

            return new Job
            {
                Id = id,
                Title = title,
                MinSalary = min,
                MaxSalary = max
            };
        }

        public Job UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            string id = Console.ReadLine();
            Console.Write("Title Name : ");
            string title = Console.ReadLine();
            Console.Write("Min Salary : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max Salary : ");
            int max = Convert.ToInt32(Console.ReadLine());

            return new Job
            {
                Id = id,
                Title = title,
                MinSalary = min,
                MaxSalary = max
            };
        }

        public string DeleteMenu()
        {
            Console.Write("Id yang ingin didelete : ");
            string id = Console.ReadLine();
            return id;
        }
    }
}
