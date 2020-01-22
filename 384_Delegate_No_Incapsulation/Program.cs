using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _384_Delegate_No_Incapsulation
{
    class Program
    {
        static void CallWhenExploded(string Msg)
        {
            Console.WriteLine(Msg);
        }

        static void CallHereToo(string Msg)
        {
            Console.WriteLine(Msg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** No encapsulation ***");

            Car MyCar = new Car();

            MyCar.ListOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
            MyCar.Accelerate(10);

            MyCar.ListOfHandlers = new Car.CarEngineHandler(CallHereToo);
            MyCar.Accelerate(10);

            MyCar.ListOfHandlers.Invoke("He he he");

            Console.ReadLine();
        }
    }
}