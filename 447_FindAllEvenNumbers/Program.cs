using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _447_FindAllEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

            List<int> myList2 = new List<int>(new int[] { 1, 2, 3});

            List<int> evenNumbers = myList.FindAll(i => (i % 2) == 0);

            List<object> myList3 = new List<object>();
            myList3.AddRange(new object[] { 1, "a", 12});

            evenNumbers.Count();
            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            foreach(object obj in myList3)
            {
                Console.WriteLine(obj.GetType());
            }

            Console.WriteLine("Amount of even numbers in myList is {0}", evenNumbers.Count());
            Console.ReadLine();
        }
    }
}
