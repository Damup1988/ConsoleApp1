using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferenceTypes
{
    public class MyCalss
    {
        public int x, y;

        public MyCalss(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", x, y);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
