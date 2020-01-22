using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _460_LinqRetValues
{
    class Program
    {
        static IEnumerable<string> GetStringSubset()
        {
            string[] Colours = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            return from c in Colours where c.Contains("Red") select c;            
        }

        static string[] GetStringSubset2()
        {
            string[] Colours = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
            return (from c in Colours where c.Contains("Red") select c).ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** LINQ Return Values ***\n");
            IEnumerable<string> subset = GetStringSubset();

            foreach(string s in subset)
            {
                Console.WriteLine(s);
            }

            foreach(string s2 in GetStringSubset2())
            {
                Console.WriteLine(s2);
            }
        }
    }
}


//462