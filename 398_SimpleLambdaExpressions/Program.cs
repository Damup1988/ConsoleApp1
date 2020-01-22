using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _398_SimpleLambdaExpressions
{
    class Program
    {
        static bool IsEvenNumber(int i) => (i % 2) == 0;

        static void TraditionalDelegateSyntax()
        {
            List<int> MyIntList = new List<int>();
            MyIntList.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //Predicate<int> callback = IsEvenNumber;
            //List<int> evenNumbers = MyIntList.FindAll(callback);

            //List<int> evenNumbers = MyIntList.FindAll(delegate (int i) { return (i % 2) == 0; });

            List<int> evenNumbers = MyIntList.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach(int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }

            List<int> MyIntList2 = new List<int>();
            MyIntList2.AddRange(new int[] { 40, 3, 8, 16, 11, 88 });

            List<int> evenNumbers2 = MyIntList2.FindAll((i) =>
            {
                Console.WriteLine("value of i currently is {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers2)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Lamdas ***\n");
            TraditionalDelegateSyntax();
            Console.ReadLine();
        }
    }
}