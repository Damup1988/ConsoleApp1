using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _413_OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Overloaded operatores ***");

            Point p1 = new Point(100, 100);
            Point p2 = new Point(40, 40);
            Console.WriteLine("p1 is : {0}", p1);
            Console.WriteLine("p2 is : {0}", p2);
            Console.WriteLine("p1 + p2: {0}", p1 + p2);
            Console.WriteLine("p1 - p2: {0}", p1 - p2);
            Console.WriteLine("p1 == p2: {0}", p1 == p2);

            Console.ReadLine();
        }
    }
}