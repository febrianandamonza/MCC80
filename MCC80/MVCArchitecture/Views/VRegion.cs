using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVCArchitecture.Views
{
    public class VRegion
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

        public void GetAll(List<Region> regions)
        {
            foreach (var region in regions)
            {
                GetById(region);
            }
        }
        public void GetById(Region region)
        {

            Console.WriteLine("Id: " + region.Id);
            Console.WriteLine("Name Region: " + region.Name);
            Console.WriteLine("=====================================");
        }
        

        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Menu Table Region");
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
        
        public Region InsertMenu()
        {
            Console.WriteLine("Inputkan Data");
            Console.Write("Name Region : ");
            string name = Console.ReadLine();

            return new Region
            {
                Id = 0,
                Name = name
            };
        }

        public Region UpdateMenu()
        {
            Console.Write("Id yang ingin diupdate : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name Region : ");
            string name = Console.ReadLine();

            return new Region
            {
                Id = id,
                Name = name
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
