using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _438_UnsafeCode
{
    class PointRef
    {
        public int x;
        public int y;
        public override string ToString() => $"({x}, {y})";

        public unsafe static void UseAndPinPoint()
        {
            PointRef pt = new PointRef
            {
                x = 5,
                y = 6
            };

            // Pin pt in place so it will not
            // be moved or GC-ed.
            fixed (int* p = &pt.x)
            {
                // Use int* variable here!
            }

            // pt is now unpinned, and ready to be GC-ed once
            // the method completes.
            Console.WriteLine("Point is {0}", pt);
        }

        unsafe static void UseSizeOfOperator()
        {
            Console.WriteLine("The size of Points is {0}", sizeof(Point));
        }
    }
}
