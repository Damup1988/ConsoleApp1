using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referal_variables
{
    class Program
    {
        static int x;
        static int z;
        static void Main(string[] args)
        {
            Foo(out x, out z);

            Console.WriteLine("X and Z:");
            Console.WriteLine(x);
            Console.WriteLine(z);

            Console.ReadLine();
        }

        static void Foo(out int y, out int h)
        {
            Console.WriteLine(x); // 0
            y = 1;
            
            Console.WriteLine(x); // 1

            Console.WriteLine(z); // 0
            h = y + 1;
            Console.WriteLine(z); // 2
        }
    }
}
