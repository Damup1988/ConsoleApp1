using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _386_CarEvents
{
    class Program
    {
        /*static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.Msg);
        }

        static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.Msg);
        }

        static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.Msg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with events! ***");

            Car MyCar = new Car(10, 100, "Peugoet");
            //MyCar.Event_AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            //MyCar.Event_AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);
            MyCar.Event_AboutToBlow += CarIsAlmostDoomed;
            MyCar.Event_AboutToBlow += CarAboutToBlow;
            MyCar.Event_Exploded += CarExploded;

            Console.WriteLine("*** Speeding up ***");
            for (int i = 0; i < 6; i++)
                MyCar.Accelerate(20);

            MyCar.Event_Exploded -= CarExploded;

            for (int i = 0; i < 6; i++)
                MyCar.Accelerate(20);

            Console.ReadLine();
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("*** Anonymous methods ***\n");

            Car MyCar = new Car(10, 100, "Peugoet");

            MyCar.Event_AboutToBlow += delegate
            {
                Console.WriteLine("Going to fast!");
            };
            MyCar.Event_AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Message from the car: {0}", e.Msg);
            };
            MyCar.Event_Exploded += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Fatal message from the car: {0}", e.Msg);
            };

            for (int i = 0; i < 6; i++)
                MyCar.Accelerate(20);

            Console.ReadLine();
        }
    }
}