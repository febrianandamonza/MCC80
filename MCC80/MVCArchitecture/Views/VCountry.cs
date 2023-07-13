using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVCArchitecture.Views
{
    public class VCountry
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

        public void GetAll(List<Country> countries)
        {
            foreach (var country in countries)
            {
                GetById(country);
            }
        }
        public void GetById(Country country)
        {

            Console.WriteLine("Id: " + country.Id);
            Console.WriteLine("Name Country: " + country.Name);
            Console.WriteLine("Region Id: " + country.RegionId);
            Console.WriteLine("=====================================");
        }

        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table Country");
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

        public Country InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("ID : ");
            string id = Console.ReadLine();
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Region ID : ");
            int region_id = Convert.ToInt32(Console.ReadLine());

            return new Country
            {
                Id = id,
                Name = name,
                RegionId = region_id
            };
        }
        public Country UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            string id = Console.ReadLine();
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Region ID : ");
            int region_id = Convert.ToInt32(Console.ReadLine());

            return new Country
            {
                Id = id,
                Name = name,
                RegionId = region_id
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
