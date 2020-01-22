using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _429_InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Extending interface Compatible types ***\n");

            string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but",
            "in", "a", "weired", "way", "fun!"};
            data.PrintDataAndBeep();

            Console.WriteLine();

            List<int> myInts = new List<int>() { 10, 15, 20 };
            myInts.PrintDataAndBeep();

            Console.ReadLine();
        }
    }
}
