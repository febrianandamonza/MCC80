using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Views
{
    public class VLocation
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

        public void GetAll(List<Location> locations)
        {
            foreach (var location in locations)
            {
                GetById(location);
            }
        }
        public void GetById(Location location)
        {

            Console.WriteLine("Id: " + location.Id);
            Console.WriteLine("Street Address: " + location.StreetAddress);
            Console.WriteLine("Postal Code: " + location.PostalCode);
            Console.WriteLine("City: " + location.City);
            Console.WriteLine("State Province: " + location.StateProvince);
            Console.WriteLine("Country Id: " + location.CountryId);
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

        public Location InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Street Address : ");
            string street_add = Console.ReadLine();
            Console.Write("Postal Code : ");
            string postal_c = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State Province : ");
            string state_prov = Console.ReadLine();
            Console.Write("Country ID : ");
            string country_id = Console.ReadLine();

            return new Location
            {
                Id = id,
                StreetAddress = street_add,
                PostalCode = postal_c,
                City = city,
                StateProvince = state_prov,
                CountryId = country_id
            };
        }

        public Location UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Street Address : ");
            string street_add = Console.ReadLine();
            Console.Write("Postal Code : ");
            string postal_c = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State Province : ");
            string state_prov = Console.ReadLine();
            Console.Write("Country ID : ");
            string country_id = Console.ReadLine();

            return new Location
            {
                Id = id,
                StreetAddress = street_add,
                PostalCode = postal_c,
                City = city,
                StateProvince = state_prov,
                CountryId = country_id
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
