﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _380_GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T arg);

    class Program
    {
        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Generic Delegates ***\n");

            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            StringTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.ReadLine();
        }
    }
}