using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451_LinqOverArray
{
    class Program
    {
        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8, 7 };             

            //IEnumerable<int> subSet = numbers.Where(g => g < 10).Select(g => g);
            //IEnumerable<int> subSet = from i in numbers where i < 10 select i;
            var subSet = from i in numbers where i < 10 select i;
            ReflectOverQueryResults(subSet);

            foreach(var n in subSet)
            {
                Console.WriteLine(n);
            }

            numbers[0] = 4;

            foreach (var n in subSet)
            {
                Console.WriteLine(n);
            }
        }

        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"*** Info about your query using {queryType} ***");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }

        static void FindSpace()
        {
            string[] s = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2", "f" };
            List<string> MyList = new List<string>();

            foreach(string cur_s in s)
            {
                if(cur_s.Contains(" "))
                {
                    MyList.Add(cur_s);
                }
            }

            MyList.Sort();
            foreach(string s2 in MyList)
            {
                Console.WriteLine(s2);
            }
        }

        static void QueryOverString()
        {
            string[] s = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2", "f" };
            //IEnumerable<string> subset = from g in s where g.Contains(" ") orderby g select g;
            //IEnumerable<string> subset = s.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);
            var subset = s.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            ReflectOverQueryResults(subset, "Extension Methods");

            foreach(string S in subset)
            {
                Console.WriteLine("Item: {0}", S);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun wint LINQ to objects ***");
            //QueryOverString();
            //FindSpace();
            QueryOverInts();
            Console.ReadLine();
        }
    }
}

//460