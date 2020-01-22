using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _438_UnsafeCode
{
    class Program
    {
        static unsafe void SquarePointer(int* myIntPointer)
        {
            *myIntPointer *= *myIntPointer;
        }

        static unsafe void PrintValueAndAddress()
        {
            Console.WriteLine("*** PrintValueAndAddress() ***\n");
            int myInt;
            int* pointerToMyInt = &myInt;
            *pointerToMyInt = 123;
            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Address of myInt {0:X}", (int)&pointerToMyInt);
        }

        static unsafe void UnSafeSwap(int* i, int* j)
        {
            Console.WriteLine("Unsafe swap");
            int temp = *i;
            *i = *j;
            *j = temp;
        }

        static unsafe void SafeSwap(ref int i, ref int j)
        {
            Console.WriteLine("Safe swap");
            int temp = i;
            i = j;
            j = temp;
        }

        static unsafe void Main(string[] args)
        {
            unsafe
            {
                int myInt = 10;
                SquarePointer(&myInt);
                Console.WriteLine("myInt: {0}", myInt);
            }

            int myInt2 = 5;
            SquarePointer(&myInt2);

            PrintValueAndAddress();

            Console.WriteLine("*** Calling the method with unsafe swap ***\n");
            int i = 10, j = 20;
            Console.WriteLine("Values before swap i = {0}, j = {1}", i, j);
            UnSafeSwap(&i, &j);
            Console.WriteLine("Values after swap i = {0}, j = {1}", i, j);
            Console.WriteLine("Values before swap i = {0}, j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("Values before swap i = {0}, j = {1}", i, j);

            Console.ReadLine();
        }
    }
}

// 447