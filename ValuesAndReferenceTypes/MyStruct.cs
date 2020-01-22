using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferenceTypes
{
    struct MyStruct
    {
        public int x, y;

        public MyStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void StructDisplay()
        {
            Console.WriteLine("X = {0}, Y = {1}", x, y);
        }
    }
}
