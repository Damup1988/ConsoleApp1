using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalss p1 = new MyCalss(10, 5);
            Console.WriteLine("P1 =>");
            p1.Display();           

            MyCalss p2;

            p2 = p1;

            Console.WriteLine("P2 =>");
            p2.Display();

            p1.x = 11;

            Console.WriteLine("P2 => after p1.x = 11");
            p2.Display();

            Console.WriteLine("==========================================");

            MyStruct s1 = new MyStruct(3, 4);
            Console.WriteLine("Struct s1 =>");
            s1.StructDisplay();

            MyStruct s2;

            s2 = s1;

            Console.WriteLine("Struct s2 =>");
            s2.StructDisplay();

            s1.x = 99;

            Console.WriteLine("Struct s1 after s1.x = 99 =>");
            s1.StructDisplay();
            Console.WriteLine("Struct s2 after s1.x = 99 =>");
            s2.StructDisplay();

            Console.ReadLine();
        }
    }
}
