using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _438_UnsafeCode
{
    struct Point
    {
        public int x;
        public int y;

        public override string ToString() => $"({x}, {y})";

        static unsafe void UsePointerToPint()
        {
            Point point;
            Point* p = &point;
            // using "->" instead of "."
            p->x = 100;
            p->y = 200;
            Console.WriteLine(p->ToString());

            //if you prefere to user ".", then:
            Point point2;
            Point* p2 = &point2;
            (*p2).x = 100;
            (*p2).y = 200;
            Console.WriteLine((*p2).ToString());
        }
    }
}
