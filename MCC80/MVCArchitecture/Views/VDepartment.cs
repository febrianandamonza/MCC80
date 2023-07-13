using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVCArchitecture.Views
{
    public class VDepartment
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

        public void GetAll(List<Department> departments)
        {
            foreach (var department in departments)
            {
                GetById(department);
            }
        }
        public void GetById(Department department)
        {

            Console.WriteLine("Department Id: " + department.Id);
            Console.WriteLine("Department Name: " + department.Name);
            Console.WriteLine("Location Id: " + department.LocationId);
            Console.WriteLine("MenagerId: " + department.ManagerId);
            Console.WriteLine("=====================================");
        }

        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table Department");
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
        public Department InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Location ID : ");
            int location_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Manager ID : ");
            int manager_id = Convert.ToInt32(Console.ReadLine());

            return new Department
            {
                Id = id,
                Name = name,
                LocationId = location_id,
                ManagerId = manager_id
            };
        }

        public Department UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Location ID : ");
            int location_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Manager ID : ");
            int manager_id = Convert.ToInt32(Console.ReadLine());

            return new Department
            {
                Id = id,
                Name = name,
                LocationId = location_id,
                ManagerId = manager_id
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
