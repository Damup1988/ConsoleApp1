using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _379_CarDelegateMethodGroupConversion
{
    class Program
    {
        static void CallMeHere(string Msg)
        {
            Console.WriteLine("=> Message from Car: {0}", Msg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Method group conversion ***\n");

            Car MyCar = new Car();
            MyCar.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("*** Speeding up ***");
            for (int i = 0; i < 6; i++)
                MyCar.Accelerate(20);

            MyCar.UnRegisterWithCarEngine(CallMeHere);

            for (int i = 0; i < 6; i++)
                MyCar.Accelerate(20);

            Console.ReadLine();
        }
    }
}