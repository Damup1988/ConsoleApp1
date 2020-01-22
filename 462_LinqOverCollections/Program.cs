using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _462_LinqOverCollections
{
    class Program
    {
        static void GetFastCar(List<Car> MyCars)
        {
            var fastCars = from c in MyCars where c.Speed > 55 select c;

            foreach(var car in fastCars)
            {
                Console.WriteLine(car.Name);
            }
        }

        static void GetFastBMW(List<Car> MyCars)
        {
            var fastBMW = from c in MyCars where c.Make == "BMW" && c.Speed > 90 select c;

            foreach(var car in fastBMW)
            {
                Console.WriteLine(car.Name);
            }
        }

        static void LINQOverArrayList()
        {
            Console.WriteLine("*** LINQ over ArrayList ***\n");

            ArrayList myCars = new ArrayList()
            {
                new Car{ Name = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ Name = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ Name = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ Name = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ Name = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            var myCarsEnum = myCars.OfType<Car>();

            var fastCar = from c in myCarsEnum where c.Speed > 55 select c;

            foreach(var car in fastCar)
            {
                Console.WriteLine(car.Name);
            }
        }

        static void Main(string[] args)
        {
            List<Car> MyCars = new List<Car>()
            {
                new Car{ Name = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ Name = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ Name = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ Name = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ Name = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            GetFastCar(MyCars);
            GetFastBMW(MyCars);
            LINQOverArrayList();

            Console.ReadLine();
        }
    }
}
