using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _466_FunWithLinqExpressions
{
    class Program
    {
        static void SelectEveryRhing(ProductInfo[] products)
        {
            Console.WriteLine("All products details");

            var subset = from c in products select c;

            foreach(var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("Only product names:");
            var subset = from c in products select c.Name;
            foreach(var p in subset)
            {
                Console.WriteLine(p);
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");

            var subset = from c in products where c.NumberInStock > 25 select c;
            foreach(var p in subset)
            {
                Console.WriteLine(p.Name);
            }
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var subset = from c in products select new { c.Name, c.Description };
            foreach(var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var sub = from c in products orderby c.Name select c;
            var sub2 = from c2 in products orderby c2.Name descending select c2;
            foreach(var v in sub)
            {
                Console.WriteLine(v.ToString());
            }
            foreach(var v in sub2)
            {
                Console.WriteLine(v);
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars1 = new List<string> { "BMW", "LADA", "HONDA"};
            List<string> myCars2 = new List<string> { "BMW", "LADA", "FORD" };

            var carDiff = (from c in myCars1 select c).Except(from c in myCars2 select c);
            foreach(var v in carDiff)
            {
                Console.WriteLine(v);
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars1 = new List<string> { "BMW", "LADA", "HONDA" };
            List<string> myCars2 = new List<string> { "BMW", "LADA", "FORD" };

            var intersect = (from c in myCars1 select c).Intersect(from c in myCars2 select c);
            foreach(var v in intersect)
            {
                Console.WriteLine(v);
            }
        }

        static void DisplayUnion()
        {
            List<string> myCars1 = new List<string> { "BMW", "LADA", "HONDA" };
            List<string> myCars2 = new List<string> { "BMW", "LADA", "FORD" };

            var nyUnion = (from c in myCars1 select c).Union(from c in myCars2 select c);
            foreach(var v in nyUnion)
            {
                Console.WriteLine(v);
            }
        }

        static void DisaplyContact()
        {
            List<string> myCars1 = new List<string> { "BMW", "LADA", "HONDA" };
            List<string> myCars2 = new List<string> { "BMW", "LADA", "FORD" };

            var myCont = (from c in myCars1 select c).Concat(from c in myCars2 select c);
            foreach(var v in myCont)
            {
                Console.WriteLine(v);
            }
        }

        static void DisplayConcatNoDups()
        {
            List<string> myCars1 = new List<string> { "BMW", "LADA", "HONDA" };
            List<string> myCars2 = new List<string> { "BMW", "LADA", "FORD" };

            var myCont = (from c in myCars1 select c).Concat(from c in myCars2 select c);
            foreach (var v in myCont.Distinct())
            {
                Console.WriteLine(v);
            }
        }

        static void AggregateOps()
        {
            double[] M = { 2.0, -21.3, 8, -4, 0, 8.2 };

            Console.WriteLine($"Max in M: {(from c in M select c).Max()}");
            Console.WriteLine($"Min in M: {(from c in M select c).Min()}");
            Console.WriteLine($"Aver in M: {(from c in M select c).Average()}");
            Console.WriteLine($"Sum in M: {(from c in M select c).Sum()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Query Expressions ***\n");

            ProductInfo[] ProductsInStock = new[]
            {
                new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
            };

            //SelectEveryRhing(ProductsInStock);
            //ListProductNames(ProductsInStock);
            //GetOverstock(ProductsInStock);
            //GetNamesAndDescriptions(ProductsInStock);
            //AlphabetizeProductNames(ProductsInStock);
            //DisplayDiff();
            //DisplayIntersection();
            //DisplayUnion();
            //DisaplyContact();
            //DisplayConcatNoDups();
            AggregateOps();

            Console.ReadLine();
        }
    }
}

//471