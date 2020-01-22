using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _407_Understanding_Indexer_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i  < args.Length; i++)
            {
                Console.WriteLine("Args: {0}", args[i]);
            }

            int[] myInts = { 10, 9, 100, 432, 9874 };

            for (int j = 0; j < myInts.Length; j++)
            {
                Console.WriteLine("Index {0} = {1}", j, myInts[j]);                
            }

            Console.ReadLine();
        }
    }
}